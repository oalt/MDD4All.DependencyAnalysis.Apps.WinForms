namespace MDD4All.DependencyAnalysis.Apps.WinForms
{
    partial class WindowsDependencyGeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            appFolderTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            outputFileTextBox = new TextBox();
            selectAppFolderButton = new Button();
            selectOutputFileButton = new Button();
            startAnalysisButton = new Button();
            SuspendLayout();
            // 
            // appFolderTextBox
            // 
            appFolderTextBox.BackColor = SystemColors.ControlLightLight;
            appFolderTextBox.ForeColor = SystemColors.InfoText;
            appFolderTextBox.Location = new Point(136, 18);
            appFolderTextBox.Name = "appFolderTextBox";
            appFolderTextBox.ReadOnly = true;
            appFolderTextBox.Size = new Size(586, 23);
            appFolderTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Application Folder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Output File";
            // 
            // outputFileTextBox
            // 
            outputFileTextBox.BackColor = SystemColors.ControlLightLight;
            outputFileTextBox.ForeColor = SystemColors.InfoText;
            outputFileTextBox.Location = new Point(136, 79);
            outputFileTextBox.Name = "outputFileTextBox";
            outputFileTextBox.ReadOnly = true;
            outputFileTextBox.Size = new Size(586, 23);
            outputFileTextBox.TabIndex = 3;
            // 
            // selectAppFolderButton
            // 
            selectAppFolderButton.Location = new Point(728, 18);
            selectAppFolderButton.Name = "selectAppFolderButton";
            selectAppFolderButton.Size = new Size(47, 23);
            selectAppFolderButton.TabIndex = 4;
            selectAppFolderButton.Text = "...";
            selectAppFolderButton.UseVisualStyleBackColor = true;
            selectAppFolderButton.Click += selectAppFolderButton_Click;
            // 
            // selectOutputFileButton
            // 
            selectOutputFileButton.Location = new Point(728, 79);
            selectOutputFileButton.Name = "selectOutputFileButton";
            selectOutputFileButton.Size = new Size(47, 23);
            selectOutputFileButton.TabIndex = 5;
            selectOutputFileButton.Text = "...";
            selectOutputFileButton.UseVisualStyleBackColor = true;
            selectOutputFileButton.Click += selectOutputFileButton_Click;
            // 
            // startAnalysisButton
            // 
            startAnalysisButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startAnalysisButton.ForeColor = SystemColors.Highlight;
            startAnalysisButton.Location = new Point(13, 144);
            startAnalysisButton.Name = "startAnalysisButton";
            startAnalysisButton.Size = new Size(763, 58);
            startAnalysisButton.TabIndex = 6;
            startAnalysisButton.Text = "Start Analysis...";
            startAnalysisButton.UseVisualStyleBackColor = true;
            startAnalysisButton.Click += startAnalysisButton_Click;
            // 
            // WindowsDependencyGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(788, 216);
            Controls.Add(startAnalysisButton);
            Controls.Add(selectOutputFileButton);
            Controls.Add(selectAppFolderButton);
            Controls.Add(outputFileTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(appFolderTextBox);
            MaximizeBox = false;
            Name = "WindowsDependencyGeneratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Dependency Generator by MDD4All.de, Dr. Oliver Alt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox appFolderTextBox;
        private Label label1;
        private Label label2;
        private TextBox outputFileTextBox;
        private Button selectAppFolderButton;
        private Button selectOutputFileButton;
        private Button startAnalysisButton;
    }
}
