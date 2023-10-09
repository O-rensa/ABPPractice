using Employee.Debugging;

namespace Employee
{
    public class EmployeeConsts
    {
        public const string LocalizationSourceName = "Employee";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e518fe871f124603bc4c80d476332522";
    }
}
