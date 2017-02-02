using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Login newLogin;

        if(txtPassword.Value == "asdf" && txtUserName.Value == "Admin")
        {
            newLogin = new Login(1); //Temp admin
        }
        else if(txtUserName.Value == "matt" && txtPassword.Value == "1234")
        {
            newLogin = new Login(2); //Temp teacher
        }
        else if(txtPassword.Value == "awer" && txtUserName.Value == "blake")
        {
            newLogin = new Login(3); //Temp student
        }
        else
        {
            newLogin = new Login(4); //Default Case;
        }

        if(newLogin.IsLoggedIn())
        {
            switch(newLogin.loginType())
            {
                case "A":
                    Response.Redirect("AdminHome.aspx", false);
                    break;
                case "T":
                    Response.Redirect("TeacherHome.aspx", false);
                    break;
                case "S":
                    Response.Redirect("StudentHome.aspx", false);
                    break;
                default:
                    Response.Write("Error Logging in...");
                    break;
            }
        }
    }
}