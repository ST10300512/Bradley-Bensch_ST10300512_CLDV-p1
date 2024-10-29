using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ST10300512_CLDVPOE.Models
{
    public class Order : Controller
    {
        public static string con_string = "Server=tcp:st10300512-poecldv.database.windows.net,1433;Initial Catalog=st10300512server-poecldv;Persist Security Info=False;User ID=bradleybenschst10300512D;Password=Rocky@4ngle;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static SqlConnection con = new SqlConnection(con_string);
        public IActionResult Index()
        {
            return View();
        }
    }
}
