using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using Microsoft.EntityFrameworkCore;
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.EmployeeGui;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.PurchaseGui;
using Vision_Pharmacy.Gui.RepportsGui.RptStock;
using Vision_Pharmacy.Gui.UserGui;

namespace Vision_Pharmacy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ✅ إنشاء قاعدة البيانات وتطبيق الميجريشن تلقائيًا عند تشغيل البرنامج
            using (var context = new DBContext())
            {
                context.Database.Migrate();
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Startup getStarted = new Startup();
            Application.Run(new  WelcomeScreen());
        }
    }

    //internal static class Program
    //{
    //    /// <summary>
    //    ///  The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {

    //        Application.SetHighDpiMode(HighDpiMode.SystemAware);
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        Startup getStarted = new Startup();
    //        Application.Run(new WelcomeScreen()); 
    //    }
    //}
}