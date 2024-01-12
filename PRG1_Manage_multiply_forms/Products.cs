namespace PRG1_Manage_multiply_forms
{
    public partial class Products : Form
    {
        public Products()
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
            string from = "Produkter";
            string input = txtB_Products_Send.Text;
            DataSend?.Invoke(input, target, from);
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            string target = "About";
            string from = "Produkter";
            string input = txtB_Products_Send.Text;
            DataSend?.Invoke(input, target, from);
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            string target = "Contact";
            string from = "Produkter";
            string input = txtB_Products_Send.Text;
            DataSend?.Invoke(input, target, from);
        }
        public void ReceiveData(string data, string target)
        {
            lbl_Message.Text = $"Värdet \"{data}\" kom från sida: {target}";
        }
    }
}
