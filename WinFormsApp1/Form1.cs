namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblEingabe.Text = $"Du hast \"{txtEingabe.Text}\" eingegeben";
            
        }
    }
}
