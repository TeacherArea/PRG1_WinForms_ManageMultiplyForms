namespace PRG1_Manage_multiply_forms
{
    partial class BaseForm
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
            menu_Main = new MenuStrip();
            menyToolStripMenuItem = new ToolStripMenuItem();
            hemToolStripMenuItem = new ToolStripMenuItem();
            produkterToolStripMenuItem = new ToolStripMenuItem();
            omOssToolStripMenuItem = new ToolStripMenuItem();
            kontaktToolStripMenuItem = new ToolStripMenuItem();
            hemToolStripMenuItem1 = new ToolStripMenuItem();
            produkterToolStripMenuItem1 = new ToolStripMenuItem();
            omOssToolStripMenuItem1 = new ToolStripMenuItem();
            kontaktToolStripMenuItem1 = new ToolStripMenuItem();
            menu_Main.SuspendLayout();
            SuspendLayout();
            // 
            // menu_Main
            // 
            menu_Main.Items.AddRange(new ToolStripItem[] { menyToolStripMenuItem, hemToolStripMenuItem1, produkterToolStripMenuItem1, omOssToolStripMenuItem1, kontaktToolStripMenuItem1 });
            menu_Main.Location = new Point(0, 0);
            menu_Main.Name = "menu_Main";
            menu_Main.Size = new Size(800, 24);
            menu_Main.TabIndex = 1;
            menu_Main.Text = "Menu";
            // 
            // menyToolStripMenuItem
            // 
            menyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hemToolStripMenuItem, produkterToolStripMenuItem, omOssToolStripMenuItem, kontaktToolStripMenuItem });
            menyToolStripMenuItem.Name = "menyToolStripMenuItem";
            menyToolStripMenuItem.Size = new Size(105, 20);
            menyToolStripMenuItem.Text = "Dropdownmeny";
            // 
            // hemToolStripMenuItem
            // 
            hemToolStripMenuItem.Name = "hemToolStripMenuItem";
            hemToolStripMenuItem.Size = new Size(126, 22);
            hemToolStripMenuItem.Text = "Hem";
            hemToolStripMenuItem.Click += hemToolStripMenuItem_Click;
            // 
            // produkterToolStripMenuItem
            // 
            produkterToolStripMenuItem.Name = "produkterToolStripMenuItem";
            produkterToolStripMenuItem.Size = new Size(126, 22);
            produkterToolStripMenuItem.Text = "Produkter";
            produkterToolStripMenuItem.Click += produkterToolStripMenuItem_Click;
            // 
            // omOssToolStripMenuItem
            // 
            omOssToolStripMenuItem.Name = "omOssToolStripMenuItem";
            omOssToolStripMenuItem.Size = new Size(126, 22);
            omOssToolStripMenuItem.Text = "Om oss";
            omOssToolStripMenuItem.Click += omOssToolStripMenuItem_Click;
            // 
            // kontaktToolStripMenuItem
            // 
            kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            kontaktToolStripMenuItem.Size = new Size(126, 22);
            kontaktToolStripMenuItem.Text = "Kontakt";
            kontaktToolStripMenuItem.Click += kontaktToolStripMenuItem_Click;
            // 
            // hemToolStripMenuItem1
            // 
            hemToolStripMenuItem1.Name = "hemToolStripMenuItem1";
            hemToolStripMenuItem1.Size = new Size(45, 20);
            hemToolStripMenuItem1.Text = "Hem";
            hemToolStripMenuItem1.Click += hemToolStripMenuItem_Click;
            // 
            // produkterToolStripMenuItem1
            // 
            produkterToolStripMenuItem1.Name = "produkterToolStripMenuItem1";
            produkterToolStripMenuItem1.Size = new Size(71, 20);
            produkterToolStripMenuItem1.Text = "Produkter";
            produkterToolStripMenuItem1.Click += produkterToolStripMenuItem_Click;
            // 
            // omOssToolStripMenuItem1
            // 
            omOssToolStripMenuItem1.Name = "omOssToolStripMenuItem1";
            omOssToolStripMenuItem1.Size = new Size(59, 20);
            omOssToolStripMenuItem1.Text = "Om oss";
            omOssToolStripMenuItem1.Click += omOssToolStripMenuItem_Click;
            // 
            // kontaktToolStripMenuItem1
            // 
            kontaktToolStripMenuItem1.Name = "kontaktToolStripMenuItem1";
            kontaktToolStripMenuItem1.Size = new Size(60, 20);
            kontaktToolStripMenuItem1.Text = "Kontakt";
            kontaktToolStripMenuItem1.Click += kontaktToolStripMenuItem_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menu_Main);
            IsMdiContainer = true;
            MainMenuStrip = menu_Main;
            Name = "BaseForm";
            Text = "Mitt program";
            menu_Main.ResumeLayout(false);
            menu_Main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu_Main;
        private ToolStripMenuItem menyToolStripMenuItem;
        private ToolStripMenuItem hemToolStripMenuItem;
        private ToolStripMenuItem produkterToolStripMenuItem;
        private ToolStripMenuItem omOssToolStripMenuItem;
        private ToolStripMenuItem kontaktToolStripMenuItem;
        private ToolStripMenuItem hemToolStripMenuItem1;
        private ToolStripMenuItem produkterToolStripMenuItem1;
        private ToolStripMenuItem omOssToolStripMenuItem1;
        private ToolStripMenuItem kontaktToolStripMenuItem1;
    }
}