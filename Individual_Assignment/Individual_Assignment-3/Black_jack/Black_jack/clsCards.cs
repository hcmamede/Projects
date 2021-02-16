using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;

namespace Black_jack
{
    class clsCards
    {

        public void NewMethod(PictureBox pCard, PictureBox pBack, int iX, int iY)
        {


            bool xUp = false;
            bool yUp = false;
            bool xLoop = true;
            bool yLoop = true;
            int x = pCard.Location.X;//623;
            int y = pCard.Location.Y;// 214;
            bool outCard = true;
            if (iX > x)
            {
                xUp = false;
            }
            else
            {
                xUp = true;
            }
            if (iY > y)
            {
                yUp = false;
            }
            else
            {
                yUp = true;
            }
            if (x != 623)
            {
                //outCard = false;
            }
            pBack.Location = new Point(x, y);

            while ((xLoop | yLoop) && (outCard))
            {
                if (xUp = true)
                {
                    if (x > iX)
                    {
                        xLoop = true;
                        x = x - 10;
                    }
                    else
                    {
                        xLoop = false;


                    }
                }
                else
                {
                    if (x < iX)
                    {
                        xLoop = true;
                        x = x + 10;
                    }
                    else
                    {
                        xLoop = false;
                    }

                }

                if (yUp = true)
                {
                    if (y < iY)
                    {
                        yLoop = true;
                        y = y + 10;
                    }
                    else
                    {
                        yLoop = false;
                    }
                }
                else
                {
                    if (y > iY)
                    {
                        yLoop = true;
                        y = y - 10;
                    }
                    else
                    {
                        yLoop = false;
                    }

                }
                pBack.Location = new Point(x, y);

                Task.Delay(1).Wait();
            }
            pCard.Location = new Point(x, y);
            pBack.Location = new Point(623, 214);

        }

        public void blood(PictureBox picBlood, PictureBox picGun)
        {
            int x = -564;
            if (picGun.Visible==true)
            {
                picBlood.Visible = true;

                while (x < 0)
                {
                    picBlood.Location = new Point(0, x);
                    x = x + 10;
                    Task.Delay(50).Wait();

                }
                picBlood.Visible = false;
                picGun.Visible = false;
            }
        }

    }
}
