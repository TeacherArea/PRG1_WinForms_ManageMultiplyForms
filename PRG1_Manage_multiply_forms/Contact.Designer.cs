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
            panel1 = new Panel();
            lbl_Home_Message = new Label();
            btn_Products = new Button();
            btn_Home = new Button();
            btn_About = new Button();
            txtB_Contact_Send = new TextBox();
            lbl_Message = new Label();
            panel_ContactHeader.SuspendLayout();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(lbl_Home_Message);
            panel1.Controls.Add(btn_Products);
            panel1.Controls.Add(btn_Home);
            panel1.Controls.Add(btn_About);
            panel1.Controls.Add(txtB_Contact_Send);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 107);
            panel1.TabIndex = 12;
            // 
            // lbl_Home_Message
            // 
            lbl_Home_Message.AutoSize = true;
            lbl_Home_Message.Location = new Point(25, 9);
            lbl_Home_Message.Name = "lbl_Home_Message";
            lbl_Home_Message.Size = new Size(293, 15);
            lbl_Home_Message.TabIndex = 5;
            lbl_Home_Message.Text = "Skriv in något och välj till vilken sida det ska skickas till";
            // 
            // btn_Products
            // 
            btn_Products.Location = new Point(167, 69);
            btn_Products.Name = "btn_Products";
            btn_Products.Size = new Size(75, 23);
            btn_Products.TabIndex = 10;
            btn_Products.Text = "Produkter";
            btn_Products.UseVisualStyleBackColor = true;
            btn_Products.Click += btn_Products_Click;
            // 
            // btn_Home
            // 
            btn_Home.Location = new Point(25, 69);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(75, 23);
            btn_Home.TabIndex = 4;
            btn_Home.Text = "Hem";
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // btn_About
            // 
            btn_About.Location = new Point(309, 69);
            btn_About.Name = "btn_About";
            btn_About.Size = new Size(75, 23);
            btn_About.TabIndex = 9;
            btn_About.Text = "Om oss";
            btn_About.UseVisualStyleBackColor = true;
            btn_About.Click += btn_About_Click;
            // 
            // txtB_Contact_Send
            // 
            txtB_Contact_Send.Location = new Point(25, 32);
            txtB_Contact_Send.Name = "txtB_Contact_Send";
            txtB_Contact_Send.Size = new Size(360, 23);
            txtB_Contact_Send.TabIndex = 6;
            // 
            // lbl_Message
            // 
            lbl_Message.AutoSize = true;
            lbl_Message.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Message.Location = new Point(12, 196);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size(98, 23);
            lbl_Message.TabIndex = 14;
            lbl_Message.Text = "Meddelande";
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Message);
            Controls.Add(panel1);
            Controls.Add(panel_ContactBottom);
            Controls.Add(panel_ContactHeader);
            Name = "Contact";
            ShowIcon = false;
            panel_ContactHeader.ResumeLayout(false);
            panel_ContactHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_ContactHeader;
        private Label lbl_Contact;
        private Panel panel_ContactBottom;
        private Panel panel1;
        private Label lbl_Home_Message;
        private Button btn_Products;
        private Button btn_Home;
        private Button btn_About;
        private TextBox txtB_Contact_Send;
        private Label lbl_Message;
    }
}