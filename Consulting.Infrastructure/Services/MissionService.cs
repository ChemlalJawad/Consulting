using Consulting.Core.Models;
using Consulting.Core.Services;
using Consulting.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consulting.Infrastructure.Services
{
    public class MissionService : IMissionService
    {
        private readonly ConsultingContext _consultingContext;

        public MissionService(ConsultingContext consultingContext)
        {
            _consultingContext = consultingContext;
        }

        public Task<Mission> GetById(int id)
        {
            return _consultingContext.Missions
                .Include(m => m.ConsultantMissions)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
