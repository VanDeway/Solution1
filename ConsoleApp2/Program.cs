using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  class Program
  {
    static String byte2string(byte[] dat)
    {
      StringBuilder sb = new StringBuilder();
      foreach (byte a in dat)
        sb.Append(a.ToString("x2") + " ");
      return (sb.ToString());
    }


    static void Main()
    {
      Console.Title = $"{DateTime.Now}";
      TcpClient tcpClient = new TcpClient("192.168.1.88",502);
      NetworkStream netStream = tcpClient.GetStream();
      byte[] d = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x00, 0x00, 0x1f };
      Task.Run(async () =>
      {
        UInt16 count = 0;
        while(true)
        {
          byte[] s = BitConverter.GetBytes(count);
          Array.Reverse<byte>(s);
          
          Buffer.BlockCopy(s, 0, d, 0, 2);
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine($"[{DateTime.Now}]发送: {byte2string(d)}");
          if (netStream.CanWrite)
          {
            await netStream.WriteAsync(new ReadOnlyMemory<byte>(d));
            await netStream.FlushAsync();
          }
          else
            break;

          if (netStream.CanRead)
          {
            await Task.Run(() => { while (!netStream.DataAvailable) ; });
            Memory<byte> revbuf = new Memory<byte>(new byte[1024]);
            var ret = netStream.ReadAsync(revbuf);
            if ((++count % 100) == 0)
            {
              Console.Clear();
              count = 0;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{DateTime.Now}]接收: {byte2string(revbuf.ToArray()[0..ret.Result])}");
            //Encoding.UTF8.GetString(revbuf.ToArray(), 0, ret.Result);
          }
          else
            break;

          Console.WriteLine();
          await Task.Delay(10000);
        }
      });

      //Console.WriteLine("Hello World!");
      Console.ReadLine();
    }
  }
}
