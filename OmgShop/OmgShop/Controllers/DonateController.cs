using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OmgShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonateController : ControllerBase
    {
        [HttpPost]        
        public ActionResult PostDonateUrl(string donate)
        {
            return NotFound();
        }
    }
}