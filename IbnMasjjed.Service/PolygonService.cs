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
    public class PolygonService : BaseService,IPolygonService
    {
        public PolygonService(IMapper mapper, ILogger<PolygonService> logger, DataContext dataContext)
    : base(mapper, logger, dataContext)
        {

        }

        public async Task<ReturnResult<CityPolygonView[]>> GetPloygonByCityId(int cityId)
        {
            var result = new ReturnResult<CityPolygonView[]>();

            try
            {
                var cityPolygonList = await db.CityPolygon
                    .Where(p => p.CityId == cityId)
                        .Include(p => p.CityPolygonPoints)
                        .ToArrayAsync();

                result.Data = _mapper.Map<CityPolygonView[]>( cityPolygonList);
                result.HttpStatusCode = System.Net.HttpStatusCode.OK;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                result.Errors.Add(ex.Message);
                result.HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;
            }
            return result;
        }


        public async Task<ReturnResult<int>> Create(CityPolygonView polygon)
        {
            var result = new ReturnResult<int>();

            try
            {
                //TODO : add validation

             var cityPolygon =   _mapper.Map<CityPolygon>(polygon);
                db.CityPolygon.Add(cityPolygon);
                await db.SaveChangesAsync();

                result.Data = cityPolygon.Id;
                result.HttpStatusCode = System.Net.HttpStatusCode.OK;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                result.Errors.Add(ex.Message);
                result.HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;
            }
            return result;
        }

        public async Task<ReturnResult<bool>> DeletePolygon(int Id)
        {
            var result = new ReturnResult<bool>();

            try
            {
                var polygon = await db.CityPolygon.Where(p => p.Id == Id).FirstOrDefaultAsync();
                polygon.IsDeleted = true;
                polygon.UpdateDate = DateTime.Now;

                await db.SaveChangesAsync();

                result.Data = true;
                result.HttpStatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                result.Errors.Add(ex.Message);
                result.Data = false;
                result.HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;
            }
            return result;
        }


    }
}
