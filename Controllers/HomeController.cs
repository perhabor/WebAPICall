using WebAPICall.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiCall.Controllers
{
    public class HomeController : Controller
    {
        HttpClientHandler _httpClientHandler = new HttpClientHandler();
        

        Hub _hub = new Hub();
        List<Hub> hubs = new List<Hub>();

        public HomeController()
        {
            _httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => {return true; };
        }
        public IActionResult SearchHubs(string state)
        {
            var _state = Get(state);
            return View(_state);



        }

        [HttpGet]

        public async Task<List<Hub>> Get(string state)
        {


            if (!string.IsNullOrEmpty(state))
            {

                hubs = hubs.Where(x => x.State == state).ToList();
            }

            hubs = new List<Hub>();
            var url= "https://findahub.herokuapp.com/api/getbystate?state=lagos";
            using (HttpClient client = new HttpClient(_httpClientHandler))
            {
                using(var response = await client.GetAsync(url))
                {
                  string apiResponse = await response.Content.ReadAsStringAsync();
                    hubs = JsonConvert.DeserializeObject<List<Hub>>(apiResponse);
                }
            } ;


            return hubs;
        }
    }
}
