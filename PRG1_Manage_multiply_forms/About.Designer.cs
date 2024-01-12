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
            panel1 = new Panel();
            lbl_Home_Message = new Label();
            btn_Products = new Button();
            btn_Home = new Button();
            btn_Contact = new Button();
            txtB_About_Send = new TextBox();
            lbl_Message = new Label();
            panel_AboutHeader.SuspendLayout();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(lbl_Home_Message);
            panel1.Controls.Add(btn_Products);
            panel1.Controls.Add(btn_Home);
            panel1.Controls.Add(btn_Contact);
            panel1.Controls.Add(txtB_About_Send);
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
            btn_Products.Location = new Point(171, 69);
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
            // txtB_About_Send
            // 
            txtB_About_Send.Location = new Point(25, 32);
            txtB_About_Send.Name = "txtB_About_Send";
            txtB_About_Send.Size = new Size(360, 23);
            txtB_About_Send.TabIndex = 6;
            // 
            // lbl_Message
            // 
            lbl_Message.AutoSize = true;
            lbl_Message.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Message.Location = new Point(12, 191);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size(98, 23);
            lbl_Message.TabIndex = 14;
            lbl_Message.Text = "Meddelande";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Message);
            Controls.Add(panel1);
            Controls.Add(panel_AboutBottom);
            Controls.Add(panel_AboutHeader);
            Name = "About";
            ShowIcon = false;
            panel_AboutHeader.ResumeLayout(false);
            panel_AboutHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_AboutHeader;
        private Label lbl_About;
        private Panel panel_AboutBottom;
        private Panel panel1;
        private Label lbl_Home_Message;
        private Button btn_Products;
        private Button btn_Home;
        private Button btn_Contact;
        private TextBox txtB_About_Send;
        private Label lbl_Message;
    }
}