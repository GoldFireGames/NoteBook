
namespace Notatnik
{
    partial class FormEdytor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RichTextBoxEdytor = new System.Windows.Forms.RichTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.konfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.konfigToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kkkjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBoxEdytor
            // 
            this.RichTextBoxEdytor.ContextMenuStrip = this.contextMenuStrip1;
            this.RichTextBoxEdytor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxEdytor.Location = new System.Drawing.Point(0, 24);
            this.RichTextBoxEdytor.Name = "RichTextBoxEdytor";
            this.RichTextBoxEdytor.Size = new System.Drawing.Size(859, 410);
            this.RichTextBoxEdytor.TabIndex = 0;
            this.RichTextBoxEdytor.Text = "";
            this.RichTextBoxEdytor.TextChanged += new System.EventHandler(this.RichTextBoxEdytor_TextChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.konfiguratorToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(859, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator2,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem2.Text = "Nowy";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.NowylStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem3.Text = "Otwórz";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.OtworzStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem4.Text = "Zapisz";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ZapiszStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem5.Text = "Zapisz jako";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ZapiszJakoStripMenuItem5_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // konfiguratorToolStripMenuItem
            // 
            this.konfiguratorToolStripMenuItem.Name = "konfiguratorToolStripMenuItem";
            this.konfiguratorToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.konfiguratorToolStripMenuItem.Text = "Konfigurator";
            this.konfiguratorToolStripMenuItem.Click += new System.EventHandler(this.konfiguratorToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfigToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // konfigToolStripMenuItem
            // 
            this.konfigToolStripMenuItem.Name = "konfigToolStripMenuItem";
            this.konfigToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.konfigToolStripMenuItem.Text = "konfig";
            this.konfigToolStripMenuItem.Click += new System.EventHandler(this.konfiguratorToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfigToolStripMenuItem1,
            this.kkkjToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(109, 48);
            // 
            // konfigToolStripMenuItem1
            // 
            this.konfigToolStripMenuItem1.Name = "konfigToolStripMenuItem1";
            this.konfigToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.konfigToolStripMenuItem1.Text = "konfig";
            this.konfigToolStripMenuItem1.Click += new System.EventHandler(this.konfiguratorToolStripMenuItem_Click);
            // 
            // kkkjToolStripMenuItem
            // 
            this.kkkjToolStripMenuItem.Name = "kkkjToolStripMenuItem";
            this.kkkjToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kkkjToolStripMenuItem.Text = "kkkj";
            // 
            // FormEdytor
            // 
            this.ClientSize = new System.Drawing.Size(859, 434);
            this.Controls.Add(this.RichTextBoxEdytor);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FormEdytor";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox edytor;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox RichTextBoxEdytor;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguratorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konfigToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem konfigToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kkkjToolStripMenuItem;
    }
}

