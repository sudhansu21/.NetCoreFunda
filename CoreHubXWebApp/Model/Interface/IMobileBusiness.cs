using CoreHubXWebType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHubXWebApp.Model.Interface
{
    interface IMobileBusiness
    {

        List<TravelVM> GetTravelDetails();
    }
}
