using Microsoft.AspNetCore.Authorization;

namespace jwt_token
{
    public class RoleRequirementHandler : AuthorizationHandler<RoleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RoleRequirement requirement)
        {
            if(!context.User.HasClaim(claim=>claim.Type=="roletype"))
            {
                return Task.CompletedTask;
            }
            if(context.User.FindFirst(c=>c.Type=="roletype").Value==requirement.RoleType)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
