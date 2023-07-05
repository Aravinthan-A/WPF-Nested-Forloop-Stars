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

namespace StarProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int x, y;
            int z = 6;
            for (x = 1; x <= z; x++)
            {
                for (y = 1; y <= z - x; y++)
                {
                    stringBuilder.Append(" ");
                }
                for (y = 1; y <= x; y++)
                {
                    stringBuilder.Append((char)(y + 64));
                }
                for (y = x - 1; y >= 1; y--)
                {
                    stringBuilder.Append((char)(y + 64));
                }
                stringBuilder.AppendLine();
            }
            MessageBox.Show(stringBuilder.ToString());
        }
    }
}

//            int x, y;
//            int z = 5;
//            for (x = z; x >= 1; x--)
//            {
//                for (y = x; y >= 1; y--)
//                {
//                    stringBuilder.Append((char)(y + 64));
//                }
//                stringBuilder.AppendLine("");
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            int a = 5;
//            for (x = 1; x <= a; x++)
//            {
//                for (y = a; y >= x; y--)
//                {
//                    stringBuilder.Append((char)(y + 64));
//                }
//                stringBuilder.AppendLine("");
//            }
//            MessageBox.Show(stringBuilder.ToString());  
//        }
//    }
//}

//            int x, y;
//            int a = 5;
//            for (x = a; x >= 1; x--)
//            {
//                for (y = a; y >= x; y--)
//                {
//                    stringBuilder.Append((char)(y + 64));
//                }
//                stringBuilder.AppendLine("");
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y, z;
//            int k = 5;
//            for (x = 1; x <= k; x++)
//            {
//                for (y = 1; y <= k - x; y++)
//                {
//                    stringBuilder.Append(" ");
//                }
//                for (z = 1; z <= x; z++)
//                {
//                    stringBuilder.Append((char)(x + 64));
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            int z = 5;
//            for (x = 1; x <= z; x++)
//            {
//                for (y = x; y <= z; y++)
//                {
//                    stringBuilder.Append((char)(y + 64));
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            int z = 5;
//            for (x = 1; x <= z; x++)
//            {
//                for (y = 1; y <= x; y++)
//                {
//                    stringBuilder.Append((char)(z - x + 1 + 64));
//                }
//                stringBuilder.AppendLine("");
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            int z = 5;
//            for (x = 1; x <= z; x++)
//            {
//                for (y = x; y <= z; y++)
//                {
//                    stringBuilder.Append((char)(x + 64));
//                }
//                stringBuilder.AppendLine("");
//            }
//            MessageBox.Show(stringBuilder.ToString());  
//        }
//    }
//}

//            int x, y;
//            int z = 5;
//            for (x = 1; x <= z; x++)
//            {
//                for (y = 1; y <= x; y++)
//                {
//                    stringBuilder.Append((char)(x + 64));
//                }
//                stringBuilder.AppendLine("");
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            for (x = 7; x >= 1; x -= 2)
//            {
//                for (y = 1; y <= x; y++)
//                {
//                    stringBuilder.Append(y);
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            for (x = 7; x >= 1; x -= 2)
//            {
//                for (y = 1; y <= x; y++)
//                {
//                    stringBuilder.Append(y);
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}


//            int x, y;
//            for (x = 6; x >= 1; x--)
//            {
//                for (y = x; y >= 1; y--)
//                {
//                    stringBuilder.Append(y);
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            for (x = 1; x <= 5; x++)
//            {
//                for (y = 5; y >= x; y--)
//                {
//                    stringBuilder.Append(x);
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            for (x = 5; x >= 1; x--)
//            {
//                for (y = 1; y <= x; y++)
//                {
//                    stringBuilder.Append(x);
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());  
//        }
//    }
//}

//            int x, y;
//            for (x = 5; x >= 1; x--)
//            {
//                for (y = 5; y >= x; y--)
//                {
//                    stringBuilder.Append(x);
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            for (x = 1; x <= 5; x++)
//            {
//                for (y = 1; y <= x; y++)
//                {
//                    stringBuilder.Append(x);
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());
//        }
//    }
//}

//            int x, y;
//            for (x = 1; x <= 5; x++)
//            {
//                for (y = x; y <= 5; y++)
//                {
//                    stringBuilder.Append(y);
//                }
//                stringBuilder.AppendLine();
//            }
//            MessageBox.Show(stringBuilder.ToString());  
//        }
//    }
//}

