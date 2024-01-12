namespace PRG1_Manage_multiply_forms
{
    partial class Products
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
            panel_ProductsHeader = new Panel();
            lbl_Products = new Label();
            panel_ProductsBottom = new Panel();
            panel1 = new Panel();
            lbl_Home_Message = new Label();
            btn_About = new Button();
            btn_Home = new Button();
            btn_Contact = new Button();
            txtB_Products_Send = new TextBox();
            lbl_Message = new Label();
            panel_ProductsHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ProductsHeader
            // 
            panel_ProductsHeader.BackColor = Color.DimGray;
            panel_ProductsHeader.Controls.Add(lbl_Products);
            panel_ProductsHeader.Dock = DockStyle.Top;
            panel_ProductsHeader.Location = new Point(0, 0);
            panel_ProductsHeader.Name = "panel_ProductsHeader";
            panel_ProductsHeader.Size = new Size(800, 43);
            panel_ProductsHeader.TabIndex = 2;
            // 
            // lbl_Products
            // 
            lbl_Products.AutoSize = true;
            lbl_Products.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Products.ForeColor = SystemColors.ControlLightLight;
            lbl_Products.Location = new Point(9, 9);
            lbl_Products.Name = "lbl_Products";
            lbl_Products.Size = new Size(77, 23);
            lbl_Products.TabIndex = 0;
            lbl_Products.Text = "Produkter";
            // 
            // panel_ProductsBottom
            // 
            panel_ProductsBottom.BackColor = Color.WhiteSmoke;
            panel_ProductsBottom.Dock = DockStyle.Bottom;
            panel_ProductsBottom.Location = new Point(0, 396);
            panel_ProductsBottom.Name = "panel_ProductsBottom";
            panel_ProductsBottom.Size = new Size(800, 54);
            panel_ProductsBottom.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Home_Message);
            panel1.Controls.Add(btn_About);
            panel1.Controls.Add(btn_Home);
            panel1.Controls.Add(btn_Contact);
            panel1.Controls.Add(txtB_Products_Send);
            panel1.Location = new Point(12, 60);
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
            // txtB_Products_Send
            // 
            txtB_Products_Send.Location = new Point(25, 32);
            txtB_Products_Send.Name = "txtB_Products_Send";
            txtB_Products_Send.Size = new Size(360, 23);
            txtB_Products_Send.TabIndex = 6;
            // 
            // lbl_Message
            // 
            lbl_Message.AutoSize = true;
            lbl_Message.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Message.Location = new Point(12, 202);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size(98, 23);
            lbl_Message.TabIndex = 13;
            lbl_Message.Text = "Meddelande";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Message);
            Controls.Add(panel1);
            Controls.Add(panel_ProductsBottom);
            Controls.Add(panel_ProductsHeader);
            Name = "Products";
            ShowIcon = false;
            panel_ProductsHeader.ResumeLayout(false);
            panel_ProductsHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_ProductsHeader;
        private Label lbl_Products;
        private Panel panel_ProductsBottom;
        private Panel panel1;
        private Label lbl_Home_Message;
        private Button btn_About;
        private Button btn_Home;
        private Button btn_Contact;
        private TextBox txtB_Products_Send;
        private Label lbl_Message;
    }
}