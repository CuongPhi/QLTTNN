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
using AppFontend.BUS;

namespace AppFontend.Views
{
    /// <summary>
    /// Interaction logic for StudentMenu.xaml
    /// </summary>
    public partial class StudentMenu : Window
    {
        public StudentMenu()
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
                case "ItemDangKy":
                    DangKyMonHoc dangKy = new DangKyMonHoc();
                    mainView.Children.Add(dangKy);
                    Title.Text = "ĐĂNG KÝ MÔN HỌC";
                    break;
                case "ItemXemDSDK":
                    DanhSachMonDangKy dsMon = new DanhSachMonDangKy();
                    mainView.Children.Add(dsMon);
                    Title.Text = "XEM DANH SÁCH MÔN ĐĂNG KÝ";
                    break;
            }
        }
    }
}
