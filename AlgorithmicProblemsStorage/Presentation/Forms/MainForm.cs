using AlgorithmicProblemsStorage.Presentation.Forms.AlgorithmForms;

namespace AlgorithmicProblemsStorage
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _service;
        public MainForm(IServiceProvider service)
        {
            InitializeComponent();
            _service = service;
        }

        private void btnAddAlgo_Click(object sender, EventArgs e)
        {
            AddAlgorithmForm addForm = new(_service);
            addForm.ShowDialog();
        }
    }
}
