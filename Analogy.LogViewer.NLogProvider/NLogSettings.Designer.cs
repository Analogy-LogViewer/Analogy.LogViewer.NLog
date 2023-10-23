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
            txtNLogSeperator = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtNLogExtension = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            _columnsMatcherUc1 = new ColumnsMatcherUC();
            txtbNLogDirectory = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnOpenFolder = new System.Windows.Forms.Button();
            txtDateTimeFormat = new System.Windows.Forms.TextBox();
            lblTimeFormat = new System.Windows.Forms.Label();
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
            // txtNLogSeperator
            // 
            txtNLogSeperator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNLogSeperator.Location = new System.Drawing.Point(230, 8);
            txtNLogSeperator.Name = "txtNLogSeperator";
            txtNLogSeperator.Size = new System.Drawing.Size(466, 23);
            txtNLogSeperator.TabIndex = 7;
            txtNLogSeperator.Text = "|";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 16);
            label1.TabIndex = 6;
            label1.Text = "Seperator character:";
            // 
            // txtNLogExtension
            // 
            txtNLogExtension.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNLogExtension.Location = new System.Drawing.Point(230, 60);
            txtNLogExtension.Name = "txtNLogExtension";
            txtNLogExtension.Size = new System.Drawing.Size(466, 23);
            txtNLogExtension.TabIndex = 9;
            txtNLogExtension.Text = "*.Nlog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 16);
            label2.TabIndex = 8;
            label2.Text = "NLog File Extension:";
            // 
            // _columnsMatcherUc1
            // 
            _columnsMatcherUc1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _columnsMatcherUc1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _columnsMatcherUc1.Location = new System.Drawing.Point(0, 120);
            _columnsMatcherUc1.Name = "_columnsMatcherUc1";
            _columnsMatcherUc1.Size = new System.Drawing.Size(709, 414);
            _columnsMatcherUc1.TabIndex = 0;
            // 
            // txtbNLogDirectory
            // 
            txtbNLogDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbNLogDirectory.Location = new System.Drawing.Point(230, 33);
            txtbNLogDirectory.Name = "txtbNLogDirectory";
            txtbNLogDirectory.Size = new System.Drawing.Size(431, 23);
            txtbNLogDirectory.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 16);
            label3.TabIndex = 11;
            label3.Text = "Logs Location";
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOpenFolder.Location = new System.Drawing.Point(667, 31);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new System.Drawing.Size(28, 25);
            btnOpenFolder.TabIndex = 13;
            btnOpenFolder.Text = "..";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // txtDateTimeFormat
            // 
            txtDateTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDateTimeFormat.Location = new System.Drawing.Point(230, 91);
            txtDateTimeFormat.Name = "txtDateTimeFormat";
            txtDateTimeFormat.Size = new System.Drawing.Size(466, 23);
            txtDateTimeFormat.TabIndex = 15;
            txtDateTimeFormat.Text = "MMM dd, yyyy HH:mm:ss.fff";
            // 
            // lblTimeFormat
            // 
            lblTimeFormat.AutoSize = true;
            lblTimeFormat.Location = new System.Drawing.Point(4, 94);
            lblTimeFormat.Name = "lblTimeFormat";
            lblTimeFormat.Size = new System.Drawing.Size(174, 16);
            lblTimeFormat.TabIndex = 14;
            lblTimeFormat.Text = "Date Time format (Optional):";
            // 
            // NLogSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txtDateTimeFormat);
            Controls.Add(lblTimeFormat);
            Controls.Add(btnOpenFolder);
            Controls.Add(txtbNLogDirectory);
            Controls.Add(label3);
            Controls.Add(txtNLogExtension);
            Controls.Add(label2);
            Controls.Add(txtNLogSeperator);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(_columnsMatcherUc1);
            Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "NLogSettings";
            Size = new System.Drawing.Size(709, 603);
            Load += NLogSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColumnsMatcherUC _columnsMatcherUc1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNLogSeperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNLogExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNLogDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtDateTimeFormat;
        private System.Windows.Forms.Label lblTimeFormat;
    }
}
