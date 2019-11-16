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
            this.analogyColumnsMatcherUC1 = new Analogy.LogViewer.NLogProvider.AnalogyColumnsMatcherUC();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExportSettings = new System.Windows.Forms.Button();
            this.lblLayout = new System.Windows.Forms.Label();
            this.btnLoadLayout = new System.Windows.Forms.Button();
            this.txtNLogLayout = new System.Windows.Forms.TextBox();
            this.txtNLogSeperator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNLogExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // analogyColumnsMatcherUC1
            // 
            this.analogyColumnsMatcherUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analogyColumnsMatcherUC1.Location = new System.Drawing.Point(0, 94);
            this.analogyColumnsMatcherUC1.Name = "analogyColumnsMatcherUC1";
            this.analogyColumnsMatcherUC1.Size = new System.Drawing.Size(709, 352);
            this.analogyColumnsMatcherUC1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(592, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExportSettings
            // 
            this.btnExportSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportSettings.Location = new System.Drawing.Point(473, 452);
            this.btnExportSettings.Name = "btnExportSettings";
            this.btnExportSettings.Size = new System.Drawing.Size(114, 51);
            this.btnExportSettings.TabIndex = 2;
            this.btnExportSettings.Text = "Export Settings";
            this.btnExportSettings.UseVisualStyleBackColor = true;
            this.btnExportSettings.Click += new System.EventHandler(this.btnExportSettings_Click);
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Location = new System.Drawing.Point(3, 12);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(56, 17);
            this.lblLayout.TabIndex = 3;
            this.lblLayout.Text = "Layout:";
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadLayout.Location = new System.Drawing.Point(592, 9);
            this.btnLoadLayout.Name = "btnLoadLayout";
            this.btnLoadLayout.Size = new System.Drawing.Size(114, 25);
            this.btnLoadLayout.TabIndex = 4;
            this.btnLoadLayout.Text = "Load layout";
            this.btnLoadLayout.UseVisualStyleBackColor = true;
            this.btnLoadLayout.Click += new System.EventHandler(this.btnLoadLayout_Click);
            // 
            // txtNLogLayout
            // 
            this.txtNLogLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNLogLayout.Location = new System.Drawing.Point(172, 10);
            this.txtNLogLayout.Name = "txtNLogLayout";
            this.txtNLogLayout.Size = new System.Drawing.Size(416, 23);
            this.txtNLogLayout.TabIndex = 5;
            // 
            // txtNLogSeperator
            // 
            this.txtNLogSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNLogSeperator.Location = new System.Drawing.Point(172, 38);
            this.txtNLogSeperator.Name = "txtNLogSeperator";
            this.txtNLogSeperator.Size = new System.Drawing.Size(416, 23);
            this.txtNLogSeperator.TabIndex = 7;
            this.txtNLogSeperator.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seperator character:";
            // 
            // txtNLogExtension
            // 
            this.txtNLogExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNLogExtension.Location = new System.Drawing.Point(172, 66);
            this.txtNLogExtension.Name = "txtNLogExtension";
            this.txtNLogExtension.Size = new System.Drawing.Size(416, 23);
            this.txtNLogExtension.TabIndex = 9;
            this.txtNLogExtension.Text = "*.Nlog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "NLog File Extension:";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(592, 36);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(114, 25);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Import settings";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // NLogSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtNLogExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNLogSeperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNLogLayout);
            this.Controls.Add(this.btnLoadLayout);
            this.Controls.Add(this.lblLayout);
            this.Controls.Add(this.btnExportSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.analogyColumnsMatcherUC1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NLogSettings";
            this.Size = new System.Drawing.Size(709, 506);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
