using AutoMapper;
using IbnMasjjed.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbnMasjjed.Service
{
    public class BaseService
    {
        protected readonly DataContext db;
        protected readonly IMapper _mapper;
        protected readonly ILogger _logger;

        public BaseService(IMapper mapper, ILogger logger, DataContext dataContext)
        {
            _logger = logger;
            _mapper = mapper;
            db = dataContext;

        }

    }
}
