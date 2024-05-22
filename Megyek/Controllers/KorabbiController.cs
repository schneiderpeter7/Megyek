using Megyek.Models.Korabbi;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace Megyek.Controllers
{
    public class KorabbiController : Controller
    {
        public IActionResult KorabbiEredmeny(String ev)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            try
            {
                string json = new WebClient().DownloadString(new APIURL().GetKorabbi(ev));
                List<KorabbiValasztasModel> customers = JsonConvert.DeserializeObject<List<KorabbiValasztasModel>>(json);
                return View(customers);
            } catch (Exception ex)
            {
                return View();
            }
        }


    }
}
