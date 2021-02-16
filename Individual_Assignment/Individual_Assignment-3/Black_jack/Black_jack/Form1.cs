using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace Black_jack
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

  
        private void Button1_Click(object sender, EventArgs e)
        {
            var vCards = new List<int>();
            vCards.Add(1);
            vCards.Add(2);
            vCards.Add(3);
            vCards.Add(4);
            vCards.Add(5);
            vCards.Add(6);
            vCards.Add(7);
            vCards.Add(8);
            vCards.Add(9);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);

            vCards.Add(1);
            vCards.Add(2);
            vCards.Add(3);
            vCards.Add(4);
            vCards.Add(5);
            vCards.Add(6);
            vCards.Add(7);
            vCards.Add(8);
            vCards.Add(9);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);

            vCards.Add(1);
            vCards.Add(2);
            vCards.Add(3);
            vCards.Add(4);
            vCards.Add(5);
            vCards.Add(6);
            vCards.Add(7);
            vCards.Add(8);
            vCards.Add(9);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);

            vCards.Add(1);
            vCards.Add(2);
            vCards.Add(3);
            vCards.Add(4);
            vCards.Add(5);
            vCards.Add(6);
            vCards.Add(7);
            vCards.Add(8);
            vCards.Add(9);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);


            var pCards = new List<PictureBox>();

            pCards.Add(pic1a);
            pCards.Add(pic2a);
            pCards.Add(pic3a);
            pCards.Add(pic4a);
            pCards.Add(pic5a);
            pCards.Add(pic6a);
            pCards.Add(pic7a);
            pCards.Add(pic8a);
            pCards.Add(pic9a);
            pCards.Add(pic10a);
            pCards.Add(pic11a);
            pCards.Add(pic12a);
            pCards.Add(pic13a);

            pCards.Add(pic1b);//13
            pCards.Add(pic2b);
            pCards.Add(pic3b);
            pCards.Add(pic4b);
            pCards.Add(pic5b);
            pCards.Add(pic6b);
            pCards.Add(pic7b);
            pCards.Add(pic8b);
            pCards.Add(pic9b);
            pCards.Add(pic10b);
            pCards.Add(pic11b);
            pCards.Add(pic12b);
            pCards.Add(pic13b);

            pCards.Add(pic1c);//27
            pCards.Add(pic2c);
            pCards.Add(pic3c);
            pCards.Add(pic4c);
            pCards.Add(pic5c);
            pCards.Add(pic6c);
            pCards.Add(pic7c);
            pCards.Add(pic8c);
            pCards.Add(pic9c);
            pCards.Add(pic10c);
            pCards.Add(pic11c);
            pCards.Add(pic12c);
            pCards.Add(pic13c);

            pCards.Add(pic1d);//40
            pCards.Add(pic2d);
            pCards.Add(pic3d);
            pCards.Add(pic4d);
            pCards.Add(pic5d);
            pCards.Add(pic6d);
            pCards.Add(pic7d);
            pCards.Add(pic8d);
            pCards.Add(pic9d);
            pCards.Add(pic10d);
            pCards.Add(pic11d);
            pCards.Add(pic12d);
            pCards.Add(pic13d);
            //lstMyGame.Items.AddRange(pCards.ToArray());

            
            var random = new Random();
            int randomnumber = random.Next(0, 51);
            int iCard = randomnumber;
            clsCards cards = new clsCards();
            //iCard = 39;
            int vPos = (74 * (lstMyGame.Items.Count))+200;
            cards.NewMethod(pCards.ElementAt(iCard), picMov, vPos, 464);
            lstMyGame.Items.Add(vCards.ElementAt(iCard));
            //var sCard = vCards.ElementAt(iCard);
            if (iCard==0 | iCard==13|  iCard==26 | iCard==39)
            {
                string message = "Do you choose the value 11 for this Card?";
                string title = "BlackJack";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    txttest.Text = (int.Parse(txttest.Text) + 10).ToString();
                }
                else
                {
                    // Do something  
                }
            }
            decimal vTotal = 0;
            for (int i=0;i<lstMyGame.Items.Count;i++ )
            {
                vTotal += Convert.ToDecimal(lstMyGame.Items[i].ToString());
            }
            txttest.Text = Convert.ToString(vTotal);
            int myPoints = int.Parse(txttest.Text);
            if ( myPoints>21)
            {
                MessageBox.Show("You Bust!!", "Blackd Jack");

                cards.blood(picBlood, picGun);
                picGun.Visible = true;
                btnHit.Visible = false;
                btnstay.Visible = false;
                btnRestart.Visible = true;
                btnBegin.Visible = true;
                btnStart.Visible = false;
                btnStart.Visible = false;
            }
            if (myPoints == 21)
            {
                MessageBox.Show("You Win!! 21!!", "Blachk Jack");
                btnHit.Visible = false;
                btnstay.Visible = false;
                btnRestart.Visible = true;
                btnBegin.Visible = true;
                btnStart.Visible = false;
                btnStart.Visible = false;
            }

        }

        private void Txttest_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnHit.Visible = true;
            btnstay.Visible = true;
            btnRestart.Visible = false;
            btnBegin.Visible = true;
            btnStart.Visible = false;
           
            var vCards = new List<int>();
            vCards.Add(1);
            vCards.Add(2);
            vCards.Add(3);
            vCards.Add(4);
            vCards.Add(5);
            vCards.Add(6);
            vCards.Add(7);
            vCards.Add(8);
            vCards.Add(9);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);

            vCards.Add(1);
            vCards.Add(2);
            vCards.Add(3);
            vCards.Add(4);
            vCards.Add(5);
            vCards.Add(6);
            vCards.Add(7);
            vCards.Add(8);
            vCards.Add(9);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);

            vCards.Add(1);
            vCards.Add(2);
            vCards.Add(3);
            vCards.Add(4);
            vCards.Add(5);
            vCards.Add(6);
            vCards.Add(7);
            vCards.Add(8);
            vCards.Add(9);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);

            vCards.Add(1);
            vCards.Add(2);
            vCards.Add(3);
            vCards.Add(4);
            vCards.Add(5);
            vCards.Add(6);
            vCards.Add(7);
            vCards.Add(8);
            vCards.Add(9);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);
            vCards.Add(10);


            var pCards = new List<PictureBox>();

            pCards.Add(pic1a);
            pCards.Add(pic2a);
            pCards.Add(pic3a);
            pCards.Add(pic4a);
            pCards.Add(pic5a);
            pCards.Add(pic6a);
            pCards.Add(pic7a);
            pCards.Add(pic8a);
            pCards.Add(pic9a);
            pCards.Add(pic10a);
            pCards.Add(pic11a);
            pCards.Add(pic12a);
            pCards.Add(pic13a);

            pCards.Add(pic1b);
            pCards.Add(pic2b);
            pCards.Add(pic3b);
            pCards.Add(pic4b);
            pCards.Add(pic5b);
            pCards.Add(pic6b);
            pCards.Add(pic7b);
            pCards.Add(pic8b);
            pCards.Add(pic9b);
            pCards.Add(pic10b);
            pCards.Add(pic11b);
            pCards.Add(pic12b);
            pCards.Add(pic13b);

            pCards.Add(pic1c);
            pCards.Add(pic2c);
            pCards.Add(pic3c);
            pCards.Add(pic4c);
            pCards.Add(pic5c);
            pCards.Add(pic6c);
            pCards.Add(pic7c);
            pCards.Add(pic8c);
            pCards.Add(pic9c);
            pCards.Add(pic10c);
            pCards.Add(pic11c);
            pCards.Add(pic12c);
            pCards.Add(pic13c);

            pCards.Add(pic1d);
            pCards.Add(pic2d);
            pCards.Add(pic3d);
            pCards.Add(pic4d);
            pCards.Add(pic5d);
            pCards.Add(pic6d);
            pCards.Add(pic7d);
            pCards.Add(pic8d);
            pCards.Add(pic9d);
            pCards.Add(pic10d);
            pCards.Add(pic11d);
            pCards.Add(pic12d);
            pCards.Add(pic13d);
            //lstMyGame.Items.AddRange(pCards.ToArray());


            var random = new Random();
            int randomnumber = random.Next(0, 51);
            int iCard = randomnumber;
            clsCards cards = new clsCards();

            cards.NewMethod(pCards.ElementAt(iCard), picMov, 423, 189);
            lstDealer.Items.Add(vCards.ElementAt(iCard));
            int randomnumber1 = random.Next(0, 51);
            iCard = randomnumber1;
            cards.NewMethod(pCards.ElementAt(iCard), picMov, 349, 189);
            lstDealer.Items.Add(vCards.ElementAt(iCard));
            pDealer.Visible = true;

            decimal dTotal = 0;
            for (int i = 0; i < lstDealer.Items.Count; i++)
            {
                dTotal += Convert.ToDecimal(lstDealer.Items[i].ToString());
            }
            txtDealer.Text = dTotal.ToString();
            int randomnumber2 = random.Next(0, 51);
            iCard = randomnumber2;
            int vPos = (74 * (lstMyGame.Items.Count)) + 200;
            cards.NewMethod(pCards.ElementAt(iCard), picMov, vPos, 464);
            lstMyGame.Items.Add(vCards.ElementAt(iCard));
            if (iCard == 0 | iCard == 13 | iCard == 26 | iCard == 39)
            {
                string message = "Do you choose the value 11 for this Card?";
                string title = "BlackJack";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    // txttest.Text = (int.Parse(txttest.Text) + 10).ToString();
                    lstMyGame.Items.Add(10);
                }
                else
                {
                    // Do something  
                }
            }
            int randomnumber3 = random.Next(0, 51);
            iCard = randomnumber3;
            vPos = (74 * (lstMyGame.Items.Count)) + 200;
            cards.NewMethod(pCards.ElementAt(iCard), picMov, vPos, 464);
            lstMyGame.Items.Add(vCards.ElementAt(iCard));
            if (iCard == 0 | iCard == 13 | iCard == 26 | iCard == 39)
            {
                string message = "Do you choose the value 11 for this Card?";
                string title = "BlackJack";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    // txttest.Text = (int.Parse(txttest.Text) + 10).ToString();
                    lstMyGame.Items.Add(10);
                }
                else
                {
                    // Do something  
                }
            }
            //if (iCard == 0 | iCard == 13 | iCard == 24 | iCard == 40)

                if (iCard == 0 | iCard == 13 | iCard == 26 | iCard == 39)
                {
                string message = "Do you choose the value 11 for this Card?";
                string title = "BlackJack";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    // txttest.Text = (int.Parse(txttest.Text) + 10).ToString();
                    lstMyGame.Items.Add(10);
                }
                else
                {
                    // Do something  
                }
            }
            decimal vTotal = 0;
            for (int i = 0; i < lstMyGame.Items.Count; i++)
            {
                vTotal += Convert.ToDecimal(lstMyGame.Items[i].ToString());
            }
            txttest.Text = Convert.ToString(vTotal);
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            btnHit.Visible = false;
            btnstay.Visible = false;
            btnRestart.Visible = false;
            btnBegin.Visible = true;
            btnStart.Visible = true;
            clsCards cards = new clsCards();
            var pCards = new List<PictureBox>();
            lstMyGame.Items.Clear();
            lstDealer.Items.Clear();
            pCards.Add(pic1a);
            pCards.Add(pic2a);
            pCards.Add(pic3a);
            pCards.Add(pic4a);
            pCards.Add(pic5a);
            pCards.Add(pic6a);
            pCards.Add(pic7a);
            pCards.Add(pic8a);
            pCards.Add(pic9a);
            pCards.Add(pic10a);
            pCards.Add(pic11a);
            pCards.Add(pic12a);
            pCards.Add(pic13a);

            pCards.Add(pic1b);
            pCards.Add(pic2b);
            pCards.Add(pic3b);
            pCards.Add(pic4b);
            pCards.Add(pic5b);
            pCards.Add(pic6b);
            pCards.Add(pic7b);
            pCards.Add(pic8b);
            pCards.Add(pic9b);
            pCards.Add(pic10b);
            pCards.Add(pic11b);
            pCards.Add(pic12b);
            pCards.Add(pic13b);

            pCards.Add(pic1c);
            pCards.Add(pic2c);
            pCards.Add(pic3c);
            pCards.Add(pic4c);
            pCards.Add(pic5c);
            pCards.Add(pic6c);
            pCards.Add(pic7c);
            pCards.Add(pic8c);
            pCards.Add(pic9c);
            pCards.Add(pic10c);
            pCards.Add(pic11c);
            pCards.Add(pic12c);
            pCards.Add(pic13c);

            pCards.Add(pic1d);
            pCards.Add(pic2d);
            pCards.Add(pic3d);
            pCards.Add(pic4d);
            pCards.Add(pic5d);
            pCards.Add(pic6d);
            pCards.Add(pic7d);
            pCards.Add(pic8d);
            pCards.Add(pic9d);
            pCards.Add(pic10d);
            pCards.Add(pic11d);
            pCards.Add(pic12d);
            pCards.Add(pic13d);
            pDealer.Visible = false;
            for(int i=0; i< pCards.Count ;i++)
            {
                var item = pCards.ElementAt(i);
                if (item.Location.X == 623 && item.Location.Y == 214)
                {
                    //txtDealer.Text = "a";
                }
                else
                {
                    cards.NewMethod(item, picMov, 123, 214);
                    // lstMyGame.Items.Add(vCards.ElementAt(iCard));
                }
                
            }
        }

        private void Btnstay_Click(object sender, EventArgs e)
        {
            pDealer.Visible = false;
            int myPoints = int.Parse(txttest.Text);
            int DealerP = int.Parse(txtDealer.Text);

            while (DealerP<17)
            {

                var vCards = new List<int>();
                vCards.Add(1);
                vCards.Add(2);
                vCards.Add(3);
                vCards.Add(4);
                vCards.Add(5);
                vCards.Add(6);
                vCards.Add(7);
                vCards.Add(8);
                vCards.Add(9);
                vCards.Add(10);
                vCards.Add(10);
                vCards.Add(10);
                vCards.Add(10);

                vCards.Add(1);
                vCards.Add(2);
                vCards.Add(3);
                vCards.Add(4);
                vCards.Add(5);
                vCards.Add(6);
                vCards.Add(7);
                vCards.Add(8);
                vCards.Add(9);
                vCards.Add(10);
                vCards.Add(10);
                vCards.Add(10);
                vCards.Add(10);

                vCards.Add(1);
                vCards.Add(2);
                vCards.Add(3);
                vCards.Add(4);
                vCards.Add(5);
                vCards.Add(6);
                vCards.Add(7);
                vCards.Add(8);
                vCards.Add(9);
                vCards.Add(10);
                vCards.Add(10);
                vCards.Add(10);
                vCards.Add(10);

                vCards.Add(1);
                vCards.Add(2);
                vCards.Add(3);
                vCards.Add(4);
                vCards.Add(5);
                vCards.Add(6);
                vCards.Add(7);
                vCards.Add(8);
                vCards.Add(9);
                vCards.Add(10);
                vCards.Add(10);
                vCards.Add(10);
                vCards.Add(10);


                var pCards = new List<PictureBox>();

                pCards.Add(pic1a);
                pCards.Add(pic2a);
                pCards.Add(pic3a);
                pCards.Add(pic4a);
                pCards.Add(pic5a);
                pCards.Add(pic6a);
                pCards.Add(pic7a);
                pCards.Add(pic8a);
                pCards.Add(pic9a);
                pCards.Add(pic10a);
                pCards.Add(pic11a);
                pCards.Add(pic12a);
                pCards.Add(pic13a);

                pCards.Add(pic1b);
                pCards.Add(pic2b);
                pCards.Add(pic3b);
                pCards.Add(pic4b);
                pCards.Add(pic5b);
                pCards.Add(pic6b);
                pCards.Add(pic7b);
                pCards.Add(pic8b);
                pCards.Add(pic9b);
                pCards.Add(pic10b);
                pCards.Add(pic11b);
                pCards.Add(pic12b);
                pCards.Add(pic13b);

                pCards.Add(pic1c);
                pCards.Add(pic2c);
                pCards.Add(pic3c);
                pCards.Add(pic4c);
                pCards.Add(pic5c);
                pCards.Add(pic6c);
                pCards.Add(pic7c);
                pCards.Add(pic8c);
                pCards.Add(pic9c);
                pCards.Add(pic10c);
                pCards.Add(pic11c);
                pCards.Add(pic12c);
                pCards.Add(pic13c);

                pCards.Add(pic1d);
                pCards.Add(pic2d);
                pCards.Add(pic3d);
                pCards.Add(pic4d);
                pCards.Add(pic5d);
                pCards.Add(pic6d);
                pCards.Add(pic7d);
                pCards.Add(pic8d);
                pCards.Add(pic9d);
                pCards.Add(pic10d);
                pCards.Add(pic11d);
                pCards.Add(pic12d);
                pCards.Add(pic13d);
                //lstMyGame.Items.AddRange(pCards.ToArray());


                var random = new Random();
                int randomnumber = random.Next(0, 51);
                int iCard = randomnumber;
                clsCards cards = new clsCards();

                cards.NewMethod(pCards.ElementAt(iCard), picMov, 493, 189);
                lstDealer.Items.Add(vCards.ElementAt(iCard));

                decimal dTotal = 0;
                for (int i = 0; i < lstDealer.Items.Count; i++)
                {
                    dTotal += Convert.ToDecimal(lstDealer.Items[i].ToString());
                }
                txtDealer.Text = dTotal.ToString();
                DealerP = int.Parse(txtDealer.Text);
            }

            DealerP = int.Parse(txtDealer.Text);
            if (myPoints > DealerP || DealerP >21 )
            {
                MessageBox.Show("You Win!!", "Black Jack");
                btnHit.Visible = false;
                btnstay.Visible = false;
                btnRestart.Visible = true;
                btnBegin.Visible = true;
                btnStart.Visible = false;
            }
            if (myPoints <= DealerP && DealerP < 22)
            {
                //cards.blood(picBlood, picGun);
                picGun.Visible = true;
                MessageBox.Show("You Bust!!", "Black Jack");
                btnHit.Visible = false;
                btnstay.Visible = false;
                btnRestart.Visible = true;
                btnBegin.Visible = true;
                btnStart.Visible = false;
            }
            else
            {
               /* //cards.blood(picBlood, picGun);
                picGun.Visible = true;
                MessageBox.Show("You Bust!!", "Black Jack");
                btnHit.Visible = false;
                btnstay.Visible = false;
                btnRestart.Visible = true;
                btnBegin.Visible = true;
                btnStart.Visible = false;
                */
            }

        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            btnHit.Visible = false;
            btnstay.Visible = false;
            btnRestart.Visible = false;
            btnBegin.Visible = false;
            btnStart.Visible = true;
            picGun.Visible = false;
            clsCards cards = new clsCards();
            var pCards = new List<PictureBox>();
            lstMyGame.Items.Clear();
            lstDealer.Items.Clear();
            pCards.Add(pic1a);
            pCards.Add(pic2a);
            pCards.Add(pic3a);
            pCards.Add(pic4a);
            pCards.Add(pic5a);
            pCards.Add(pic6a);
            pCards.Add(pic7a);
            pCards.Add(pic8a);
            pCards.Add(pic9a);
            pCards.Add(pic10a);
            pCards.Add(pic11a);
            pCards.Add(pic12a);
            pCards.Add(pic13a);

            pCards.Add(pic1b);
            pCards.Add(pic2b);
            pCards.Add(pic3b);
            pCards.Add(pic4b);
            pCards.Add(pic5b);
            pCards.Add(pic6b);
            pCards.Add(pic7b);
            pCards.Add(pic8b);
            pCards.Add(pic9b);
            pCards.Add(pic10b);
            pCards.Add(pic11b);
            pCards.Add(pic12b);
            pCards.Add(pic13b);

            pCards.Add(pic1c);
            pCards.Add(pic2c);
            pCards.Add(pic3c);
            pCards.Add(pic4c);
            pCards.Add(pic5c);
            pCards.Add(pic6c);
            pCards.Add(pic7c);
            pCards.Add(pic8c);
            pCards.Add(pic9c);
            pCards.Add(pic10c);
            pCards.Add(pic11c);
            pCards.Add(pic12c);
            pCards.Add(pic13c);

            pCards.Add(pic1d);
            pCards.Add(pic2d);
            pCards.Add(pic3d);
            pCards.Add(pic4d);
            pCards.Add(pic5d);
            pCards.Add(pic6d);
            pCards.Add(pic7d);
            pCards.Add(pic8d);
            pCards.Add(pic9d);
            pCards.Add(pic10d);
            pCards.Add(pic11d);
            pCards.Add(pic12d);
            pCards.Add(pic13d);
            pDealer.Visible = false;
            for (int i = 0; i < pCards.Count; i++)
            {
                var item = pCards.ElementAt(i);
                item.Location = new Point(623, 214);
                    //cards.NewMethod2(item, picMov, 623, 214);
                    // lstMyGame.Items.Add(vCards.ElementAt(iCard));
                

            }

        }
    }
}
