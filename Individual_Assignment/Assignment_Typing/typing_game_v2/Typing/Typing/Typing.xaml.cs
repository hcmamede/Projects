using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Typing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtLeft.Text = "100";

            imgfall.Visibility = Visibility.Hidden;
            imgGoat.Visibility = Visibility.Visible;
            textBox1.Focus();
            var olbl = new[] { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10 };
            string sLevel;
            clsTyping test = new clsTyping();
            sLevel = test.getsLine(0);
            string[] letters = test.getKeyArray(sLevel);
            for (int i = 0; i < 10; i++)
            {
                olbl[i].Opacity = 0.7;
                olbl[i].Content = (letters[i]).ToUpper();

            }
            txttest.Text = "0";
           int lIndex = Int32.Parse(txttest.Text);

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string sTyping;
            var olbl= new[] { lbl1, lbl2 ,lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10 };
            int index = 0;
            int lIndex = Int32.Parse(txttest.Text);
            for (int i = 0; i < 10; i++)
            {
                if (olbl[i].Opacity == 1)
                {
                    index++;
                }
            }
           
            clsTyping test = new clsTyping();
            if (textBox1.Text != "")
            {
                // imgGoat.Margin.Left = 30;

                //imgGoat.Visible = false;


                // ... Get Image reference from sender.
                //var image = sender as Image;
                // ... Assign Source.
                
                //imgGoat1.Source = new BitmapImage(new Uri(@"/Images/IMG_4750.png", UriKind.Relative));

                sTyping = (textBox1.Text).ToUpper();
                if (test.getKey(sTyping, index, lIndex))
                {
                    olbl[index].Opacity = 1;
                    string sLeft = (olbl[index].Margin.Left).ToString() ;
                    //sLeft.Split(',');
                     txtLeft.Text=sLeft.ToString();

                    int iLeft = (Int32.Parse(sLeft));
                    //iLeft = iLeft + 40;
                    //txtLeft.Text = iLeft.ToString();
                    Canvas.SetLeft(imgGoat, iLeft);
                    Canvas.SetLeft(imgfall, iLeft);
                    imgfall.Visibility = Visibility.Hidden;
                    imgGoat.Visibility = Visibility.Visible;
                    //Canvas.SetTop(imgGoat, 40);


                }
                else
                {
                    //olbl[index].Opacity = 1;
                    string sLeft = (olbl[index].Margin.Left).ToString();
                    //sLeft.Split(',');
                    txtLeft.Text = sLeft.ToString();

                    int iLeft = (Int32.Parse(sLeft));
                    //iLeft = iLeft + 40;
                    //txtLeft.Text = iLeft.ToString();
                    Canvas.SetLeft(imgGoat, iLeft);
                    Canvas.SetLeft(imgfall, iLeft);
                    imgfall.Visibility = Visibility.Visible;
                    imgGoat.Visibility = Visibility.Hidden;
                }
                textBox1.Text = "";

                if (lbl10.Opacity == 1)
                {
                    lbl10.Opacity = 100;
                    // Task.Delay(2000).Wait();
                    txttest.Text = ((Int32.Parse(txttest.Text)) + 1).ToString();
                    lIndex = Int32.Parse(txttest.Text);
                    string sLevel = test.getsLine(lIndex);
                    string[] letters = test.getKeyArray(sLevel);
                    
                        

                    for (int i = 0; i < 10; i++)
                    {
                        olbl[i].Opacity = 0.7;
                        olbl[i].Content = (letters[i]).ToUpper();


                    }
                    Canvas.SetLeft(imgGoat, 50);
                    Canvas.SetLeft(imgfall, 50);
                };

            }

           

        }

    }
}
