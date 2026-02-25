using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicProblemsStorage.Application.Services
{
    public class PanelSwitchServices
    {
        public void ShowScreen(Control screen, Panel pnlContent)
        {
            pnlContent.SuspendLayout();

            // remove old screen
            foreach (Control c in pnlContent.Controls) c.Dispose();
            pnlContent.Controls.Clear();

            // add new screen
            screen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(screen);

            pnlContent.ResumeLayout();
        }
    }
}
