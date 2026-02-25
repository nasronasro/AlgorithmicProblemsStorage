using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using AlgorithmicProblemsStorage.Presentation.Controls.AlgorithmControls;
using Microsoft.Extensions.DependencyInjection;

namespace AlgorithmicProblemsStorage
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _service;
        private readonly IPanelServices panelService;
        public MainForm(IServiceProvider service)
        {
            InitializeComponent();
            _service = service;
            panelService = _service.GetRequiredService<IPanelServices>();
            panelService.Initialize(pnlContent);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        public void LoadDashboard()
        {
            var dashboardView = _service.GetRequiredService<AlgorithmDashboard>();
            panelService.ShowScreen(dashboardView);
        }
        public Panel GetMainPanel()
        {
            return pnlContent;
        }
    }
}
