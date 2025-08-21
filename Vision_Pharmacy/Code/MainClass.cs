using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Vision_Pharmacy.Code
{
    public class MainClass
    {
        // Fields
        FormMain _main;
        // Constructore
        public MainClass(FormMain main)
        {
            _main = main;

        }

        // Methods
        public void LoadPage(UserControl Page)
        {
            // Select Old Page to clear it
            var oldPage = _main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                _main.Controls.Remove(oldPage);
                oldPage.Dispose();
            }
            // Add New Page
            Page.Dock = DockStyle.Fill;
            _main.panelContainer.Controls.Add(Page);
        }


    }
}
