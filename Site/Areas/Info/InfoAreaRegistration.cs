using System.Web.Mvc;
using Sdl.Web.Mvc.Configuration;
using Sdl.Web.Site.Areas.Info.Models;

namespace Sdl.Web.Site.Areas.Info
{
    public class InfoAreaRegistration : BaseAreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Info";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Info_default",
                "Info/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }

        protected override void RegisterAllViewModels()
        {
            RegisterViewModel("AssemblyInfos", typeof(AssemblyInfos));
            RegisterViewModel("AssemblyInfo", typeof(AssemblyInfo));
        }
    }
}