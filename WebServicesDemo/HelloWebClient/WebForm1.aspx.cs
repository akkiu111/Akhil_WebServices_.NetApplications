using System;

namespace HelloWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloWebService.HelloWebServiceSoapClient client = new HelloWebService.HelloWebServiceSoapClient();
            Label1.Text = client.GetMessage(TextBox1.Text);
        }
    }
}