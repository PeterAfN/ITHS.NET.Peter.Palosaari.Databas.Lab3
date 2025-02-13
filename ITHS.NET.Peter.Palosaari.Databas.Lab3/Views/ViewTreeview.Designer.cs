﻿
namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    partial class ViewTreeView
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxBookstores = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxBookstores.SuspendLayout();
            this.contextMenuStripTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBookstores
            // 
            this.groupBoxBookstores.Controls.Add(this.treeView);
            this.groupBoxBookstores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBookstores.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBookstores.Name = "groupBoxBookstores";
            this.groupBoxBookstores.Padding = new System.Windows.Forms.Padding(11, 14, 11, 11);
            this.groupBoxBookstores.Size = new System.Drawing.Size(240, 611);
            this.groupBoxBookstores.TabIndex = 1;
            this.groupBoxBookstores.TabStop = false;
            this.groupBoxBookstores.Text = "Stock balance for bookstores [rightclick for options]";
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(11, 30);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(218, 570);
            this.treeView.TabIndex = 0;
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteBook});
            this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(138, 26);
            // 
            // toolStripMenuItemDeleteBook
            // 
            this.toolStripMenuItemDeleteBook.Name = "toolStripMenuItemDeleteBook";
            this.toolStripMenuItemDeleteBook.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemDeleteBook.Text = "Delete Book";
            // 
            // ViewTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxBookstores);
            this.DoubleBuffered = true;
            this.Name = "ViewTreeView";
            this.Size = new System.Drawing.Size(240, 611);
            this.groupBoxBookstores.ResumeLayout(false);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBookstores;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteBook;
    }
}
