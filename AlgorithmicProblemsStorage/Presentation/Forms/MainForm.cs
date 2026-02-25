using AlgorithmicProblemsStorage.Application.Services;
using AlgorithmicProblemsStorage.Presentation.Controls;
using AlgorithmicProblemsStorage.Presentation.Controls.AlgorithmControls;
using Microsoft.Extensions.DependencyInjection;

namespace AlgorithmicProblemsStorage
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _service;
        private readonly PanelSwitchServices panelService;
        public MainForm(IServiceProvider service)
        {
            InitializeComponent();
            _service = service;
            panelService = _service.GetRequiredService<PanelSwitchServices>();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            var dashboardView = _service.GetRequiredService<AlgorithmDashboard>();
            dashboardView.pnlContent = pnlContent;
            panelService.ShowScreen(dashboardView, pnlContent);
        }
    }
}
