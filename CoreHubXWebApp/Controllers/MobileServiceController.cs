using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreHubXWebType;
using CoreHubXWebApp.Model.Interface;

namespace CoreHubXWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/MobileService")]
    public class MobileServiceController : Controller
    {
        IMobileBusiness iMobileBusiness;
        
        [HttpGet("GetTravelDetails")]
        public List<TravelVM> GetTravelDetails()
        {
            List<TravelVM> travellst = new List<TravelVM>();
            travellst = iMobileBusiness.GetTravelDetails();

            return travellst;
        }
    }
}