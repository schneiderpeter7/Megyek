using Megyek.Models.Korabbi;
using Megyek.Models.Kovetkezo;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace Megyek.Controllers
{
    public class KovetkezoController : Controller
    {
        public IActionResult KovetkezoNyero(String megye)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            string json = new WebClient().DownloadString(new APIURL().GetKovetkezo(megye));
            List<KiFogNyerniModel> customers = JsonConvert.DeserializeObject<List<KiFogNyerniModel>>(json);
            return View(customers);
        }

    }
}
