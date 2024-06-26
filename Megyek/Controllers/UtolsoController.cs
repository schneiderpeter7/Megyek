﻿using Megyek.Models.Utolso;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace Megyek.Controllers
{
    public class UtolsoController : Controller
    {
        public IActionResult UtolsoValasztas(string valasztokerulet)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            try
            {
                string json = new WebClient().DownloadString(new APIURL().GetUtolso(valasztokerulet));
                List<UtolsoValasztasModel> customers = JsonConvert.DeserializeObject<List<UtolsoValasztasModel>>(json);
                return View(customers);
            } catch (Exception ex)
            {
                return View();
            }
        }
    }
}