//        int x, y;
//        for (x = 5; x >= 1; x--)
//        {
//            for (y = x; y <= 5; y++)
//            {
//                stringBuilder.Append(y);
//            }
//            stringBuilder.AppendLine();
//        }
//        MessageBox.Show(stringBuilder.ToString());  
//    }
//}

//        int x, y;
//        for (x = 5; x >= 1; x--)
//        {
//            for (y = 1; y <= x; y++)
//            {
//                stringBuilder.Append(y);
//            }
//            stringBuilder.AppendLine();
//        }
//        MessageBox.Show(stringBuilder.ToString());
//    }
//}

//    //        int x, y;
//    //        for (x = 1; x <= 5; x++)
//        {
//            for (y = 1; y <= x; y++)
//            {
//                stringBuilder.Append(y);
//            }
//            stringBuilder.AppendLine();
//        }
//        MessageBox.Show(stringBuilder.ToString());
//    }
//}

//        int x, y;
//        for (x = 1; x <= 5; x++)
//        {
//            for (y = 1; y <= x; y++)
//            {
//                if (y == 1 || y == x || x == 5)
//                {
//                    stringBuilder.Append("*");
//                }
//                else
//                {
//                    stringBuilder.Append(" ");
//                }
//            }
//            stringBuilder.AppendLine();
//        }
//        MessageBox.Show(stringBuilder.ToString());
//    }
//}
//        StringBuilder stringBuilder = new StringBuilder();
//        int x, y;
//        for (x = 1; x <= 5; x++)
//        {
//            for (y = 1; y <= 5; y++)
//            {
//                stringBuilder.Append("*");
//            }
//            stringBuilder.AppendLine();
//        }
//        MessageBox.Show(stringBuilder.ToString());  
//    }
//}

//        int x, y;
//        for (x = 1; x <= 5; x++)
//        {
//            for (y = x; y < 5; y++)
//            {
//                stringBuilder.Append(" ");
//            }
//            for (y = 1; y <= (2 * x - 1); y++)
//            {
//                if (x == 5 || y == 1 || y == (2 * x - 1))
//                {
//                    stringBuilder.Append("*");
//                }
//                else
//                {
//                    stringBuilder.Append(" ");
//                }
//            }
//            stringBuilder.AppendLine();
//        }
//        MessageBox.Show(stringBuilder.ToString());    
//    }
//}

//int x, y, z;
//for (x = 5; x >= 1; x--)
//{
//    for (y = 5; y > x; y--)
//    {
//        stringBuilder.Append(" ");
//    }
//    for (z = 1; z < (x * 2); z++)
//    {
//        stringBuilder.Append("*");
//    }
//    stringBuilder.AppendLine();
//}
//MessageBox.Show(stringBuilder.ToString());  




//int x, y, z;
//for (x = 1; x <= 5; x++)
//{
//    for (y = x; y < 5; y++)
//    {
//        stringBuilder.Append(" ");
//    }
//    for (z = 1; z < (x * 2); z++)
//    {
//        stringBuilder.Append("*");
//    }
//    stringBuilder.AppendLine();
//}
//MessageBox.Show(stringBuilder.ToString());




//int x, y, z;
//for (x = 5; x >= 1; x--)
//{
//    for (y = 5; y > x; y--)
//    {
//        stringBuilder.Append(" ");
//    }
//    for (z = 1; z <= x; z++)
//    {
//        stringBuilder.Append("*");
//    }
//    stringBuilder.AppendLine();
//}
//MessageBox.Show(stringBuilder.ToString());





//int x, y;
//for (x = 5; x >= 1; x--)
//{
//    for (y = 1; y <= x; y++)
//    {
//        stringBuilder.Append("*");
//    }
//    stringBuilder.AppendLine();
//}
//MessageBox.Show(stringBuilder.ToString());

//        int x, y;
//        for (x = 1; x <= 6; x++)
//        {
//            for (y = 1; y <= x; y++)
//            {
//                stringBuilder.Append("*");
//            }
//            stringBuilder.AppendLine();
//        }
//        MessageBox.Show(stringBuilder.ToString());
//    }
//}

//int x, y, z;
//for (x = 6; x >= 1; x--)
//{
//    for (y = 1; y < x; y++)
//    {
//        stringBuilder.Append(" ");
//    }
//    for (z = 6; z >= x; z--)
//    {
//        stringBuilder.Append("*");
//    }
//    stringBuilder.AppendLine();
//}
//MessageBox.Show(stringBuilder.ToString());






