using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Rock_Paper_Scissors
{
    public partial class frm_Main : Form
    {
        
        public frm_Main()
        {
            InitializeComponent();
         




        }

        private void picRock_Click(object sender, EventArgs e)
        {

            var pic1_M = picRock_M;
            var pic2_M = picPaper_M;
            var pic3_M = picScissors_M;
            int pic_i = 1;
            Function_hands_M(pic1_M, pic2_M, pic3_M, pic_i);
            var pic1 = picRock;
            var pic2 = picPaper;
            var pic3 = picScissors;
            Function_hands(pic1, pic2,pic3);
            Function_hands_M_W(pic1_M, pic2_M, pic3_M);
            


        }
        public void Function_hands(PictureBox pic1, PictureBox pic2, PictureBox pic3)
        {

            

            pic1.Width = 130;
            pic1.Height = 167;

            pic1.Location = new Point(435, 220);
            int widthZoom = pic1.Width * 40 / 100;
            int heightZoom = pic1.Height * 40 / 100;

            pic1.Width += widthZoom;
            pic1.Height += heightZoom;


           
            pic2.Width = 130;
            pic2.Height = 167;
            pic2.Location = new Point(239, 283);
       


            pic3.Width = 130;
            pic3.Height = 167;
            pic3.Location = new Point(639, 283);



            Task.Delay(2000).Wait();
            pic1.Width = 130;
            pic1.Height = 167;
            pic1.Location = new Point(471, 283);
            
        }
        public void Function_hands_M(PictureBox pic1_M, PictureBox pic2_M, PictureBox pic3_M, int pic_i)
        {

            var random = new Random();
            int randomnumber = random.Next(1, 4);
            string radom_n = randomnumber.ToString();
            
            string ntotaly = txtradom.Text ;
            int inttotaly = Int32.Parse(ntotaly);
            inttotaly = inttotaly + 1;
            txtradom.Text = inttotaly.ToString();



            switch (radom_n)
            {
                case "1":
                    pic1_M.Visible = true;
                    pic2_M.Visible = false;
                    pic3_M.Visible = false;
                    break;
                case "2":
                    pic2_M.Visible = true;
                    pic1_M.Visible = false;
                    pic3_M.Visible = false;
                    break;
                case "3":
                    pic3_M.Visible = true;
                    pic2_M.Visible = false;
                    pic1_M.Visible = false;
                    break;
                default:
                    pic3_M.Visible = false;
                    pic2_M.Visible = false;
                    pic1_M.Visible = false;
                    break;

            }
            string machine = randomnumber.ToString();
            string play1 = pic_i.ToString();
         if (machine=="1" && play1 == "2")
            {
                picCheck.Visible = true;
                picNoCheck.Visible = false;
                picNo.Visible = false;
                string nPlay1 = txtPlay1.Text;
                int intPlay1 = Int32.Parse(nPlay1);
                intPlay1 = intPlay1 + 1;
                txtPlay1.Text = intPlay1.ToString();
            }
            else if (machine == "1" && play1 == "3")

            {
                picCheck.Visible = false;
                picNoCheck.Visible = true;
                picNo.Visible = false;
                string nMachine = txtMachine.Text;
                int intMachine = Int32.Parse(nMachine);
                intMachine = intMachine + 1;
                txtMachine.Text = intMachine.ToString();
            }
            else if (machine == "2" && play1 == "1")
            {
                picCheck.Visible = false;
                picNoCheck.Visible = true;
                picNo.Visible = false;
                string nMachine = txtMachine.Text;
                int intMachine = Int32.Parse(nMachine);
                intMachine = intMachine + 1;
                txtMachine.Text = intMachine.ToString();
            }
            else if (machine == "2" && play1 == "3")
            {
                picCheck.Visible = true;
                picNoCheck.Visible = false;
                picNo.Visible = false;
                string nPlay1 = txtPlay1.Text;
                int intPlay1 = Int32.Parse(nPlay1);
                intPlay1 = intPlay1 + 1;
                txtPlay1.Text = intPlay1.ToString();
            }
            else if (machine == "3" && play1 == "1")
            {
                picCheck.Visible = true;
                picNoCheck.Visible = false;
                picNo.Visible = false;
                string nPlay1 = txtPlay1.Text;
                int intPlay1 = Int32.Parse(nPlay1);
                intPlay1 = intPlay1 + 1;
                txtPlay1.Text = intPlay1.ToString();
            }
            else if (machine == "3" && play1 == "2")
            {
                picCheck.Visible = false;
                picNoCheck.Visible = true;
                picNo.Visible = false;
                string nMachine = txtMachine.Text;
                int intMachine = Int32.Parse(nMachine);
                intMachine = intMachine + 1;
                txtMachine.Text = intMachine.ToString();
            }
            else 
            {
                picCheck.Visible = false;
                picNoCheck.Visible = false;
                picNo.Visible = true;
            }

            lblResult.Text = txtradom.Text + "/10";
            lblPlay1.Text = "Your score: "+ txtPlay1.Text;
            lblMachine.Text = "Machine's score: " + txtMachine.Text;
            string nPlay12 = txtPlay1.Text;
            int intPlay12 = Int32.Parse(nPlay12);
            string nMachine2 = txtMachine.Text;
            int intMachine2 = Int32.Parse(nMachine2);
            if (inttotaly>9)
            { 
                if (intPlay12>intMachine2)
                {
                    MessageBox.Show("YOU WIN!!!!!");

                }
                else if (intMachine2>intPlay12)
                {
                    MessageBox.Show("YOU LOSE!!!!!");
                }
                else
                {
                    MessageBox.Show("NOBODY WINS!!!!!");
                }
                txtradom.Text = "0";
                txtMachine.Text = "0";
                txtPlay1.Text = "0";
                lblPlay1.Text = "Choose!!>>>";
            }
        }

        public static void Function_hands_M_W(PictureBox pic1_M, PictureBox pic2_M, PictureBox pic3_M)
        {
            /*pic1_M.Visible = false;
            pic2_M.Visible = false;
            pic3_M.Visible = false;
            */
        }
        private void picPaper_Click(object sender, EventArgs e)
        {
            var pic1_M = picRock_M;
            var pic2_M = picPaper_M;
            var pic3_M = picScissors_M;
            int pic_i = 2;
            Function_hands_M(pic1_M, pic2_M, pic3_M, pic_i);
            var pic2 = picRock;
            var pic1 = picPaper;
            var pic3 = picScissors;
            Function_hands(pic1, pic2, pic3);
            Function_hands_M_W(pic1_M, pic2_M, pic3_M);
        }

        private void picScissors_Click(object sender, EventArgs e)
        {
            var pic1_M = picRock_M;
            var pic2_M = picPaper_M;
            var pic3_M = picScissors_M;
            int pic_i = 3;
            Function_hands_M(pic1_M, pic2_M, pic3_M, pic_i);
            var pic3 = picRock;
            var pic2 = picPaper;
            var pic1 = picScissors;
            Function_hands(pic1, pic2, pic3);
            Function_hands_M_W(pic1_M, pic2_M, pic3_M);
        }

        private void PicScissors_M_Click(object sender, EventArgs e)
        {

        }
    }
}
