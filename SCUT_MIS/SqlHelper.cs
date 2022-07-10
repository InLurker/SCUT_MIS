using System.Configuration;
namespace SCUT_MIS
{
    public static class SqlHelper {
        public static string CnnVal(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}