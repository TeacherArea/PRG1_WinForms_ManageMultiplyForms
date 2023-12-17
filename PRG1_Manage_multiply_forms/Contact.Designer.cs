namespace PRG1_Manage_multiply_forms
{
    partial class Contact
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
            panel_ContactHeader = new Panel();
            lbl_Contact = new Label();
            panel_ContactBottom = new Panel();
            panel_ContactHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ContactHeader
            // 
            panel_ContactHeader.BackColor = Color.DimGray;
            panel_ContactHeader.Controls.Add(lbl_Contact);
            panel_ContactHeader.Dock = DockStyle.Top;
            panel_ContactHeader.Location = new Point(0, 0);
            panel_ContactHeader.Name = "panel_ContactHeader";
            panel_ContactHeader.Size = new Size(800, 43);
            panel_ContactHeader.TabIndex = 2;
            // 
            // lbl_Contact
            // 
            lbl_Contact.AutoSize = true;
            lbl_Contact.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Contact.ForeColor = SystemColors.ControlLightLight;
            lbl_Contact.Location = new Point(9, 9);
            lbl_Contact.Name = "lbl_Contact";
            lbl_Contact.Size = new Size(61, 23);
            lbl_Contact.TabIndex = 0;
            lbl_Contact.Text = "Kontakt";
            // 
            // panel_ContactBottom
            // 
            panel_ContactBottom.BackColor = Color.WhiteSmoke;
            panel_ContactBottom.Dock = DockStyle.Bottom;
            panel_ContactBottom.Location = new Point(0, 396);
            panel_ContactBottom.Name = "panel_ContactBottom";
            panel_ContactBottom.Size = new Size(800, 54);
            panel_ContactBottom.TabIndex = 4;
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_ContactBottom);
            Controls.Add(panel_ContactHeader);
            Name = "Contact";
            ShowIcon = false;
            panel_ContactHeader.ResumeLayout(false);
            panel_ContactHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ContactHeader;
        private Label lbl_Contact;
        private Panel panel_ContactBottom;
    }
}