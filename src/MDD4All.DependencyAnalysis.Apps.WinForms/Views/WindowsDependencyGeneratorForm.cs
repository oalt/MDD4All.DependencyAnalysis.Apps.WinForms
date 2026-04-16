using MDD4All.DependencyAnalysis.Analyzers;
using MDD4All.DependencyAnalysis.DataModels;
using Newtonsoft.Json;

namespace MDD4All.DependencyAnalysis.Apps.WinForms
{
    public partial class WindowsDependencyGeneratorForm : Form
    {
        public WindowsDependencyGeneratorForm()
        {
            InitializeComponent();
        }

        private void selectAppFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                appFolderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void selectOutputFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files | *.json";

            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                outputFileTextBox.Text = saveFileDialog.FileName;
            }
        }

        private void startAnalysisButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(appFolderTextBox.Text) &&
                !string.IsNullOrEmpty(outputFileTextBox.Text))
            {
                try
                {
                    FileDependencyAnalyzer fileDependencyAnalyzer = new FileDependencyAnalyzer();
                    List<DataModels.SoftwareComponent> analysisResult = fileDependencyAnalyzer.Analyze(appFolderTextBox.Text);

                    SoftwareApplication softwareApplication = new SoftwareApplication();

                    softwareApplication.SoftwareComponents = analysisResult;

                    string json = JsonConvert.SerializeObject(softwareApplication, Formatting.Indented, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    File.WriteAllText(outputFileTextBox.Text, json);

                    MessageBox.Show("Data file saved successfully.",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("An error has occured, check your settings!",
                                    "Error", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }



            }
        }
    }
}
