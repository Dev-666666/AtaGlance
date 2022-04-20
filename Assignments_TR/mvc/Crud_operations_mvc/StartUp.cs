using System;
using System.Data.SqlClient;
namespace Crud_operations_mvc
{
    public class StartUp
    {
        public static string? ConnectionString { get; set; }

        public IConfiguration config;
            
 // Add readonly modifier
// Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public StartUp()
//Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
           ConnectionString=config.GetValue<string>("DB:dbstring");
        }
    }
}
