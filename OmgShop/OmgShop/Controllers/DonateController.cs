using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace OmgShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonateController : ControllerBase
    {
        [HttpGet]        
        public JObject PostDonateUrl(string? method)
        {
            if(method=="pay")
            {

            }
            return JObject.Parse("{\"result\": {\"message\": \"Запрос успешно обработан\"}}");

        }
    }
}