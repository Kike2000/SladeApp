﻿using CongresoSlade.Domain.Entities;
using CongresoSlade.Infrastructure.Commons.Bases.Request;
using CongresoSlade.Infrastructure.Commons.Bases.Response;
using CongresoSlade.Infrastructure.Persistences.Context;
using CongresoSlade.Infrastructure.Persistences.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongresoSlade.Infrastructure.Persistences.Repositories
{
    public class RegistroRepository : GenericRepository<Registro>, IRegistroRepository
    {
        public RegistroRepository(CongresoServerDbContext context) : base(context)
        {
        }
        public async Task<BaseEntityResponse<Registro>> ListRegistros(BaseFilterRequest filters)
        {
            var response = new BaseEntityResponse<Registro>();
            var registros = GetEntityQuery(null);

            if (filters.NumFilter is not null && !string.IsNullOrEmpty(filters.TextFilter))
            {
                switch (filters.NumFilter)
                {
                    case 1:
                        //areas = areas.Where(p => p.Nombre == filters.TextFilter);
                        break;
                }
            }
            //if (filters.StateFilter is not null)
            //{
            //    participantes = participantes.Where(x => x.AgendaAbierta.Equals(filters.StateFilter));
            //}

            if (filters.Sort is null) filters.Sort = "Id";
            response.TotalRecords = await registros.CountAsync();
            response.Items = await Ordering(filters, registros, !(bool)filters.Download!).ToListAsync();
            // ?? es llamado null-coalescing operator es usado cuando un valor es nulo
            //response.Items = await Ordering(filters, categories, filters.Download ?? false).ToListAsync();

            return response;
        }
    }
}
