namespace PRG1_Manage_multiply_forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            Home home = new Home();
            home.MdiParent = this;
            home.WindowState = FormWindowState.Maximized;
            home.DataSend += Pages_DataSend;
            home.Show();
        }

        internal void Pages_DataSend(string data, string target, string from)
        {
            switch (target)
            {
                case "Products":
                    OpenFormWithData<Products>(data, target, from);
                    break;
                case "About":
                    OpenFormWithData<About>(data, target, from);
                    break;
                case "Contact":
                    OpenFormWithData<Contact>(data, target, from);
                    break;
                case "Home":
                    OpenFormWithData<Home>(data, target, from);
                    break;
            }
        }
        private void OpenFormWithData<T>(string data, string target, string from) where T : Form, new()
        {
            CloseNotActiveForms(typeof(T));

            if (!FormAlreadyOpen(typeof(T)))
            {
                T form = new T();
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                (form as dynamic).ReceiveData(data, from);
                form.Show();
            }
        }

        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);
            this.Text = "Mitt program";
        }

        private void hemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseNotActiveForms(typeof(Home));

            if (!FormAlreadyOpen(typeof(Home)))
            {
                Home home = new Home();
                home.MdiParent = this;
                home.WindowState = FormWindowState.Maximized;
                home.DataSend += Pages_DataSend;
                home.Show();
            }
        }

        private void produkterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseNotActiveForms(typeof(Products));

            if (!FormAlreadyOpen(typeof(Products)))
            {
                Products products = new Products();
                products.MdiParent = this;
                products.WindowState = FormWindowState.Maximized;
                products.Show();
            }
        }

        private void omOssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseNotActiveForms(typeof(About));

            if (!FormAlreadyOpen(typeof(About)))
            {
                About about = new About();
                about.MdiParent = this;
                about.WindowState = FormWindowState.Maximized;
                about.Show();
            }
        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseNotActiveForms(typeof(Contact));

            if (!FormAlreadyOpen(typeof(Contact)))
            {
                Contact contact = new Contact();
                contact.MdiParent = this;
                contact.WindowState = FormWindowState.Maximized;
                contact.Show();
            }
        }
        private void CloseNotActiveForms(Type form)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() != form)
                {
                    childForm.Close();
                }
            }
        }
        public bool FormAlreadyOpen(Type form)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == form)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
    }
}