namespace Analogy.LogViewer.NLogProvider
{
    partial class NLogSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new System.Windows.Forms.Button();
            btnExportSettings = new System.Windows.Forms.Button();
            lblLayout = new System.Windows.Forms.Label();
            btnLoadLayout = new System.Windows.Forms.Button();
            txtNLogLayout = new System.Windows.Forms.TextBox();
            txtNLogSeperator = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtNLogExtension = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnImport = new System.Windows.Forms.Button();
            analogyColumnsMatcherUC1 = new AnalogyColumnsMatcherUC();
            txtbNLogDirectory = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnOpenFolder = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Location = new System.Drawing.Point(592, 560);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(114, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Settings";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExportSettings
            // 
            btnExportSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnExportSettings.Location = new System.Drawing.Point(473, 560);
            btnExportSettings.Name = "btnExportSettings";
            btnExportSettings.Size = new System.Drawing.Size(114, 40);
            btnExportSettings.TabIndex = 2;
            btnExportSettings.Text = "Export Settings";
            btnExportSettings.UseVisualStyleBackColor = true;
            btnExportSettings.Click += btnExportSettings_Click;
            // 
            // lblLayout
            // 
            lblLayout.AutoSize = true;
            lblLayout.Location = new System.Drawing.Point(3, 12);
            lblLayout.Name = "lblLayout";
            lblLayout.Size = new System.Drawing.Size(49, 16);
            lblLayout.TabIndex = 3;
            lblLayout.Text = "Layout:";
            // 
            // btnLoadLayout
            // 
            btnLoadLayout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLoadLayout.Location = new System.Drawing.Point(592, 9);
            btnLoadLayout.Name = "btnLoadLayout";
            btnLoadLayout.Size = new System.Drawing.Size(114, 25);
            btnLoadLayout.TabIndex = 4;
            btnLoadLayout.Text = "Load layout";
            btnLoadLayout.UseVisualStyleBackColor = true;
            btnLoadLayout.Click += btnLoadLayout_Click;
            // 
            // txtNLogLayout
            // 
            txtNLogLayout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNLogLayout.Location = new System.Drawing.Point(172, 10);
            txtNLogLayout.Name = "txtNLogLayout";
            txtNLogLayout.Size = new System.Drawing.Size(416, 23);
            txtNLogLayout.TabIndex = 5;
            // 
            // txtNLogSeperator
            // 
            txtNLogSeperator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNLogSeperator.Location = new System.Drawing.Point(172, 38);
            txtNLogSeperator.Name = "txtNLogSeperator";
            txtNLogSeperator.Size = new System.Drawing.Size(416, 23);
            txtNLogSeperator.TabIndex = 7;
            txtNLogSeperator.Text = "|";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 16);
            label1.TabIndex = 6;
            label1.Text = "Seperator character:";
            // 
            // txtNLogExtension
            // 
            txtNLogExtension.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNLogExtension.Location = new System.Drawing.Point(172, 90);
            txtNLogExtension.Name = "txtNLogExtension";
            txtNLogExtension.Size = new System.Drawing.Size(416, 23);
            txtNLogExtension.TabIndex = 9;
            txtNLogExtension.Text = "*.Nlog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 16);
            label2.TabIndex = 8;
            label2.Text = "NLog File Extension:";
            // 
            // btnImport
            // 
            btnImport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnImport.Location = new System.Drawing.Point(592, 36);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(114, 25);
            btnImport.TabIndex = 10;
            btnImport.Text = "Import settings";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // analogyColumnsMatcherUC1
            // 
            analogyColumnsMatcherUC1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            analogyColumnsMatcherUC1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            analogyColumnsMatcherUC1.Location = new System.Drawing.Point(0, 120);
            analogyColumnsMatcherUC1.Name = "analogyColumnsMatcherUC1";
            analogyColumnsMatcherUC1.Size = new System.Drawing.Size(709, 443);
            analogyColumnsMatcherUC1.TabIndex = 0;
            // 
            // txtbNLogDirectory
            // 
            txtbNLogDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbNLogDirectory.Location = new System.Drawing.Point(172, 63);
            txtbNLogDirectory.Name = "txtbNLogDirectory";
            txtbNLogDirectory.Size = new System.Drawing.Size(381, 23);
            txtbNLogDirectory.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 65);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 16);
            label3.TabIndex = 11;
            label3.Text = "Logs Location";
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOpenFolder.Location = new System.Drawing.Point(559, 61);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new System.Drawing.Size(28, 25);
            btnOpenFolder.TabIndex = 13;
            btnOpenFolder.Text = "..";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // NLogSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnOpenFolder);
            Controls.Add(txtbNLogDirectory);
            Controls.Add(label3);
            Controls.Add(btnImport);
            Controls.Add(txtNLogExtension);
            Controls.Add(label2);
            Controls.Add(txtNLogSeperator);
            Controls.Add(label1);
            Controls.Add(txtNLogLayout);
            Controls.Add(btnLoadLayout);
            Controls.Add(lblLayout);
            Controls.Add(btnExportSettings);
            Controls.Add(btnSave);
            Controls.Add(analogyColumnsMatcherUC1);
            Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "NLogSettings";
            Size = new System.Drawing.Size(709, 603);
            Load += NLogSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AnalogyColumnsMatcherUC analogyColumnsMatcherUC1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.Button btnLoadLayout;
        private System.Windows.Forms.TextBox txtNLogLayout;
        private System.Windows.Forms.TextBox txtNLogSeperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNLogExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtbNLogDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFolder;
    }
}
