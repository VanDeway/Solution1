using System;
using System.Windows.Forms;
using XMLDaClient.XMLWrapper;

namespace XMLDaClient
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnRead_Click(object sender, EventArgs e)
    {

    }

    private void btnWrite_Click(object sender, EventArgs e)
    {
      OPC_XML_DA_WrapperService service = new OPC_XML_DA_WrapperService();
      service.Url = "http://192.168.0.102:81/soap";
    }
  }
}
