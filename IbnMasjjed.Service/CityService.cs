using AutoMapper;
using IbnMasjjed.Context;
using IbnMasjjed.Domain;
using IbnMasjjed.DomainView;
using IbnMasjjed.DomainView.Models;
using IbnMasjjed.ServiceInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace IbnMasjjed.Service
{
    public class CityService: BaseService,ICityService
    {

        public CityService(IMapper mapper, ILogger<CityService> logger, DataContext dataContext) 
            : base(mapper, logger, dataContext)
        {

        }

        public async Task<ReturnResult<CityLookupView>> CityById(int cityId)
        {
            var result = new ReturnResult<CityLookupView>() { HttpStatusCode = System.Net.HttpStatusCode.NotFound };

            try
            {
              var _city= await  db.CityLookup.Where(p => p.Id == cityId)
                    .Include(p => p.Region)
                    .FirstOrDefaultAsync();

                if (_city == null)
                    return result;

                result.HttpStatusCode = System.Net.HttpStatusCode.OK;
                result.Data = _mapper.Map<CityLookupView>(_city);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                result.Errors.Add(ex.Message);
                result.HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;
            }

            return result;
        }

        public async Task<ReturnResult<CityLookupView[]>> CityAll()
        {
            var result = new ReturnResult<CityLookupView[]>() { HttpStatusCode = System.Net.HttpStatusCode.NotFound };

            try
            {
                var _cityList = await db.CityLookup
                      .Include(p => p.Region)
                      .ToArrayAsync();

                result.HttpStatusCode = System.Net.HttpStatusCode.OK;
                result.Data = _mapper.Map<CityLookupView[]>(_cityList);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                result.Errors.Add(ex.Message);
                result.HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;
            }

            return result;
        }


    }
}
