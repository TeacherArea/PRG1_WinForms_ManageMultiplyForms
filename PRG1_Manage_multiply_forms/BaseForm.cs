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
            home.Show();
        }
        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);
            // Sätt titeln till 'Mitt program' varje gång ett barnformulär aktiveras eller inaktiveras
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