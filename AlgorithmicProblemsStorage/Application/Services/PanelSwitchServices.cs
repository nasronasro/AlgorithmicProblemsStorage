using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AlgorithmicProblemsStorage.Application.Services
{
    public class PanelSwitchServices : IPanelServices
    {
        private Panel? _host;

        public void Initialize(Panel hostPanel)
        {
            _host = hostPanel;
        }

        private readonly IServiceProvider _sp;
        public PanelSwitchServices(IServiceProvider sp)
        {
            _sp = sp;
        }
        public void ShowScreen(Control screen)
        {

            if (_host == null)
                throw new InvalidOperationException("PanelSwitchServices is not initialized. Call Initialize() first.");

            _host.SuspendLayout();

            // remove old screen
            foreach (Control c in _host.Controls) c.Dispose();
            _host.Controls.Clear();

            // add new screen
            screen.Dock = DockStyle.Fill;
            _host.Controls.Add(screen);

            _host.ResumeLayout();
        }
    }
}
