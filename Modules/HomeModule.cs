using Nancy;
using System.Collections.Generic;
using CdList.Objects;

namespace CdList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
    Get["/"] =_=> {
      return View["index.cshtml"];
    };
    Get["/addNew"] = _ =>{
      return View["addNew.cshtml"];
    };
    Get["/allCds"] = _ =>{
      List<Cd> allcds = Cd.GetAll();
      return View["allCds.cshtml",allcds];
    };
    Get["/searchByArtist"] = _ =>{
      return View["searchByArtist.cshtml"];
    };

    Get["/result"] = _ =>{
      List<Cd> invCd = Cd.Find(Request.Query["search-artist"]);
      return View["searchResult.cshtml",invCd];
    };
    Post["/add_new"] = _ =>{
      Cd oneCd = new Cd(Request.Form["artist"],Request.Form["title"]);
      return View["add_one.cshtml",oneCd];
    };
    }
  }
}
