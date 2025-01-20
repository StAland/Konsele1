namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Taschenrechner Taschenrechner { get; private set; }
        public string Zahl1 { get; set; }
        public string Zahl2 { get; set; }
        public string Ergebnis {  get; set; }
        public Form1()
        {
            Taschenrechner = new Taschenrechner();
            InitializeComponent();
            label3.DataBindings.Add(new Binding("Text", form1BindingSource1, "Ergebnis"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double zahl1, zahl2;
            if(double.TryParse(Zahl1, out zahl1) && double.TryParse(Zahl2,out zahl2))
            {
                var ergebnis = zahl1 + zahl2;
                Ergebnis = "Ergebnis: " + ergebnis;
            }
        }
    }
}
