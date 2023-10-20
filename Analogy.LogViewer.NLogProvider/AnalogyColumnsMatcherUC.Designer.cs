using System.Drawing;
using System.Windows.Forms;

namespace Analogy.LogViewer.NLogProvider
{
    partial class AnalogyColumnsMatcherUC
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
            label1 = new Label();
            label2 = new Label();
            nudDate = new NumericUpDown();
            nudLevel = new NumericUpDown();
            nudSource = new NumericUpDown();
            nudText = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            nudProcessName = new NumericUpDown();
            nudLineNumber = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            nudFileName = new NumericUpDown();
            nudMethodName = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            nudProcessId = new NumericUpDown();
            label9 = new Label();
            nudMachineName = new NumericUpDown();
            label10 = new Label();
            nudUserName = new NumericUpDown();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProcessName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLineNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFileName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMethodName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProcessId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMachineName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUserName).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 11;
            label1.Text = "Date Column:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 67);
            label2.Name = "label2";
            label2.Size = new Size(139, 16);
            label2.TabIndex = 12;
            label2.Text = "Text/Message Column:";
            // 
            // nudDate
            // 
            nudDate.Location = new Point(232, 9);
            nudDate.Name = "nudDate";
            nudDate.Size = new Size(150, 23);
            nudDate.TabIndex = 13;
            nudDate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudLevel
            // 
            nudLevel.Location = new Point(232, 38);
            nudLevel.Name = "nudLevel";
            nudLevel.Size = new Size(150, 23);
            nudLevel.TabIndex = 14;
            nudLevel.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // nudSource
            // 
            nudSource.Location = new Point(232, 96);
            nudSource.Name = "nudSource";
            nudSource.Size = new Size(150, 23);
            nudSource.TabIndex = 18;
            nudSource.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudText
            // 
            nudText.Location = new Point(232, 67);
            nudText.Name = "nudText";
            nudText.Size = new Size(150, 23);
            nudText.TabIndex = 17;
            nudText.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(186, 16);
            label3.TabIndex = 16;
            label3.Text = "Module/Process Name Column:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 96);
            label4.Name = "label4";
            label4.Size = new Size(99, 16);
            label4.TabIndex = 15;
            label4.Text = "Source Column:";
            // 
            // nudProcessName
            // 
            nudProcessName.Location = new Point(232, 125);
            nudProcessName.Name = "nudProcessName";
            nudProcessName.Size = new Size(150, 23);
            nudProcessName.TabIndex = 26;
            nudProcessName.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // nudLineNumber
            // 
            nudLineNumber.Location = new Point(232, 301);
            nudLineNumber.Name = "nudLineNumber";
            nudLineNumber.Size = new Size(150, 23);
            nudLineNumber.TabIndex = 25;
            nudLineNumber.Value = new decimal(new int[] { 11, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 154);
            label5.Name = "label5";
            label5.Size = new Size(118, 16);
            label5.TabIndex = 24;
            label5.Text = "Process Id Column:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 308);
            label6.Name = "label6";
            label6.Size = new Size(131, 16);
            label6.TabIndex = 23;
            label6.Text = "Line Number Column:";
            // 
            // nudFileName
            // 
            nudFileName.Location = new Point(232, 243);
            nudFileName.Name = "nudFileName";
            nudFileName.Size = new Size(150, 23);
            nudFileName.TabIndex = 22;
            nudFileName.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // nudMethodName
            // 
            nudMethodName.Location = new Point(232, 272);
            nudMethodName.Name = "nudMethodName";
            nudMethodName.Size = new Size(150, 23);
            nudMethodName.TabIndex = 21;
            nudMethodName.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 250);
            label7.Name = "label7";
            label7.Size = new Size(116, 16);
            label7.TabIndex = 20;
            label7.Text = "File Name Column:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 279);
            label8.Name = "label8";
            label8.Size = new Size(138, 16);
            label8.TabIndex = 19;
            label8.Text = "Method Name Column:";
            // 
            // nudProcessId
            // 
            nudProcessId.Location = new Point(232, 154);
            nudProcessId.Name = "nudProcessId";
            nudProcessId.Size = new Size(150, 23);
            nudProcessId.TabIndex = 28;
            nudProcessId.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 183);
            label9.Name = "label9";
            label9.Size = new Size(143, 16);
            label9.TabIndex = 27;
            label9.Text = "Machine Name Column:";
            // 
            // nudMachineName
            // 
            nudMachineName.Location = new Point(232, 183);
            nudMachineName.Name = "nudMachineName";
            nudMachineName.Size = new Size(150, 23);
            nudMachineName.TabIndex = 30;
            nudMachineName.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 43);
            label10.Name = "label10";
            label10.Size = new Size(112, 16);
            label10.TabIndex = 29;
            label10.Text = "Log Level Column:";
            // 
            // nudUserName
            // 
            nudUserName.Location = new Point(232, 212);
            nudUserName.Name = "nudUserName";
            nudUserName.Size = new Size(150, 23);
            nudUserName.TabIndex = 32;
            nudUserName.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 214);
            label11.Name = "label11";
            label11.Size = new Size(122, 16);
            label11.TabIndex = 31;
            label11.Text = "User Name Column:";
            // 
            // AnalogyColumnsMatcherUC
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nudUserName);
            Controls.Add(label11);
            Controls.Add(nudMachineName);
            Controls.Add(label10);
            Controls.Add(nudProcessId);
            Controls.Add(label9);
            Controls.Add(nudProcessName);
            Controls.Add(nudLineNumber);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(nudFileName);
            Controls.Add(nudMethodName);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(nudSource);
            Controls.Add(nudText);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(nudLevel);
            Controls.Add(nudDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AnalogyColumnsMatcherUC";
            Size = new Size(602, 483);
            ((System.ComponentModel.ISupportInitialize)nudDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudText).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProcessName).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLineNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFileName).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMethodName).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProcessId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMachineName).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUserName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private NumericUpDown nudDate;
        private NumericUpDown nudLevel;
        private NumericUpDown nudSource;
        private NumericUpDown nudText;
        private Label label3;
        private Label label4;
        private NumericUpDown nudProcessName;
        private NumericUpDown nudLineNumber;
        private Label label5;
        private Label label6;
        private NumericUpDown nudFileName;
        private NumericUpDown nudMethodName;
        private Label label7;
        private Label label8;
        private NumericUpDown nudProcessId;
        private Label label9;
        private NumericUpDown nudMachineName;
        private Label label10;
        private NumericUpDown nudUserName;
        private Label label11;
    }
}
