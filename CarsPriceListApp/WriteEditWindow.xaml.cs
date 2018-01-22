using BLL.DTO;
using BLL.Services;
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

namespace CarsPriceListApp
{
    /// <summary>
    /// Interaction logic for WriteEditWindow.xaml
    /// </summary>
    public partial class WriteEditWindow : Window
    {
        ItemsService items;
        public WriteEditWindow()
        { InitializeComponent(); }
        public WriteEditWindow(ItemDTO item, ItemsService items)
        {
            InitializeComponent();
            this.items = items;
            textBox1.Text = item.Date.ToShortDateString().ToString();
            textBox_2.Text = item.BrandName;
            textBox_3.Text = item.Price.ToString();
            items.Delete(new ItemDTO(DateTime.ParseExact(textBox1.Text, "dd.MM.yyyy", null), textBox_2.Text, Int32.Parse(textBox_3.Text)));
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new ItemDTO(DateTime.ParseExact(textBox1.Text, "dd.MM.yyyy", null), textBox_2.Text, Int32.Parse(textBox_3.Text)));
            Window win = new MainWindow(items);
            win.Show();
        }
    }
}
