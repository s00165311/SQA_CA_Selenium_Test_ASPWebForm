using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using SqaAssignment;
public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Button1_Click(object sender, EventArgs e)
    {
        CalculatePremium newCalc = new CalculatePremium();
        int age = Convert.ToInt32(Request.Form["iAge"]);
        string gender = String.Format("{0}", Request.Form["iGender"]);
        double result = newCalc.CalcPremium(age, gender);
        string resultotstring = result.ToString();

        TextArea1.Text = result.ToString();
    }
}
