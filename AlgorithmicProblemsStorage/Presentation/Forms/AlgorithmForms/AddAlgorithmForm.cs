using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using AlgorithmicProblemsStorage.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace AlgorithmicProblemsStorage.Presentation.Forms.AlgorithmForms
{
    public partial class AddAlgorithmForm : Form
    {
        private readonly IAlgorithmServices algoServices;
        private readonly IDifficultyServices difficultyServices;
        private readonly IPlatformeServices platformeServices;
        public AddAlgorithmForm(IServiceProvider service)
        {
            InitializeComponent();
            algoServices = service.GetRequiredService<IAlgorithmServices>();
            difficultyServices = service.GetRequiredService<IDifficultyServices>();
            platformeServices = service.GetRequiredService<IPlatformeServices>();
            FillDifficultyCb();
            FillPlatformCb();
        }

        private void FillDifficultyCb()
        {
            cbDifficulty.Items.Add("Easy");
            cbDifficulty.Items.Add("Medium");
            cbDifficulty.Items.Add("Hard");
        }

        private void FillPlatformCb()
        {
            cbPlatform.Items.Add("HackerRank");
            cbPlatform.Items.Add("LeetCode");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAlgorithmForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
        public static List<string> ParseTags(string input)
        {
            return input
                .Split(new[] { ' ', '\r', '\n', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim().ToLowerInvariant())
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Distinct()
                .ToList();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            var link = txtLink.Text.Trim();
            var difficultyName = cbDifficulty.Text?.Trim();
            var platformName = cbPlatform.Text?.Trim();
            var code = txtCode.GetText();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Title is required.");
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(difficultyName) || string.IsNullOrWhiteSpace(platformName))
            {
                MessageBox.Show("Please select Difficulty and Platform.");
                return;
            }

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Code is required.");
                txtCode.Focus();
                return;
            }

            var tags = ParseTags(txtTags.Text)
                .Select(t => new Tag { Name = t })
                .ToList();

            var difficulty = difficultyServices.GetDifficultyByName(difficultyName);
            if (difficulty is null)
            {
                MessageBox.Show($"Difficulty '{difficultyName}' not found.");
                return;
            }

            var platform = platformeServices.GetPlatformByName(platformName);
            if (platform is null)
            {
                MessageBox.Show($"Platform '{platformName}' not found.");
                return;
            }

            var algo = new Algorithm
            {
                Title = title,
                CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), // string
                Code = code,
                Tags = tags,
                Link = link,
                DifficultyId = difficulty.Id,
                PlatformId = platform.Id
            };

            algoServices.AddAlgorithm(algo);

            MessageBox.Show("Algorithm saved successfully.");
        }
    }
}
