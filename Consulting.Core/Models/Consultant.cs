using System;
using System.Collections.Generic;
using System.Text;

namespace Consulting.Core.Models
{
    public class Consultant
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Experience { get; set; }
        public ICollection<ConsultantMission> ConsultantMissions { get; set; }

    }
}
