using Megyek_API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace Megyek.Controllers
{
    public class PartController : Controller
    {
        public IActionResult Part()
        {
            return View();
        }
        /* public IActionResult Part(String part)
         {
             ServicePointManager.Expect100Continue = true;
             ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
             string json = new WebClient().DownloadString("https://3afae5be-a069-4cdd-962f-9d8feb338a68.mock.pstmn.io/Megyek/Korabbi");
             List<PartAdataiModel> customers = JsonConvert.DeserializeObject<List<PartAdataiModel>>(json);
             return View(customers);
         }*/
    }
}
