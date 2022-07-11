using BusinessObject;
using Microsoft.Extensions.Configuration;

namespace SalesWinApp
{
    internal static class Program
    {
        public static IConfigurationRoot Configuration { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
        public static Member currentUser;
        public static frmMain managerForm;
        public static frmLogin login;
    }
    public class DefaultAccount
    {
        public DefaultAccount()
        {
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public DefaultAccount(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}