
using Microsoft.Win32;
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
using BLL.Settings;
using BLL.Services;
using AutoMapper;
using BLL.DTO;

namespace CarsPriceListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ItemsService items;
        public MainWindow()
        {
            InitializeComponent();
            AutoMapperConfig.Initialize();

        }
        public MainWindow(ItemsService items)
        {
            this.items = items;
            InitializeComponent();
            ListView();
        }

        private void button_Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\KamaletdinovaL\Documents\FilesForPriceList";
            openFileDialog.Filter = "Data files (*.xml;*.bin)|*.xml;*.bin|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            items = new ItemsService(openFileDialog.FileName);
            try { listBox.ItemsSource = items.GetAll(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void ListView()
        {
            listBox.ItemsSource = items.GetAll();
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            items.Delete(listBox.SelectedItem as ItemDTO);
            listBox.Items.Refresh();
        }

        private void button_Edit_Click(object sender, RoutedEventArgs e)
        {
            Window window = new WriteEditWindow(listBox.SelectedItem as ItemDTO, items);
            window.ShowDialog();
            this.Hide();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window window = new WriteEditWindow();
            window.ShowDialog();
            this.Hide();
        }
    }
}
