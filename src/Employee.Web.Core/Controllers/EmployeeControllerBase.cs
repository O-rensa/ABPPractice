using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Employee.Controllers
{
    public abstract class EmployeeControllerBase: AbpController
    {
        protected EmployeeControllerBase()
        {
            LocalizationSourceName = EmployeeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
