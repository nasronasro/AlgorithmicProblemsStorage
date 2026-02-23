using AlgorithmicProblemsStorage.Presentation.Forms.AlgorithmForms;

namespace AlgorithmicProblemsStorage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddAlgo_Click(object sender, EventArgs e)
        {
            AddAlgorithmForm addForm = new();
            addForm.ShowDialog();
        }
    }
}
