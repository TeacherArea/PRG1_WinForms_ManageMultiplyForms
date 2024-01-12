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
            btn_Products = new Button();
            lbl_Home_Message = new Label();
            txtB_Home_Send = new TextBox();
            btn_Contact = new Button();
            btn_About = new Button();
            panel1 = new Panel();
            lbl_Message = new Label();
            panel_HomeHeader.SuspendLayout();
            panel1.SuspendLayout();
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
            // btn_Products
            // 
            btn_Products.Location = new Point(25, 69);
            btn_Products.Name = "btn_Products";
            btn_Products.Size = new Size(75, 23);
            btn_Products.TabIndex = 4;
            btn_Products.Text = "Produkter";
            btn_Products.UseVisualStyleBackColor = true;
            btn_Products.Click += btn_Products_Click;
            // 
            // lbl_Home_Message
            // 
            lbl_Home_Message.AutoSize = true;
            lbl_Home_Message.Location = new Point(25, 9);
            lbl_Home_Message.Name = "lbl_Home_Message";
            lbl_Home_Message.Size = new Size(360, 15);
            lbl_Home_Message.TabIndex = 5;
            lbl_Home_Message.Text = "Skriv in något i rutan nedan och välj till vilkn sida det ska skickas till";
            // 
            // txtB_Home_Send
            // 
            txtB_Home_Send.Location = new Point(25, 32);
            txtB_Home_Send.Name = "txtB_Home_Send";
            txtB_Home_Send.Size = new Size(360, 23);
            txtB_Home_Send.TabIndex = 6;
            // 
            // btn_Contact
            // 
            btn_Contact.Location = new Point(309, 69);
            btn_Contact.Name = "btn_Contact";
            btn_Contact.Size = new Size(75, 23);
            btn_Contact.TabIndex = 9;
            btn_Contact.Text = "Kontakt";
            btn_Contact.UseVisualStyleBackColor = true;
            btn_Contact.Click += btn_Contact_Click;
            // 
            // btn_About
            // 
            btn_About.Location = new Point(167, 69);
            btn_About.Name = "btn_About";
            btn_About.Size = new Size(75, 23);
            btn_About.TabIndex = 10;
            btn_About.Text = "Om oss";
            btn_About.UseVisualStyleBackColor = true;
            btn_About.Click += btn_About_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Home_Message);
            panel1.Controls.Add(btn_About);
            panel1.Controls.Add(btn_Products);
            panel1.Controls.Add(btn_Contact);
            panel1.Controls.Add(txtB_Home_Send);
            panel1.Location = new Point(12, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 107);
            panel1.TabIndex = 11;
            // 
            // lbl_Message
            // 
            lbl_Message.AutoSize = true;
            lbl_Message.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Message.Location = new Point(12, 188);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size(98, 23);
            lbl_Message.TabIndex = 14;
            lbl_Message.Text = "Meddelande";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Message);
            Controls.Add(panel1);
            Controls.Add(panel_HomeBottom);
            Controls.Add(panel_HomeHeader);
            Name = "Home";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            panel_HomeHeader.ResumeLayout(false);
            panel_HomeHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Home;
        private Panel panel_HomeHeader;
        private Panel panel_HomeBottom;
        private Button btn_Products;
        private Label lbl_Home_Message;
        private TextBox txtB_Home_Send;
        private Button btn_Contact;
        private Button btn_About;
        private Panel panel1;
        private Label lbl_Message;
    }
}