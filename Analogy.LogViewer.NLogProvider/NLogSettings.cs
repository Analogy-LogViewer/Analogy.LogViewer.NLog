using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Newtonsoft.Json;

namespace Analogy.LogViewer.NLogProvider
{
    public partial class NLogSettings : UserControl
    {
        private UserSettingsManager Settings => UserSettingsManager.UserSettings;
        public NLogSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveMapping();
        }
        private void SaveMapping()
        {
            Settings.LogParserSettings.Configure("", txtNLogSeperator.Text,
                new List<string> { txtNLogExtension.Text }, _columnsMatcherUc1.Mapping);
            Settings.LogParserSettings.Directory = txtbNLogDirectory.Text;
            Settings.LogParserSettings.DateTimeFormat = txtDateTimeFormat.Text;
            Settings.LogParserSettings.IsConfigured = true;
            Settings.Save();
        }

        private void btnExportSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Analogy NLog Settings (*.nlogsettings)|*.nlogsettings";
            saveFileDialog.Title = @"Export NLog settings";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                SaveMapping();
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(Settings));
                    MessageBox.Show("File Saved", @"Export settings", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Export: " + ex.Message, @"Error Saving file", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void LoadNLogSettings(LogParserSettings logParserSettings)
        {
            if (logParserSettings.IsConfigured)
            {
                txtNLogSeperator.Text = logParserSettings.Splitter;
                txtNLogExtension.Text = string.Join(";", logParserSettings.SupportedFilesExtensions);
                txtbNLogDirectory.Text = logParserSettings.Directory;
                txtDateTimeFormat.Text = logParserSettings.DateTimeFormat;
                _columnsMatcherUc1.LoadMapping(logParserSettings);
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtbNLogDirectory.Text = fbd.SelectedPath;

                }
            }
        }

        private void NLogSettings_Load(object sender, EventArgs e)
        {
            LoadNLogSettings(UserSettingsManager.UserSettings.LogParserSettings);
        }
    }
}
