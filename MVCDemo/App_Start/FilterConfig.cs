using System.Web;
using System.Web.Mvc;


//http://stackoverflow.com/questions/26347071/what-is-the-purpose-of-filterconfig-registerglobalfiltersglobalfilters-filters
//You can add custom filters to this list that should be executed on each request. If you inherit from the FilterAttribute class or one of its inheritors you can create your own filters, for instance a log filter

//    https://msdn.microsoft.com/en-us/library/gg416513(VS.98).aspx
//Sometimes you want to perform logic either before an action method is called or after an action method runs. To support this, ASP.NET MVC provides filters. Filters are custom classes that provide both a declarative and programmatic means to add pre-action and 
//post-action behavior to controller action methods.
namespace MVCDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

//You can think of it as a little box that sits between the users browser and your controller and filters out any invalid requests, or one 
//the executes when a controller is done and 
//you need to postprocess the result to the user.