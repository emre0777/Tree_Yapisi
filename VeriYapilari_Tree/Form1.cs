namespace VeriYapilari_Tree
{
    public partial class Form1 : Form
    {
        public List<int> list = new List<int>();

        public Tree t1 = new Tree();


        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)  // düðüm ekle butonu
        {
            try
            {
                int deger = int.Parse(textBox1.Text);
                bool durum = false;
                foreach (var item in list)
                {
                    if (item == deger)
                    {
                        durum = true;
                    }

                }
                if (durum)
                {
                    MessageBox.Show("Bu Deðer Zaten Aðaçta Var!!");
                    button1.BackColor = Color.Red;
                }
                else
                {
                    t1.Insert(deger);
                    list.Add(deger);
                    label1.Text = deger + " eklendi";
                    button1.BackColor = Color.Green;
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayý giriniz.");
            }


            textBox1.Clear();

        }


        public void button2_Click(object sender, EventArgs e)  // düðüm silme butonu
        {


            try
            {
                int deger = int.Parse(textBox2.Text);
                bool durum = false;
                foreach (var item in list)
                {
                    if (item == deger)
                    {
                        durum = true;
                    }

                }
                if (durum)
                {
                    t1.Delete(deger);
                    list.Remove(deger);
                    label2.Text = deger + " Silindi";
                    button2.BackColor = Color.Green;

                }
                else
                {

                    MessageBox.Show("Bu Deðer Aðaçta Bulunmamaktadýr.");
                    button2.BackColor = Color.Red;



                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayý giriniz.");
            }
            textBox2.Clear();

        }



        public void button3_Click(object sender, EventArgs e) // düðüm bul butonu
        {

            try
            {

                int deger = int.Parse(textBox3.Text);

                if (t1.arama(deger))
                {
                    label3.Text = "Aðaçta Var ";
                    button3.BackColor = Color.Green;
                }
                else
                {
                    label3.Text = "Aðaçta Yok ";
                    button3.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Sayý Giriniz.");
            }
            textBox3.Clear();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            listBox1.BackColor = Color.Khaki;

            textBox1.BackColor = Color.LightBlue;
            textBox2.BackColor = Color.LightBlue;
            textBox3.BackColor = Color.LightBlue;
            textBox4.BackColor = Color.LightBlue;
            textBox5.BackColor = Color.LightBlue;
            textBox6.BackColor = Color.LightBlue;
            textBox7.BackColor = Color.LightBlue;
            textBox8.BackColor = Color.LightBlue;
            textBox9.BackColor = Color.LightBlue;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)  // aðaçtaki düðümleri göster butonu
        {
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }


        }

        public void button5_Click(object sender, EventArgs e) // aðaç bilgilerini göster butonu
        {
            // INORDER PREORDER POSTORDER
            List<int> listem = new List<int>();
            listem.Clear();

            t1.preOrder(t1.root, listem);
            textBox4.Text = string.Join("-", listem);

            listem.Clear();
            t1.ýnOrder(t1.root, listem);
            textBox5.Text = string.Join("-", listem);

            listem.Clear();
            t1.postOrder(t1.root, listem);
            textBox6.Text = string.Join("-", listem);


            //toplam  düðüm sayýsý

            textBox7.Text = t1.dugumsayisi(t1.root).ToString();

            // YÜKSEKLÝK

            textBox8.Text = t1.yukseklik(t1.root).ToString();

            // yaprak

            listem.Clear();
            t1.yaprak(t1.root, listem);
            textBox9.Text = string.Join("-", listem);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
