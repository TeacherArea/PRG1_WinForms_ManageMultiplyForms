namespace PRG1_Manage_multiply_forms
{
    partial class Home
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
            lbl_Home = new Label();
            panel_HomeHeader = new Panel();
            panel_HomeBottom = new Panel();
            panel_HomeHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Home.ForeColor = SystemColors.ControlLightLight;
            lbl_Home.Location = new Point(9, 9);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(43, 23);
            lbl_Home.TabIndex = 0;
            lbl_Home.Text = "Hem";
            // 
            // panel_HomeHeader
            // 
            panel_HomeHeader.BackColor = Color.DimGray;
            panel_HomeHeader.Controls.Add(lbl_Home);
            panel_HomeHeader.Dock = DockStyle.Top;
            panel_HomeHeader.Location = new Point(0, 0);
            panel_HomeHeader.Name = "panel_HomeHeader";
            panel_HomeHeader.Size = new Size(800, 43);
            panel_HomeHeader.TabIndex = 1;
            // 
            // panel_HomeBottom
            // 
            panel_HomeBottom.BackColor = Color.WhiteSmoke;
            panel_HomeBottom.Dock = DockStyle.Bottom;
            panel_HomeBottom.Location = new Point(0, 396);
            panel_HomeBottom.Name = "panel_HomeBottom";
            panel_HomeBottom.Size = new Size(800, 54);
            panel_HomeBottom.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_HomeBottom);
            Controls.Add(panel_HomeHeader);
            Name = "Home";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            panel_HomeHeader.ResumeLayout(false);
            panel_HomeHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Home;
        private Panel panel_HomeHeader;
        private Panel panel_HomeBottom;
    }
}