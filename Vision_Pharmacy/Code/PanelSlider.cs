using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Code
{
    public class PanelSlider
    {
        private System.Windows.Forms.Timer timer;
        private Control panel;
        private bool isExpanded;
        private int minSize;
        private int maxSize;
        private int step;
        private bool isHorizontal; // true = Width, false = Height

        public PanelSlider(Control panel, int minSize, int maxSize, int step = 10, bool isHorizontal = true)
        {
            this.panel = panel;
            this.minSize = minSize;
            this.maxSize = maxSize;
            this.step = step;
            this.isHorizontal = isHorizontal;
            this.isExpanded = (isHorizontal ? panel.Width : panel.Height) >= maxSize;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
        }

        public void Toggle()
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isHorizontal)
            {
                if (isExpanded)
                {
                    panel.Width -= step;
                    if (panel.Width <= minSize)
                    {
                        panel.Width = minSize;
                        timer.Stop();
                        isExpanded = false;
                    }
                }
                else
                {
                    panel.Width += step;
                    if (panel.Width >= maxSize)
                    {
                        panel.Width = maxSize;
                        timer.Stop();
                        isExpanded = true;
                    }
                }
            }
            else
            {
                if (isExpanded)
                {
                    panel.Height -= step;
                    if (panel.Height <= minSize)
                    {
                        panel.Height = minSize;
                        timer.Stop();
                        isExpanded = false;
                    }
                }
                else
                {
                    panel.Height += step;
                    if (panel.Height >= maxSize)
                    {
                        panel.Height = maxSize;
                        timer.Stop();
                        isExpanded = true;
                    }
                }
            }
        }


    }
}
