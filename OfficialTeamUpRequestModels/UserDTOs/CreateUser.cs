using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficialTeamUpRequestModels
{
    public class CreateUserRequest : TeamUpBaseRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
    }

    public class CreateUserResponse : TeamUpBaseResponse
    {
        
    }

}
