using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AlgorithmicProblemsStorage.Application.Services;
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AlgorithmicProblemsStorage.Presentation.Controls.AlgorithmControls
{
    public partial class AlgorithmDashboard : UserControl
    {
        private readonly IServiceProvider _service;
        private readonly IPanelServices panelService;
        public AlgorithmDashboard(IServiceProvider service)
        {
            InitializeComponent();
            _service = service;
            panelService = _service.GetRequiredService<IPanelServices>();
        }

        private void btnAddAlgo_Click(object sender, EventArgs e)
        {
            var addView = _service.GetRequiredService<AlgorithmAddControl>(); // UserControl
            panelService.ShowScreen(addView);
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            var listView = _service.GetRequiredService<AlgorithmShowControl>(); // UserControl
            panelService.ShowScreen(listView);
        }
    }
}
