namespace Gittest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile(@"\\192.168.3.250\Veda\3 курс\ИСП 33-9, ИСП 34-11\МДК 03.01\Артем Брагин и Кондратьев\One-Ones-Branch\One-f353858068346a94e63ea1f15793a3436fb8f1c0\Gittest\Gittest\Resources\612_original.jpg");
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                pictureBox1.Image = Image.FromFile(@"\\192.168.3.250\Veda\3 курс\ИСП 33-9, ИСП 34-11\МДК 03.01\Артем Брагин и Кондратьев\One-Ones-Branch\One-f353858068346a94e63ea1f15793a3436fb8f1c0\Gittest\Gittest\Resources\1.jpg");
            }
        }
    }
}
