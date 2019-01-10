using AppFontend.BUS;
using AppFontend.DTO;
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

namespace AppFontend.Views.UC_Views
{
    /// <summary>
    /// Interaction logic for QuanLyKhoaHoc.xaml
    /// </summary>
    public partial class QuanLyKhoaHoc : UserControl
    {
        public QuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CourseBUS courseBUS = new CourseBUS();
            var course = await courseBUS.get_Course();
            List<COURSE> collection = new List<COURSE>((IEnumerable<COURSE>)course);
            lvDanhSachDay.ItemsSource = collection;
        }
    }
}
