namespace PRG1_Manage_multiply_forms
{
    partial class About
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
            panel_AboutHeader = new Panel();
            lbl_About = new Label();
            panel_AboutBottom = new Panel();
            panel_AboutHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel_AboutHeader
            // 
            panel_AboutHeader.BackColor = Color.DimGray;
            panel_AboutHeader.Controls.Add(lbl_About);
            panel_AboutHeader.Dock = DockStyle.Top;
            panel_AboutHeader.Location = new Point(0, 0);
            panel_AboutHeader.Name = "panel_AboutHeader";
            panel_AboutHeader.Size = new Size(800, 43);
            panel_AboutHeader.TabIndex = 2;
            // 
            // lbl_About
            // 
            lbl_About.AutoSize = true;
            lbl_About.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_About.ForeColor = SystemColors.ControlLightLight;
            lbl_About.Location = new Point(9, 9);
            lbl_About.Name = "lbl_About";
            lbl_About.Size = new Size(64, 23);
            lbl_About.TabIndex = 0;
            lbl_About.Text = "Om oss";
            // 
            // panel_AboutBottom
            // 
            panel_AboutBottom.BackColor = Color.WhiteSmoke;
            panel_AboutBottom.Dock = DockStyle.Bottom;
            panel_AboutBottom.Location = new Point(0, 396);
            panel_AboutBottom.Name = "panel_AboutBottom";
            panel_AboutBottom.Size = new Size(800, 54);
            panel_AboutBottom.TabIndex = 4;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_AboutBottom);
            Controls.Add(panel_AboutHeader);
            Name = "About";
            ShowIcon = false;
            panel_AboutHeader.ResumeLayout(false);
            panel_AboutHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_AboutHeader;
        private Label lbl_About;
        private Panel panel_AboutBottom;
    }
}