using Megyek.Models.Part;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace Megyek.Controllers
{
    public class PartController : Controller
    {
        
         public IActionResult Part(String part)
         {
             ServicePointManager.Expect100Continue = true;
             ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
             string json = new WebClient().DownloadString(new APIURL().GetPart(part));
             List<PartAdataiModel> customers = JsonConvert.DeserializeObject<List<PartAdataiModel>>(json);
             return View(customers);
         }
    }
}
