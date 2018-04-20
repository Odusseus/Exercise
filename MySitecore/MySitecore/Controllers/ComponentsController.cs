using System;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;

namespace MySitecore.Controllers
{
    public class ComponentsController : SitecoreController
    {
        // GET: Components
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult HeroSlider()
        {
            Item contentItem = null;
            var database = Context.Database;

            if (database != null)
            {
                if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
                {
                    try
                    {
                        contentItem = database.GetItem(new Sitecore.Data.ID(RenderingContext.Current.Rendering.DataSource));

                    }
                    catch (Exception ex)
                    {
                        string x = ex.Message;
                    }
                }
            }
            return View(contentItem);
        }
    }
}