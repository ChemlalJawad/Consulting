using System;
using System.Collections.Generic;
using System.Text;

namespace Consulting.Core.Commands
{
    public class AddMissionCommand
    {
        public int ConsultantId { get; set; }
        public int MissionId { get; set; }
    }
}
