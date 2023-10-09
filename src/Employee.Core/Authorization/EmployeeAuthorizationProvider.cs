using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Employee.Authorization
{
    public class EmployeeAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        { 
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            // Employee Authorizatin Provider
            context.CreatePermission(PermissionNames.Pages_Employees, L("Employees"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, EmployeeConsts.LocalizationSourceName);
        }
    }
}
