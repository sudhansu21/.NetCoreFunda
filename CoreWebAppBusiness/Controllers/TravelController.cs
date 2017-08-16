using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CoreHubXWebType;
using CoreWebAppBusiness.Model;

namespace CoreWebAppBusiness.Controllers
{
    [Produces("application/json")]
    [Route("api/Travel")]
    public class TravelController : Controller
    {
        ITravelBusiness iTravelBusiness;

        public TravelController(ITravelBusiness iTravelBusiness)
        {
            try
            {
                this.iTravelBusiness = iTravelBusiness;
            }
            catch(System.Exception ex)
            {
                throw new System.Exception();
            }
        }


        [HttpGet("GetTravelDetails")]
        public List<TravelVM> GetTravelDetails()
        {
            List<TravelVM> travellst = new List<TravelVM>();
            travellst = iTravelBusiness.GetTravelDetails();

            return travellst;
        }

    }
}