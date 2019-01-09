using AppFontend.Views.UC_Views;
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
using System.Windows.Shapes;

namespace AppFontend.Views
{
    /// <summary>
    /// Interaction logic for TeacherMenu.xaml
    /// </summary>
    public partial class TeacherMenu : Window
    {
        public TeacherMenu()
        {
            InitializeComponent();
            XemThongBao xemTB = new XemThongBao();
            mainView.Children.Add(xemTB);
            Title.Text = "XEM THÔNG BÁO";
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mainView.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemThongBao":
                    XemThongBao xemTB = new XemThongBao();
                    mainView.Children.Add(xemTB);
                    Title.Text = "XEM THÔNG BÁO";
                    break;
                case "ItemVietThongBao":
                    VietThongBao vietTB = new VietThongBao();
                    mainView.Children.Add(vietTB);
                    Title.Text = "VIẾT THÔNG BÁO";
                    break;
                case "ItemDanhSachDay":
                    CacLopDay cacLD = new CacLopDay();
                    mainView.Children.Add(cacLD);
                    Title.Text = "DANH SÁCH CÁC LỚP DẠY";
                    break;
            }
        }
    }
}
