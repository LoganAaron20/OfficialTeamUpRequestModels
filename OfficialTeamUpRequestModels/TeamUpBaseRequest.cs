using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficialTeamUpRequestModels
{
    public class TeamUpBaseRequest
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class TeamUpBaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
