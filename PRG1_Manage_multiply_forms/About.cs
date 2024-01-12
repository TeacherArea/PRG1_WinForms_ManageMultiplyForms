﻿namespace PRG1_Manage_multiply_forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        public delegate void DataSendDelegate(string data, string target, string from);
        public event DataSendDelegate DataSend;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (this.MdiParent is BaseForm parentForm)
            {
                this.DataSend += parentForm.Pages_DataSend;
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            string target = "Home";
            string from = "Om oss";
            string input = txtB_About_Send.Text;
            DataSend?.Invoke(input, target, from);
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            string target = "Products";
            string from = "Om oss";
            string input = txtB_About_Send.Text;
            DataSend?.Invoke(input, target, from);
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            string target = "Contact";
            string from = "Om oss";
            string input = txtB_About_Send.Text;
            DataSend?.Invoke(input, target, from);
        }
        public void ReceiveData(string data, string target)
        {
            lbl_Message.Text = $"Värdet \"{data}\" kom från sida: {target}";
        }
    }
}
