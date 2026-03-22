using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPX_Web_Autentifie_NET_Passeport.Account
{
    public partial class SignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                // Rediriger vers la page d'accueil si l'utilisateur est authentifié.
                Response.Redirect("~/");
            }
        }
    }
}