using System;
using System.Collections.Generic;
using System.Text;

namespace Consulting.Core.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaximumRate { get; set; }
        public string ExperienceRequired { get; set; }
        public ICollection<ConsultantMission> ConsultantMissions { get; set; }
    }
}
