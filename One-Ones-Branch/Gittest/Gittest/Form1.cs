namespace Gittest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void boltik()
        {
            Application.Run(new BOLT());
        }
        public void samorez()
        {
            Application.Run(new SAMOREZ()); 
        }

        private void photo1_Click(object sender, EventArgs e)
        {

            var th = new Thread(boltik);
            th.Start();
            MessageBox.Show("Вы открыли болт!");
        }

        private void photo2_Click(object sender, EventArgs e)
        {
            var th = new Thread(samorez);
            th.Start();
            MessageBox.Show("Вы открыли саморез!");
        }
    }
}
