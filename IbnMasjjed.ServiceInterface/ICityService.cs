using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IbnMasjjed.DomainView;
using IbnMasjjed.DomainView.Models;

namespace IbnMasjjed.ServiceInterface
{
   public interface ICityService
    {
        Task<ReturnResult<CityLookupView>> CityById(int cityId);
        Task<ReturnResult<CityLookupView[]>> CityAll();
    }
}
