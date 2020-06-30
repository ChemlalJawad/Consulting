using Consulting.Core.Commands;
using Consulting.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consulting.Core.Services
{
    public interface IConsultantService
    {
        IEnumerable<Consultant> GetAll();
        Consultant GetById(int id);

    }
}
