using IbnMasjjed.DomainView.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbnMasjjed.ServiceInterface
{
    public interface IPolygonService
    {
        Task<ReturnResult<DomainView.CityPolygonView[]>> GetPloygonByCityId(int cityId);

        Task<ReturnResult<int>> Create(DomainView.CityPolygonView polygon);

        Task<ReturnResult<bool>> DeletePolygon(int Id);
    }
}
