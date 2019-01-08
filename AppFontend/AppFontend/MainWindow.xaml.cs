using AppFontend.Models;
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
using AppFontend.BUS;

namespace AppFontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CourseBUS.Courses_Name();
            //// Test Composite design pattern
            //Manager mn1 = new Manager("mn1111", "02121212", "Long An", "mn1@gmail.com");
            //Manager mn2 = new Manager("mn2222", "03232323", "Ho Chi Minh", "mn2@gmail.com");

            //Teacher tc1 = new Teacher("tc1111", "02121212", "Long An", "tc1@gmail.com");
            //Teacher tc2 = new Teacher("tc2222", "02121212", "Long An", "tc1@gmail.com");
            //Teacher tc3 = new Teacher("tc3333", "02121212", "Long An", "tc1@gmail.com");

            //mn1.Add(tc1);
            //mn1.Add(tc2);
            //mn2.Add(tc3);
            //mn1.Add(mn2);

            //mn1.Display(1);
        }
    }
}
