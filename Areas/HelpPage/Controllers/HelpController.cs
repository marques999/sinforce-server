using System;
using System.Web.Http;
using System.Web.Mvc;

using FirstREST.Areas.HelpPage.Models;

namespace FirstREST.Areas.HelpPage.Controllers
{
    public class HelpController : Controller
    {
        public HelpController() : this(GlobalConfiguration.Configuration)
        {
        }

        public HelpController(HttpConfiguration config)
        {
            Configuration = config;
        }

        public HttpConfiguration Configuration
        {
            get;
            private set;
        }

        public ActionResult Index()
        {
            return View(Configuration.Services.GetApiExplorer().ApiDescriptions);
        }

        public ActionResult Api(string apiId)
        {
            if (!string.IsNullOrEmpty(apiId))
            {
                var apiModel = Configuration.GetHelpPageApiModel(apiId);

                if (apiModel != null)
                {
                    return View(apiModel);
                }
            }

            return View("Error");
        }
    }
}