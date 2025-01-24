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

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(label1.Text);

            var dialogresult = form2.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                label1.Text = form2.TbText;

            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Speichern";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //speichern
            }
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(openFileDialog.FileName);
                    //laden
                }
            }
        }
    }
}
