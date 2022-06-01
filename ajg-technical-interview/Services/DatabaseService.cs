﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ajg_technical_interview.Models;

namespace ajg_technical_interview.Services
{
    public class DatabaseService : IDatabaseService
    {
        private static readonly IList<SanctionedEntity> SanctionedEntities = new List<SanctionedEntity>
        {
            new SanctionedEntity { Name = "Forbidden Company", Domicile = "Mars", Accepted = false },
            new SanctionedEntity { Name = "Allowed Company", Domicile = "Venus", Accepted = true },
            new SanctionedEntity { Name = "Good Ltd", Domicile = "Saturn", Accepted = true },
            new SanctionedEntity { Name = "Evil Plc", Domicile = "Venus", Accepted = false }
        };

        public async Task<IList<SanctionedEntity>> GetSanctionedEntitiesAsync()
        {
            var entities = SanctionedEntities
                .OrderBy(e => e.Name)
                .ThenBy(e => e.Domicile)
                .ToList();

            return await Task.FromResult(entities);
        }

        public async Task<SanctionedEntity> GetSanctionedEntityByIdAsync(Guid id)
        {
            return await Task.FromResult(SanctionedEntities.First(e => e.Id.Equals(id)));
        }

        public async Task<SanctionedEntity> CreateSanctionedEntityAsync(SanctionedEntity sanctionedEntity)
        {
            SanctionedEntities.Add(sanctionedEntity);
            return await Task.FromResult(sanctionedEntity);
        }

        public async Task<SanctionedEntity> GetSanctionedEntityByNameAndDomicileAsync(SanctionedEntity sanctionedEntity)
        {
            return await Task.FromResult(SanctionedEntities.FirstOrDefault(e => e.Name == sanctionedEntity.Name && e.Domicile == sanctionedEntity.Domicile));
        }

    }
}