using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using Vision_Pharmacy.Gui.EmployeeGui;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.PurchaseGui;
using Vision_Pharmacy.Gui.UserGui;

namespace Vision_Pharmacy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Startup getStarted = new Startup();
            Application.Run(new WelcomeScreen()); 
        }
    }
}