using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Taschenrechner Taschenrechner { get; private set; }
        public string Zahl1 { get; set; }
        public string Zahl2 { get; set; }
        public string Ergebnis { get; set; }
        public Form1()
        {
            Taschenrechner = new Taschenrechner();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var database = new DatabaseSimulator();
            var data = database.GetData();
            foreach (var item in data)
            {
                listBox1.Items.Add(item);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var database = new DatabaseSimulator();
            var data = await database.GetDataAsync();
            foreach (var item in data)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
