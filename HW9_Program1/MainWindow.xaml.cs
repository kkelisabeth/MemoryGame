/*
* Creator:      Kozlova Elizabeth Paula
*
* Title:        Memory Game 
*
* Description:
*               The program dispalys a window with 16 cards, by clicking on each card it will flip and you will get a picture 
*               To win, you need to open same pictures one after another 
*               
* TODO: Modify the algorithm for checking the cards 
* 
*/

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

namespace HW9_Program1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool check = false; //closed
        bool winXiao = false;
        bool winKazuha = false;
        bool winWanderer = false;
        bool winVenti = false;
        bool winLisa = false;
        bool winRaiden = false;
        bool winYae = false;
        bool winKequing = false;
        //List <Button> buttonList;
        public MainWindow()
        {
            InitializeComponent();
            /* buttonList.Add(XiaoButton);
             buttonList.Add(XiaoButton2);
             buttonList.Add(KazuhaButton);
             buttonList.Add(KazuhaButton2);
             buttonList.Add(WandererButton);
             buttonList.Add(WandererButton2);
             buttonList.Add(VentiButton);
             buttonList.Add(VentiButton2);
             buttonList.Add(LisaButton);
             buttonList.Add(LisaButton2);
             buttonList.Add(YaeMikoButton);
             buttonList.Add(YaeMikoButton2);
             buttonList.Add(RaidenButton);
             buttonList.Add(RaidenButton2);
             buttonList.Add(KequingButton);
             buttonList.Add(KequingButton2);*/
        }

        private void XiaoButton_Click(object sender, RoutedEventArgs e)
        {
            XiaoImage1.Visibility = Visibility.Visible;
            if (check)
            {
                if (XiaoImage2.IsVisible == true) winXiao = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                XiaoImage1.Visibility = Visibility.Visible;
                check = true;
            }

        }

        private void KequingButton_Click(object sender, RoutedEventArgs e)
        {
            KequingImage1.Visibility = Visibility.Visible;
            if (check)
            {
                KequingImage1.Visibility = Visibility.Visible;
                if (KequingImage2.IsVisible == true) winKequing = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                KequingImage1.Visibility = Visibility.Visible;
                check = true;
            }


        }

        private void WandererButton_Click(object sender, RoutedEventArgs e)
        {
            WandererImage1.Visibility = Visibility.Visible;
            if (check)
            {
                if (WandererImage2.IsVisible == true) winWanderer = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                WandererImage1.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void KazuhaButton_Click(object sender, RoutedEventArgs e)
        {
            KazuhaImage1.Visibility = Visibility.Visible;
            if (check)
            {
                if (KazuhaImage2.IsVisible == true) winKazuha = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                KazuhaImage1.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void LisaButton_Click(object sender, RoutedEventArgs e)
        {
            LisaImage1.Visibility = Visibility.Visible;
            if (check)
            {
                if (LisaImage2.IsVisible == true) winLisa = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                LisaImage1.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void VentiButton_Click(object sender, RoutedEventArgs e)
        {
            VentiImage1.Visibility = Visibility.Visible;
            if (check)
            {
                if (VentiImage2.IsVisible == true) winVenti = true;
                else
                {
                    win();
                }

                check = false;
            }
            else
            {
                VentiImage1.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void KazuhaButton2_Click(object sender, RoutedEventArgs e)
        {
            KazuhaImage2.Visibility = Visibility.Visible;
            if (check)
            {
                if (KazuhaImage1.IsVisible == true) winKazuha = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                KazuhaImage2.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void YaeMikoButton_Click(object sender, RoutedEventArgs e)
        {
            YaeMikoImage1.Visibility = Visibility.Visible;
            if (check)
            {
                if (YaeMikoImage2.IsVisible == true) winYae = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                YaeMikoImage1.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void XiaoButton2_Click(object sender, RoutedEventArgs e)
        {
            if (check)
            {
                XiaoImage2.Visibility = Visibility.Visible;
                if (XiaoImage1.IsVisible == true) winXiao = true;
                else
                {
                    win(); 
                }
                check = false;
            }
            else
            {
                XiaoImage2.Visibility = Visibility.Visible;
                check = true;
            }

        }

        private void RaidenButton2_Click(object sender, RoutedEventArgs e)
        {
            RaidenImage1.Visibility = Visibility.Visible;
            if (check)
            {
                if (RaidenImage2.IsVisible == true) winRaiden = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                RaidenImage1.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void WandererButton2_Click(object sender, RoutedEventArgs e)
        {
            WandererImage2.Visibility = Visibility.Visible;
            if (check)
            {
                if (WandererImage1.IsVisible == true) winWanderer = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                WandererImage2.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void KequingButton2_Click(object sender, RoutedEventArgs e)
        {
            KequingImage2.Visibility = Visibility.Visible;
            if (check)
            {
                if (KequingImage1.IsVisible == true) winKequing = true;
                else
                {
                    win(); 
                }

                check = false; ;
            }
            else
            {
                KequingImage2.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void LisaButton2_Click(object sender, RoutedEventArgs e)
        {
            LisaImage2.Visibility = Visibility.Visible;
            if (check)
            {
                if (LisaImage1.IsVisible == true) winLisa = true ;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                LisaImage2.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void YaeMikoButton2_Click(object sender, RoutedEventArgs e)
        {
            YaeMikoImage2.Visibility = Visibility.Visible;
            if (check)
            {
                if (YaeMikoImage1.IsVisible == true) winYae = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                YaeMikoImage2.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void VentiButton2_Click(object sender, RoutedEventArgs e)
        {
            VentiImage2.Visibility = Visibility.Visible;
            if (check)
            {
                if (VentiImage1.IsVisible == true) winVenti = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                VentiImage2.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void RaidenButton_Click(object sender, RoutedEventArgs e)
        {
            RaidenImage2.Visibility = Visibility.Visible;
            if (check)
            {
                if (RaidenImage1.IsVisible == true) winRaiden = true;
                else
                {
                    win(); 
                }

                check = false;
            }
            else
            {
                RaidenImage2.Visibility = Visibility.Visible;
                check = true;
            }
        }

        private void win()
        {
            if (winXiao)
            {
                if (winKazuha)
                {
                    if (winWanderer)
                    {
                        if (winVenti)
                        {
                            if (winYae)
                            {
                                if (winRaiden)
                                {
                                    if (winLisa)
                                    {
                                        if (winKequing)
                                        {

                                        }
                                        KequingImage2.Visibility = Visibility.Hidden;
                                        KequingImage1.Visibility = Visibility.Hidden;
                                    }
                                    KequingImage2.Visibility = Visibility.Hidden;
                                    KequingImage1.Visibility = Visibility.Hidden;
                                    LisaImage1.Visibility = Visibility.Hidden;
                                    LisaImage2.Visibility = Visibility.Hidden;
                                }
                                KequingImage2.Visibility = Visibility.Hidden;
                                KequingImage1.Visibility = Visibility.Hidden;
                                LisaImage1.Visibility = Visibility.Hidden;
                                LisaImage2.Visibility = Visibility.Hidden;
                                RaidenImage1.Visibility = Visibility.Hidden;
                                RaidenImage2.Visibility = Visibility.Hidden;
                            }
                            KequingImage2.Visibility = Visibility.Hidden;
                            KequingImage1.Visibility = Visibility.Hidden;
                            LisaImage1.Visibility = Visibility.Hidden;
                            LisaImage2.Visibility = Visibility.Hidden;
                            RaidenImage1.Visibility = Visibility.Hidden;
                            RaidenImage2.Visibility = Visibility.Hidden;
                            YaeMikoImage1.Visibility = Visibility.Hidden;
                            YaeMikoImage2.Visibility = Visibility.Hidden;
                        }
                        KequingImage2.Visibility = Visibility.Hidden;
                        KequingImage1.Visibility = Visibility.Hidden;
                        LisaImage1.Visibility = Visibility.Hidden;
                        LisaImage2.Visibility = Visibility.Hidden;
                        RaidenImage1.Visibility = Visibility.Hidden;
                        RaidenImage2.Visibility = Visibility.Hidden;
                        YaeMikoImage1.Visibility = Visibility.Hidden;
                        YaeMikoImage2.Visibility = Visibility.Hidden;
                        VentiImage1.Visibility = Visibility.Hidden;
                        VentiImage2.Visibility = Visibility.Hidden;
                    }
                    KequingImage2.Visibility = Visibility.Hidden;
                    KequingImage1.Visibility = Visibility.Hidden;
                    LisaImage1.Visibility = Visibility.Hidden;
                    LisaImage2.Visibility = Visibility.Hidden;
                    RaidenImage1.Visibility = Visibility.Hidden;
                    RaidenImage2.Visibility = Visibility.Hidden;
                    YaeMikoImage1.Visibility = Visibility.Hidden;
                    YaeMikoImage2.Visibility = Visibility.Hidden;
                    VentiImage1.Visibility = Visibility.Hidden;
                    VentiImage2.Visibility = Visibility.Hidden;
                    WandererImage1.Visibility = Visibility.Hidden;
                    WandererImage2.Visibility = Visibility.Hidden;
                }
                KequingImage2.Visibility = Visibility.Hidden;
                KequingImage1.Visibility = Visibility.Hidden;
                LisaImage1.Visibility = Visibility.Hidden;
                LisaImage2.Visibility = Visibility.Hidden;
                RaidenImage1.Visibility = Visibility.Hidden;
                RaidenImage2.Visibility = Visibility.Hidden;
                YaeMikoImage1.Visibility = Visibility.Hidden;
                YaeMikoImage2.Visibility = Visibility.Hidden;
                VentiImage1.Visibility = Visibility.Hidden;
                VentiImage2.Visibility = Visibility.Hidden;
                WandererImage1.Visibility = Visibility.Hidden;
                WandererImage2.Visibility = Visibility.Hidden;
                KazuhaImage1.Visibility = Visibility.Hidden;
                KazuhaImage2.Visibility = Visibility.Hidden;
            }

            else if (winKazuha)
            {
                if (winWanderer)
                {
                    if (winVenti)
                    {
                        if (winYae)
                        {
                            if (winLisa)
                            {
                                if (winRaiden)
                                {
                                    if (winKequing)
                                    {
                                        XiaoImage1.Visibility = Visibility.Hidden;
                                        XiaoImage2.Visibility = Visibility.Hidden;
                                    }
                                    XiaoImage1.Visibility = Visibility.Hidden;
                                    XiaoImage2.Visibility = Visibility.Hidden;
                                    KequingImage2.Visibility = Visibility.Hidden;
                                    KequingImage1.Visibility = Visibility.Hidden;
                                }
                                XiaoImage1.Visibility = Visibility.Hidden;
                                XiaoImage2.Visibility = Visibility.Hidden;
                                KequingImage2.Visibility = Visibility.Hidden;
                                KequingImage1.Visibility = Visibility.Hidden;
                                RaidenImage1.Visibility = Visibility.Hidden;
                                RaidenImage2.Visibility = Visibility.Hidden;
                            }
                            XiaoImage1.Visibility = Visibility.Hidden;
                            XiaoImage2.Visibility = Visibility.Hidden;
                            KequingImage2.Visibility = Visibility.Hidden;
                            KequingImage1.Visibility = Visibility.Hidden;
                            RaidenImage1.Visibility = Visibility.Hidden;
                            RaidenImage2.Visibility = Visibility.Hidden;
                            LisaImage1.Visibility = Visibility.Hidden;
                            LisaImage2.Visibility = Visibility.Hidden;
                        }
                        XiaoImage1.Visibility = Visibility.Hidden;
                        XiaoImage2.Visibility = Visibility.Hidden;
                        KequingImage2.Visibility = Visibility.Hidden;
                        KequingImage1.Visibility = Visibility.Hidden;
                        RaidenImage1.Visibility = Visibility.Hidden;
                        RaidenImage2.Visibility = Visibility.Hidden;
                        LisaImage1.Visibility = Visibility.Hidden;
                        LisaImage2.Visibility = Visibility.Hidden;
                        YaeMikoImage1.Visibility = Visibility.Hidden;
                        YaeMikoImage2.Visibility = Visibility.Hidden;
                    }
                    XiaoImage1.Visibility = Visibility.Hidden;
                    XiaoImage2.Visibility = Visibility.Hidden;
                    KequingImage2.Visibility = Visibility.Hidden;
                    KequingImage1.Visibility = Visibility.Hidden;
                    RaidenImage1.Visibility = Visibility.Hidden;
                    RaidenImage2.Visibility = Visibility.Hidden;
                    LisaImage1.Visibility = Visibility.Hidden;
                    LisaImage2.Visibility = Visibility.Hidden;
                    YaeMikoImage1.Visibility = Visibility.Hidden;
                    YaeMikoImage2.Visibility = Visibility.Hidden;
                    VentiImage1.Visibility = Visibility.Hidden;
                    VentiImage2.Visibility = Visibility.Hidden;
                }
                XiaoImage1.Visibility = Visibility.Hidden;
                XiaoImage2.Visibility = Visibility.Hidden;
                KequingImage2.Visibility = Visibility.Hidden;
                KequingImage1.Visibility = Visibility.Hidden;
                RaidenImage1.Visibility = Visibility.Hidden;
                RaidenImage2.Visibility = Visibility.Hidden;
                LisaImage1.Visibility = Visibility.Hidden;
                LisaImage2.Visibility = Visibility.Hidden;
                YaeMikoImage1.Visibility = Visibility.Hidden;
                YaeMikoImage2.Visibility = Visibility.Hidden;
                VentiImage1.Visibility = Visibility.Hidden;
                VentiImage2.Visibility = Visibility.Hidden;
                WandererImage1.Visibility = Visibility.Hidden;
                WandererImage2.Visibility = Visibility.Hidden;
            }

            else if (winWanderer)
            {
                if (winVenti)
                {
                    if (winYae)
                    {
                        if (winLisa)
                        {
                            if (winRaiden)
                            {
                                if (winKequing)
                                {
                                    XiaoImage1.Visibility = Visibility.Hidden;
                                    XiaoImage2.Visibility = Visibility.Hidden;
                                    KazuhaImage1.Visibility = Visibility.Hidden;
                                    KazuhaImage2.Visibility = Visibility.Hidden;
                                }
                                XiaoImage1.Visibility = Visibility.Hidden;
                                XiaoImage2.Visibility = Visibility.Hidden;
                                KazuhaImage1.Visibility = Visibility.Hidden;
                                KazuhaImage2.Visibility = Visibility.Hidden;
                                KequingImage2.Visibility = Visibility.Hidden;
                                KequingImage1.Visibility = Visibility.Hidden;
                            }
                            XiaoImage1.Visibility = Visibility.Hidden;
                            XiaoImage2.Visibility = Visibility.Hidden;
                            KazuhaImage1.Visibility = Visibility.Hidden;
                            KazuhaImage2.Visibility = Visibility.Hidden;
                            KequingImage2.Visibility = Visibility.Hidden;
                            KequingImage1.Visibility = Visibility.Hidden;
                            RaidenImage1.Visibility = Visibility.Hidden;
                            RaidenImage2.Visibility = Visibility.Hidden;
                        }
                        XiaoImage1.Visibility = Visibility.Hidden;
                        XiaoImage2.Visibility = Visibility.Hidden;
                        KazuhaImage1.Visibility = Visibility.Hidden;
                        KazuhaImage2.Visibility = Visibility.Hidden;
                        KequingImage2.Visibility = Visibility.Hidden;
                        KequingImage1.Visibility = Visibility.Hidden;
                        RaidenImage1.Visibility = Visibility.Hidden;
                        RaidenImage2.Visibility = Visibility.Hidden;
                        LisaImage1.Visibility = Visibility.Hidden;
                        LisaImage2.Visibility = Visibility.Hidden;
                    }
                    XiaoImage1.Visibility = Visibility.Hidden;
                    XiaoImage2.Visibility = Visibility.Hidden;
                    KazuhaImage1.Visibility = Visibility.Hidden;
                    KazuhaImage2.Visibility = Visibility.Hidden;
                    KequingImage2.Visibility = Visibility.Hidden;
                    KequingImage1.Visibility = Visibility.Hidden;
                    RaidenImage1.Visibility = Visibility.Hidden;
                    RaidenImage2.Visibility = Visibility.Hidden;
                    LisaImage1.Visibility = Visibility.Hidden;
                    LisaImage2.Visibility = Visibility.Hidden;
                    YaeMikoImage1.Visibility = Visibility.Hidden;
                    YaeMikoImage2.Visibility = Visibility.Hidden;
                }
                XiaoImage1.Visibility = Visibility.Hidden;
                XiaoImage2.Visibility = Visibility.Hidden;
                KazuhaImage1.Visibility = Visibility.Hidden;
                KazuhaImage2.Visibility = Visibility.Hidden;
                KequingImage2.Visibility = Visibility.Hidden;
                KequingImage1.Visibility = Visibility.Hidden;
                RaidenImage1.Visibility = Visibility.Hidden;
                RaidenImage2.Visibility = Visibility.Hidden;
                LisaImage1.Visibility = Visibility.Hidden;
                LisaImage2.Visibility = Visibility.Hidden;
                YaeMikoImage1.Visibility = Visibility.Hidden;
                YaeMikoImage2.Visibility = Visibility.Hidden;
                VentiImage1.Visibility = Visibility.Hidden;
                VentiImage2.Visibility = Visibility.Hidden;
            }

            else if (winVenti)
            {
                if (winYae)
                {
                    if (winLisa)
                    {
                        if (winRaiden)
                        {
                            if (winKequing)
                            {
                                XiaoImage1.Visibility = Visibility.Hidden;
                                XiaoImage2.Visibility = Visibility.Hidden;
                                KazuhaImage1.Visibility = Visibility.Hidden;
                                KazuhaImage2.Visibility = Visibility.Hidden;
                                WandererImage1.Visibility = Visibility.Hidden;
                                WandererImage2.Visibility = Visibility.Hidden;
                            }
                            XiaoImage1.Visibility = Visibility.Hidden;
                            XiaoImage2.Visibility = Visibility.Hidden;
                            KazuhaImage1.Visibility = Visibility.Hidden;
                            KazuhaImage2.Visibility = Visibility.Hidden;
                            WandererImage1.Visibility = Visibility.Hidden;
                            WandererImage2.Visibility = Visibility.Hidden;
                            KequingImage2.Visibility = Visibility.Hidden;
                            KequingImage1.Visibility = Visibility.Hidden;
                        }
                        XiaoImage1.Visibility = Visibility.Hidden;
                        XiaoImage2.Visibility = Visibility.Hidden;
                        KazuhaImage1.Visibility = Visibility.Hidden;
                        KazuhaImage2.Visibility = Visibility.Hidden;
                        WandererImage1.Visibility = Visibility.Hidden;
                        WandererImage2.Visibility = Visibility.Hidden;
                        KequingImage2.Visibility = Visibility.Hidden;
                        KequingImage1.Visibility = Visibility.Hidden;
                        RaidenImage1.Visibility = Visibility.Hidden;
                        RaidenImage2.Visibility = Visibility.Hidden;
                    }
                    XiaoImage1.Visibility = Visibility.Hidden;
                    XiaoImage2.Visibility = Visibility.Hidden;
                    KazuhaImage1.Visibility = Visibility.Hidden;
                    KazuhaImage2.Visibility = Visibility.Hidden;
                    WandererImage1.Visibility = Visibility.Hidden;
                    WandererImage2.Visibility = Visibility.Hidden;
                    KequingImage2.Visibility = Visibility.Hidden;
                    KequingImage1.Visibility = Visibility.Hidden;
                    RaidenImage1.Visibility = Visibility.Hidden;
                    RaidenImage2.Visibility = Visibility.Hidden;
                    LisaImage1.Visibility = Visibility.Hidden;
                    LisaImage2.Visibility = Visibility.Hidden;
                }
                XiaoImage1.Visibility = Visibility.Hidden;
                XiaoImage2.Visibility = Visibility.Hidden;
                KazuhaImage1.Visibility = Visibility.Hidden;
                KazuhaImage2.Visibility = Visibility.Hidden;
                WandererImage1.Visibility = Visibility.Hidden;
                WandererImage2.Visibility = Visibility.Hidden;
                KequingImage2.Visibility = Visibility.Hidden;
                KequingImage1.Visibility = Visibility.Hidden;
                RaidenImage1.Visibility = Visibility.Hidden;
                RaidenImage2.Visibility = Visibility.Hidden;
                LisaImage1.Visibility = Visibility.Hidden;
                LisaImage2.Visibility = Visibility.Hidden;
                YaeMikoImage1.Visibility = Visibility.Hidden;
                YaeMikoImage2.Visibility = Visibility.Hidden;
            }

            else if (winYae)
            {
                if (winLisa)
                {
                    if (winRaiden)
                    {
                        if (winKequing)
                        {
                            XiaoImage1.Visibility = Visibility.Hidden;
                            XiaoImage2.Visibility = Visibility.Hidden;
                            KazuhaImage1.Visibility = Visibility.Hidden;
                            KazuhaImage2.Visibility = Visibility.Hidden;
                            WandererImage1.Visibility = Visibility.Hidden;
                            WandererImage2.Visibility = Visibility.Hidden;
                            VentiImage1.Visibility = Visibility.Hidden;
                            VentiImage2.Visibility = Visibility.Hidden;
                        }
                        XiaoImage1.Visibility = Visibility.Hidden;
                        XiaoImage2.Visibility = Visibility.Hidden;
                        KazuhaImage1.Visibility = Visibility.Hidden;
                        KazuhaImage2.Visibility = Visibility.Hidden;
                        WandererImage1.Visibility = Visibility.Hidden;
                        WandererImage2.Visibility = Visibility.Hidden;
                        VentiImage1.Visibility = Visibility.Hidden;
                        VentiImage2.Visibility = Visibility.Hidden;
                        KequingImage2.Visibility = Visibility.Hidden;
                        KequingImage1.Visibility = Visibility.Hidden;
                    }
                    XiaoImage1.Visibility = Visibility.Hidden;
                    XiaoImage2.Visibility = Visibility.Hidden;
                    KazuhaImage1.Visibility = Visibility.Hidden;
                    KazuhaImage2.Visibility = Visibility.Hidden;
                    WandererImage1.Visibility = Visibility.Hidden;
                    WandererImage2.Visibility = Visibility.Hidden;
                    VentiImage1.Visibility = Visibility.Hidden;
                    VentiImage2.Visibility = Visibility.Hidden;
                    KequingImage2.Visibility = Visibility.Hidden;
                    KequingImage1.Visibility = Visibility.Hidden;
                    RaidenImage1.Visibility = Visibility.Hidden;
                    RaidenImage2.Visibility = Visibility.Hidden;
                }
                XiaoImage1.Visibility = Visibility.Hidden;
                XiaoImage2.Visibility = Visibility.Hidden;
                KazuhaImage1.Visibility = Visibility.Hidden;
                KazuhaImage2.Visibility = Visibility.Hidden;
                WandererImage1.Visibility = Visibility.Hidden;
                WandererImage2.Visibility = Visibility.Hidden;
                VentiImage1.Visibility = Visibility.Hidden;
                VentiImage2.Visibility = Visibility.Hidden;
                KequingImage2.Visibility = Visibility.Hidden;
                KequingImage1.Visibility = Visibility.Hidden;
                RaidenImage1.Visibility = Visibility.Hidden;
                RaidenImage2.Visibility = Visibility.Hidden;
                LisaImage1.Visibility = Visibility.Hidden;
                LisaImage2.Visibility = Visibility.Hidden;
            }

            else if (winLisa)
            {
                if (winRaiden)
                {
                    if (winKequing)
                    {
                        XiaoImage1.Visibility = Visibility.Hidden;
                        XiaoImage2.Visibility = Visibility.Hidden;
                        KazuhaImage1.Visibility = Visibility.Hidden;
                        KazuhaImage2.Visibility = Visibility.Hidden;
                        WandererImage1.Visibility = Visibility.Hidden;
                        WandererImage2.Visibility = Visibility.Hidden;
                        VentiImage1.Visibility = Visibility.Hidden;
                        VentiImage2.Visibility = Visibility.Hidden;
                        YaeMikoImage1.Visibility = Visibility.Hidden;
                        YaeMikoImage2.Visibility = Visibility.Hidden;
                    }
                    XiaoImage1.Visibility = Visibility.Hidden;
                    XiaoImage2.Visibility = Visibility.Hidden;
                    KazuhaImage1.Visibility = Visibility.Hidden;
                    KazuhaImage2.Visibility = Visibility.Hidden;
                    WandererImage1.Visibility = Visibility.Hidden;
                    WandererImage2.Visibility = Visibility.Hidden;
                    VentiImage1.Visibility = Visibility.Hidden;
                    VentiImage2.Visibility = Visibility.Hidden;
                    YaeMikoImage1.Visibility = Visibility.Hidden;
                    YaeMikoImage2.Visibility = Visibility.Hidden;
                    KequingImage2.Visibility = Visibility.Hidden;
                    KequingImage1.Visibility = Visibility.Hidden;
                }
                XiaoImage1.Visibility = Visibility.Hidden;
                XiaoImage2.Visibility = Visibility.Hidden;
                KazuhaImage1.Visibility = Visibility.Hidden;
                KazuhaImage2.Visibility = Visibility.Hidden;
                WandererImage1.Visibility = Visibility.Hidden;
                WandererImage2.Visibility = Visibility.Hidden;
                VentiImage1.Visibility = Visibility.Hidden;
                VentiImage2.Visibility = Visibility.Hidden;
                YaeMikoImage1.Visibility = Visibility.Hidden;
                YaeMikoImage2.Visibility = Visibility.Hidden;
                KequingImage2.Visibility = Visibility.Hidden;
                KequingImage1.Visibility = Visibility.Hidden;
                RaidenImage1.Visibility = Visibility.Hidden;
                RaidenImage2.Visibility = Visibility.Hidden;
            }

            else if (winRaiden)
            {
                if (winKequing)
                {
                    XiaoImage1.Visibility = Visibility.Hidden;
                    XiaoImage2.Visibility = Visibility.Hidden;
                    KazuhaImage1.Visibility = Visibility.Hidden;
                    KazuhaImage2.Visibility = Visibility.Hidden;
                    VentiImage1.Visibility = Visibility.Hidden;
                    VentiImage2.Visibility = Visibility.Hidden;
                    YaeMikoImage1.Visibility = Visibility.Hidden;
                    YaeMikoImage2.Visibility = Visibility.Hidden;
                    LisaImage1.Visibility = Visibility.Hidden;
                    LisaImage2.Visibility = Visibility.Hidden;
                    WandererImage1.Visibility = Visibility.Hidden;
                    WandererImage2.Visibility = Visibility.Hidden;
                }
                XiaoImage1.Visibility = Visibility.Hidden;
                XiaoImage2.Visibility = Visibility.Hidden;
                KazuhaImage1.Visibility = Visibility.Hidden;
                KazuhaImage2.Visibility = Visibility.Hidden;
                VentiImage1.Visibility = Visibility.Hidden;
                VentiImage2.Visibility = Visibility.Hidden;
                KequingImage1.Visibility = Visibility.Hidden;
                KequingImage2.Visibility = Visibility.Hidden;
                YaeMikoImage1.Visibility = Visibility.Hidden;
                YaeMikoImage2.Visibility = Visibility.Hidden;
                LisaImage1.Visibility = Visibility.Hidden;
                LisaImage2.Visibility = Visibility.Hidden;
                WandererImage1.Visibility = Visibility.Hidden;
                WandererImage2.Visibility = Visibility.Hidden;
            }

            else if (winKequing)
            {
                XiaoImage1.Visibility = Visibility.Hidden;
                XiaoImage2.Visibility = Visibility.Hidden;
                KazuhaImage1.Visibility = Visibility.Hidden;
                KazuhaImage2.Visibility = Visibility.Hidden;
                VentiImage1.Visibility = Visibility.Hidden;
                VentiImage2.Visibility = Visibility.Hidden;
                RaidenImage1.Visibility = Visibility.Hidden;
                RaidenImage2.Visibility = Visibility.Hidden;
                YaeMikoImage1.Visibility = Visibility.Hidden;
                YaeMikoImage2.Visibility = Visibility.Hidden;
                LisaImage1.Visibility = Visibility.Hidden;
                LisaImage2.Visibility = Visibility.Hidden;
                WandererImage1.Visibility = Visibility.Hidden;
                WandererImage2.Visibility = Visibility.Hidden;
            }
            else
            {
                XiaoImage1.Visibility = Visibility.Hidden;
                XiaoImage2.Visibility = Visibility.Hidden;
                KazuhaImage1.Visibility = Visibility.Hidden;
                KazuhaImage2.Visibility = Visibility.Hidden;
                VentiImage1.Visibility = Visibility.Hidden;
                VentiImage2.Visibility = Visibility.Hidden;
                RaidenImage1.Visibility = Visibility.Hidden;
                RaidenImage2.Visibility = Visibility.Hidden;
                YaeMikoImage1.Visibility = Visibility.Hidden;
                YaeMikoImage2.Visibility = Visibility.Hidden;
                LisaImage1.Visibility = Visibility.Hidden;
                LisaImage2.Visibility = Visibility.Hidden;
                WandererImage1.Visibility = Visibility.Hidden;
                WandererImage2.Visibility = Visibility.Hidden;
                KequingImage2.Visibility = Visibility.Hidden;
                KequingImage1.Visibility = Visibility.Hidden;
            }
        }
    }
}
