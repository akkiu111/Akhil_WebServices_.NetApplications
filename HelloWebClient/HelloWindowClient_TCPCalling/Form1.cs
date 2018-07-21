using System;
using System.Windows.Forms;

namespace HelloWindowClient_TCPCalling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("NetTcpBinding_IHelloService");
            label1.Text = client.GetMessage(textBox1.Text);
        }
    }
}
