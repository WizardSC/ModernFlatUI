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
    }
}