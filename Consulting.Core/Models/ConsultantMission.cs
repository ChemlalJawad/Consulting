using System;
using System.Collections.Generic;
using System.Text;

namespace Consulting.Core.Models
{
    
    public class ConsultantMission
    {
        public int ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public int MissionId { get; set; }
        public Mission Mission { get; set; }
        public bool isActive { get; set; }
    }
}
