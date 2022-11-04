namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled=false;
            BtnB.Enabled=false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnS.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text=yanlıs.ToString();
                pictureBox2.Visible = true;

;            }

            

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnS.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnS.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;

                ;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnS.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnS.Enabled=false;

            soruno++;
            lblsoruno.Text= soruno.ToString();
            
            if(soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında Kuurldu";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";

            }
            if (soruno == 2) 
            {
                richTextBox1.Text = "Hangi İl Ege Bolgesınde Bulunmaz";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Denizli";
                label4.Text = "Balıkesir";
            }
            if(soruno == 3)
            {
                richTextBox1.Text = "Son Kuslar Hangi Yazarımıza Aittir";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İLhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                BtnS.Text = "Sonuclar";
            }
            if(soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled= false;
                BtnS.Enabled = false;
                MessageBox.Show("Dogru :" + dogru + "\n " + "Yanlıs :" + yanlıs);
            }
        }
    }
}