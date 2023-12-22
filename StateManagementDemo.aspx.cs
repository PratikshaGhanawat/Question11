using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question4validation
{
    public partial class StateManagementDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if there is data in the ViewState
                if (ViewState["UserInfo"] != null)
                {
                    string userInfo = ViewState["UserInfo"].ToString();
                    lblViewStateInfo.Text = $"View State Info: {userInfo}";
                }
            }
        }

        protected void btnSavePreferences_Click(object sender, EventArgs e)
        {
            // Store user preferences in Session State
            Session["Username"] = txtUsername.Text;
            Session["Theme"] = ddlTheme.SelectedValue;

            // Store a piece of information in View State
            ViewState["UserInfo"] = $"Username: {txtUsername.Text}, Theme: {ddlTheme.SelectedValue}";

            // Display user preferences
            lblViewStateInfo.Text = $"View State Info: {ViewState["UserInfo"]}";
        }

        protected void btnClearSession_Click(object sender, EventArgs e)
        {
            // Clear Session State data
            Session.Clear();
            lblViewStateInfo.Text = "View State Info: (Cleared)";
        }
    }
}