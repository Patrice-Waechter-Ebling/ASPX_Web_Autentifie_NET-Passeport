using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace ASPX_Web_Autentifie_NET_Passeport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
