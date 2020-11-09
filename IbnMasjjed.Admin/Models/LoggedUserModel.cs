using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbnMasjjed.Admin.Models
{
    public class LoggedUserModel
    {
        public readonly IHttpContextAccessor _contextAccessor;

        public LoggedUserModel(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public bool IsAuthenticated
        {
            get
            {
                if (_contextAccessor.HttpContext.User != null && _contextAccessor.HttpContext.User.Identity.IsAuthenticated)
                {
                    return true;
                }
                return false;

            }
        }

        public string Username
        {
            get
            {
                if (IsAuthenticated)
                {
                    return _contextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "Username")?.Value;
                }
                return string.Empty;

            }
        }

        public Guid UserId
        {
            get
            {
                if (IsAuthenticated)
                {
                    var userId = _contextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "UserId")?.Value;
                    return SharedKernal.Common.Guard.GetGuid(userId).Value;
                }
                return Guid.Empty;

            }
        }


        public string FullName
        {
            get
            {
                if (IsAuthenticated)
                {
                    return _contextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "FullName")?.Value;
                }
                return string.Empty;

            }
        }


        

        //public Guid Id
        //{
        //    get
        //    {
        //        if (_contextAccessor.HttpContext.User != null && _contextAccessor.HttpContext.User.Identity.IsAuthenticated)
        //        {
        //            var _id = _contextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "Id")?.Value;
        //            return Moj.Common.Converter.StringToGuid(_id);
        //        }
        //        return Guid.Empty;
        //    }
        //}

    }
}
