using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AlgorithmicProblemsStorage.Presentation.Controls
{
    public partial class AlgorithmShowControl : UserControl
    {
        private readonly IServiceProvider _services;
        private readonly IAlgorithmServices algoServices;
        public AlgorithmShowControl(IServiceProvider services)
        {
            InitializeComponent();
            _services = services;
            algoServices = _services.GetRequiredService<IAlgorithmServices>();
        }



        private void LoadAlgorithmes()
        {
            lstAlgorithms.Items.Clear();

            foreach (var algo in algoServices.GetAlgorithms())
            {
                var item = new ListViewItem(algo.Title);
                item.SubItems.Add(algo.Difficulty);
                item.SubItems.Add(algo.Platforme);
                item.SubItems.Add(algo.Date);
                item.SubItems.Add(algo.Link);
                lstAlgorithms.LinkColumnIndex = 4;
                lstAlgorithms.Items.Add(item);
            }
        }

        private void AlgorithmShowControl_Load(object sender, EventArgs e)
        {
            LoadAlgorithmes();
        }
    }
}
