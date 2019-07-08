using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static PeopleSearch.Web.Controllers.Api.PeopleSearchAPIController;
using static PeopleSearch.Web.Controllers.PeopleSearchController;
namespace PeopleSearch.Web.Controllers
{
    public class PeopleSearchController : Controller
    {
        //[HttpGet]
        //public ActionResult PeopleSearch() => View();

        [HttpGet]
        public ActionResult PeopleSearch(SearchParams ownerPortalParams)
        {
            return View();
        }

        [HttpGet]
        public ActionResult GlobalVariablesScript()
        {
            var globalVariablesScript = new System.Text.StringBuilder();
            var applicationBase = ((Request.Url?.GetLeftPart(UriPartial.Authority) ?? "") + Request.ApplicationPath).TrimEnd('/');

            globalVariablesScript.AppendLine("var peopleSearch = peopleSearch || {};");
            globalVariablesScript.AppendLine($"peopleSearch.applicationBase = '{applicationBase}';");
            globalVariablesScript.AppendLine($"peopleSearch.applicationPath = '{Request.ApplicationPath}';");

            return new JavaScriptResult() { Script = globalVariablesScript.ToString() };
        }
       
    }
}