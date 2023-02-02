namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();               
        }

        int baslangic, bitis, tahmin, yenitahmin, tahminsayisi=0;

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tahminsayisi + ". Tahminde bildim :)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bitis = tahmin;
            if(((bitis-baslangic)/2)%1==0)
            {
                yenitahmin = tahmin - (bitis - baslangic) / 2;
            }
            else
            {
                yenitahmin = tahmin - (bitis - baslangic -1) / 2;
            }
            tahmin = yenitahmin;
            label3.Text = Convert.ToString(tahmin);
            tahminsayisi++;
            label5.Text = Convert.ToString(tahminsayisi + ". Tahmin:");
            if(baslangic==bitis)
            {
                MessageBox.Show("Sanýrým oyun bitti :)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baslangic = tahmin;
            if (((bitis - baslangic) / 2) % 1 == 0)
            {
                yenitahmin = tahmin + (bitis - baslangic) / 2;
            }
            else
            {
                yenitahmin = tahmin + ((bitis - baslangic - 1) / 2);
            }
            tahmin = yenitahmin;
            label3.Text = Convert.ToString(tahmin);
            tahminsayisi++;
            label5.Text = Convert.ToString(tahminsayisi+". Tahmin:");
            if (baslangic == bitis)
            {
                MessageBox.Show("Sanýrým oyun bitti :)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        baslangic=Convert.ToInt32(textBox1.Text);
        bitis=Convert.ToInt32(textBox2.Text);
        tahmin=(bitis-baslangic)/2;
        label3.Text=Convert.ToString(tahmin);
        tahminsayisi++;
        label5.Text = Convert.ToString(tahminsayisi + ". Tahmin:");
        }
    }
}