using Consulting.Core.Commands;
using Consulting.Core.Models;
using Consulting.Core.Services;
using Consulting.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulting.Infrastructure.Services
{
    public class ConsultantService : IConsultantService
    {
        private readonly ConsultingContext _consultingContext;

        public ConsultantService(ConsultingContext consultingContext)
        {
            _consultingContext = consultingContext;
        }

        public IEnumerable<Consultant> GetAll()
        {
            return _consultingContext.Consultants                
                .ToList();
        }


        public Consultant GetById(int id)
        {
            return _consultingContext.Consultants
               .Include(m => m.ConsultantMissions)
               .FirstOrDefault(c => c.Id == id);
        }
    }
}
