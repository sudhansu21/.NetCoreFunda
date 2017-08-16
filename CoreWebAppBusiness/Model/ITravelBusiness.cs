using CoreHubXWebType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAppBusiness.Model
{
    public interface ITravelBusiness
    {
        List<TravelVM> GetTravelDetails();
    }
}
