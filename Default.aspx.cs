using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using TDBWebService;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //TDBWebService.WebServiceSoapClient tdbS = new TDBWebService.WebServiceSoapClient();

            //lblWS.Text=tdbS.eContractorSignUp("mr_contractor8", 2, "mr_contractor8@dbgurus.com.au", "dbg123!", "", "");
           
        }
        catch(Exception ex)
        {
            lblWS.Text=ex.Message + " ---"+ ex.StackTrace;
        }
        

    }
}