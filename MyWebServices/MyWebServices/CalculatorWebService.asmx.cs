using System.Collections.Generic;
using System.Web.Services;

namespace MyWebServices
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://akhil.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {
        List<string> calculations;

        [WebMethod(EnableSession = true, Description = "Ths method adds two numbers", CacheDuration = 20)]
        //[WebMethod]
        public int Add(int fn, int sn)
        {

            //List<string> calculations;

            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }

            //string strRecentCalculation = fn.ToString() + " + " + sn.ToString() + " = " + (fn + sn).ToString();

            //calculations.Add(strRecentCalculation);
            Session["CALCULATIONS"] = RecentCalculations(fn, sn);

            return fn + sn;
        }

        [WebMethod(MessageName = "additionof3values")]
        public int Add(int fn, int sn, int tn)
        {

            return fn + sn + tn;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You haven't performed any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }

        }

        private List<string> RecentCalculations(int fn, int sn)
        {
            string strRecentCalculation = fn.ToString() + " + " + sn.ToString() + " = " + (fn + sn).ToString();
            calculations.Add(strRecentCalculation);
            return calculations;
        }
    }
}
