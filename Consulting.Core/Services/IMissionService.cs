using Consulting.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consulting.Core.Services
{
    public interface IMissionService
    {    
        Task<Mission> GetById(int id);
    }
}
