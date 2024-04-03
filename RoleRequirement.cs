using Microsoft.AspNetCore.Authorization;

namespace jwt_token
{
    public class RoleRequirement:IAuthorizationRequirement
    {
        public RoleRequirement(string roletype)
        {
            RoleType = roletype;
        }
        public string RoleType { get; set; }
    }
}
