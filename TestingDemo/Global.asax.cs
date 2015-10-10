using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestingDemo.Domain;
using TestingDemo.ViewModels;

namespace TestingDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            MappingConfig.RegisterConfig();
        }
    }

    public static class MappingConfig
    {
        public static void RegisterConfig()
        {
            // Presentation
            AutoMapper.Mapper.CreateMap<Employee, EmployeeEdit>().ReverseMap();
            AutoMapper.Mapper.CreateMap<Employee, EmployeeListItem>();
            AutoMapper.Mapper.CreateMap<Employee, EmployeeDelete>();

            // Infrastructure
            AutoMapper.Mapper.CreateMap<Employee, Infrastructure.Models.Employee>().ReverseMap();
        }
    }
}
