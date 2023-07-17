namespace ModernFlatUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            pnBanHangSubMenu.Visible = false;
            pnNhapHangSubMenu.Visible = false;
            pnQuanLySubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pnBanHangSubMenu.Visible == true)
                pnBanHangSubMenu.Visible = false;
            if (pnNhapHangSubMenu.Visible == true)
                pnNhapHangSubMenu.Visible = false;
            if (pnQuanLySubMenu.Visible == true)
                pnQuanLySubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            showSubMenu(pnBanHangSubMenu);


        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            showSubMenu(pnNhapHangSubMenu);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            showSubMenu(pnQuanLySubMenu);
        }
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }
    }
}