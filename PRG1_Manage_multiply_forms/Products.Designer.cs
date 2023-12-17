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
            panel_ProductsHeader.SuspendLayout();
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
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_ProductsBottom);
            Controls.Add(panel_ProductsHeader);
            Name = "Products";
            ShowIcon = false;
            panel_ProductsHeader.ResumeLayout(false);
            panel_ProductsHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ProductsHeader;
        private Label lbl_Products;
        private Panel panel_ProductsBottom;
    }
}