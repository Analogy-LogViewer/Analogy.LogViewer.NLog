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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalogyColumnsMatcherUC));
            spltColumns = new SplitContainer();
            lstBAnalogyColumns = new ListBox();
            labelControl9 = new Label();
            splitContainerButtons = new SplitContainer();
            sBtnMoveUp = new Button();
            BtnMoveDown = new Button();
            lstBoxItems = new ListBox();
            labelControl10 = new Label();
            ((System.ComponentModel.ISupportInitialize)spltColumns).BeginInit();
            spltColumns.Panel1.SuspendLayout();
            spltColumns.Panel2.SuspendLayout();
            spltColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerButtons).BeginInit();
            splitContainerButtons.Panel1.SuspendLayout();
            splitContainerButtons.Panel2.SuspendLayout();
            splitContainerButtons.SuspendLayout();
            SuspendLayout();
            // 
            // spltColumns
            // 
            spltColumns.Dock = DockStyle.Fill;
            spltColumns.Location = new Point(0, 0);
            spltColumns.Name = "spltColumns";
            // 
            // spltColumns.Panel1
            // 
            spltColumns.Panel1.Controls.Add(lstBAnalogyColumns);
            spltColumns.Panel1.Controls.Add(labelControl9);
            spltColumns.Panel1.Controls.Add(splitContainerButtons);
            spltColumns.Panel1.Text = "Panel1";
            // 
            // spltColumns.Panel2
            // 
            spltColumns.Panel2.Controls.Add(lstBoxItems);
            spltColumns.Panel2.Controls.Add(labelControl10);
            spltColumns.Panel2.Text = "Panel2";
            spltColumns.Size = new Size(602, 483);
            spltColumns.SplitterDistance = 167;
            spltColumns.TabIndex = 10;
            // 
            // lstBAnalogyColumns
            // 
            lstBAnalogyColumns.Dock = DockStyle.Fill;
            lstBAnalogyColumns.ItemHeight = 16;
            lstBAnalogyColumns.Items.AddRange(new object[] { "Date", "Text", "Source", "Module", "MethodName", "FileName", "User", "LineNumber", "ProcessId", "ThreadId", "MachineName", "Level", "Class", "Id", "__ignore__", "__ignore__", "__ignore__", "__ignore__", "__ignore__", "__ignore__", "__ignore__" });
            lstBAnalogyColumns.Location = new Point(47, 16);
            lstBAnalogyColumns.Name = "lstBAnalogyColumns";
            lstBAnalogyColumns.Size = new Size(120, 467);
            lstBAnalogyColumns.TabIndex = 0;
            lstBAnalogyColumns.SelectedIndexChanged += lstBAnalogyColumns_SelectedIndexChanged;
            // 
            // labelControl9
            // 
            labelControl9.Dock = DockStyle.Top;
            labelControl9.Location = new Point(47, 0);
            labelControl9.Margin = new Padding(3, 2, 3, 2);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(120, 16);
            labelControl9.TabIndex = 7;
            labelControl9.Text = "Log message Columns";
            // 
            // splitContainerButtons
            // 
            splitContainerButtons.Dock = DockStyle.Left;
            splitContainerButtons.Location = new Point(0, 0);
            splitContainerButtons.Name = "splitContainerButtons";
            splitContainerButtons.Orientation = Orientation.Horizontal;
            // 
            // splitContainerButtons.Panel1
            // 
            splitContainerButtons.Panel1.Controls.Add(sBtnMoveUp);
            splitContainerButtons.Panel1.Text = "Panel1";
            // 
            // splitContainerButtons.Panel2
            // 
            splitContainerButtons.Panel2.Controls.Add(BtnMoveDown);
            splitContainerButtons.Panel2.Text = "Panel2";
            splitContainerButtons.Size = new Size(47, 483);
            splitContainerButtons.SplitterDistance = 238;
            splitContainerButtons.TabIndex = 1;
            // 
            // sBtnMoveUp
            // 
            sBtnMoveUp.Dock = DockStyle.Fill;
            sBtnMoveUp.Image = (Image)resources.GetObject("sBtnMoveUp.Image");
            sBtnMoveUp.ImageAlign = ContentAlignment.TopCenter;
            sBtnMoveUp.Location = new Point(0, 0);
            sBtnMoveUp.Margin = new Padding(3, 2, 3, 2);
            sBtnMoveUp.Name = "sBtnMoveUp";
            sBtnMoveUp.Size = new Size(47, 238);
            sBtnMoveUp.TabIndex = 2;
            sBtnMoveUp.Text = "Up";
            sBtnMoveUp.Click += BtnMoveUp_Click;
            // 
            // BtnMoveDown
            // 
            BtnMoveDown.Dock = DockStyle.Fill;
            BtnMoveDown.Image = (Image)resources.GetObject("BtnMoveDown.Image");
            BtnMoveDown.ImageAlign = ContentAlignment.BottomCenter;
            BtnMoveDown.Location = new Point(0, 0);
            BtnMoveDown.Margin = new Padding(3, 2, 3, 2);
            BtnMoveDown.Name = "BtnMoveDown";
            BtnMoveDown.Size = new Size(47, 241);
            BtnMoveDown.TabIndex = 3;
            BtnMoveDown.Text = "Down";
            BtnMoveDown.Click += BtnMoveDown_Click;
            // 
            // lstBoxItems
            // 
            lstBoxItems.Dock = DockStyle.Fill;
            lstBoxItems.ItemHeight = 16;
            lstBoxItems.Location = new Point(0, 16);
            lstBoxItems.Name = "lstBoxItems";
            lstBoxItems.Size = new Size(431, 467);
            lstBoxItems.TabIndex = 2;
            // 
            // labelControl10
            // 
            labelControl10.Dock = DockStyle.Top;
            labelControl10.Location = new Point(0, 0);
            labelControl10.Margin = new Padding(3, 2, 3, 2);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(431, 16);
            labelControl10.TabIndex = 8;
            labelControl10.Text = "Parsed columns.";
            // 
            // AnalogyColumnsMatcherUC
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(spltColumns);
            Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AnalogyColumnsMatcherUC";
            Size = new Size(602, 483);
            spltColumns.Panel1.ResumeLayout(false);
            spltColumns.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spltColumns).EndInit();
            spltColumns.ResumeLayout(false);
            splitContainerButtons.Panel1.ResumeLayout(false);
            splitContainerButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerButtons).EndInit();
            splitContainerButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spltColumns;
        private ListBox lstBAnalogyColumns;
        private Label labelControl9;
        private SplitContainer splitContainerButtons;
        private Button sBtnMoveUp;
        private Button BtnMoveDown;
        private ListBox lstBoxItems;
        private Label labelControl10;
    }
}
