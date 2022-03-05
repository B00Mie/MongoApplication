using MongoDbApplication.Context;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MongoDbApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MongoDbContext.Init(ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString);
            MongoDbContext.PassSampleData();
        }
    }
}
