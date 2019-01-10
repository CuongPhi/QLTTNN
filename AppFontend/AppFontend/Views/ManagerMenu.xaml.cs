using AppFontend.BUS;
using AppFontend.DTO;
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
    /// Interaction logic for ManagerMenu.xaml
    /// </summary>
    public partial class ManagerMenu : Window
    {
        public ManagerMenu()
        {
            InitializeComponent();
            XemThongBao xemTB = new XemThongBao();
            Title.Text = "XEM THÔNG BÁO";
            mainView.Children.Add(xemTB);
         
        }
        
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mainView.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemThongBao":
                    XemThongBao xemTB = new XemThongBao();
                    Title.Text = "XEM THÔNG BÁO";
                    mainView.Children.Add(xemTB);
                    break;

                case "ItemVietThongBao":
                    VietThongBao vietTB = new VietThongBao();
                    Title.Text = "VIẾT THÔNG BÁO";
                    mainView.Children.Add(vietTB);
                    break;

                case "ItemQLGV":
                    QuanLyGiaoVien qlGV = new QuanLyGiaoVien();
                    Title.Text = "QUẢN LÝ GIÁO VIÊN";
                    mainView.Children.Add(qlGV);
                    break;

                case "ItemQLKhoaHoc":
                    QuanLyKhoaHoc qlKH = new QuanLyKhoaHoc();
                    Title.Text = "QUẢN LÝ KHÓA HỌC";
                    mainView.Children.Add(qlKH);
                    break;

                case "ItemDSDangKy":
                    XemDanhSachDangKy xemDS = new XemDanhSachDangKy();
                    Title.Text = "XEM DANH SÁCH SINH VIÊN ĐĂNG KÝ KHÓA HỌC";
                    mainView.Children.Add(xemDS);
                    break;
            }
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
