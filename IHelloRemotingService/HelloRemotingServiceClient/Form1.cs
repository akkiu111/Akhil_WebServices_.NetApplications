using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace HelloRemotingServiceClient
{
    public partial class Form1 : Form
    {
        IHelloRemotingService.IHelloRemotingService client;
        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (IHelloRemotingService.IHelloRemotingService)Activator.GetObject
                (typeof(IHelloRemotingService.IHelloRemotingService),
                "tcp://localhost:8081/GetMessage");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = client.GetMessage(textBox1.Text);
        }
    }
}
