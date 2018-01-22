using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.DTO;
using BLL.Services;

namespace CarsPriceListWindowsFormsApp
{
    /// <summary>
    /// view for main form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        /// <summary>
        /// The items
        /// </summary>
        ItemsService items;
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            BLL.Settings.AutoMapperConfig.Initialize();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        public Form1(ItemsService items)
        {
            this.items = items;
            InitializeComponent();
            ListView();
        }

        /// <summary>
        /// Handles the Click event of the OpenFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\KamaletdinovaL\Documents\FilesForPriceList";
            openFileDialog.Filter = "Data files (*.xml;*.bin)|*.xml;*.bin|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            items = new ItemsService(openFileDialog.FileName);
            try
            {
                this.ListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Add_new_item.Enabled = true;
            Edit.Enabled = true;
            Delete.Enabled = true;
            Update.Enabled = true;
            FormatConversion.Enabled = true;
        }
        /// <summary>
        /// ListViews this instance.
        /// </summary>
        public void ListView()
        {
            listBox.DataSource =items.GetAll(); 
        }
        /// <summary>
        /// Handles the Click event of the Add_new_item control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Add_new_item_Click(object sender, EventArgs e)
        {
            Form window = new EditForm(items);
            window.Show();
            this.Hide();
        }

        /// <summary>
        /// Handles the Click event of the Delete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                items.Delete(listBox.SelectedItem as ItemDTO);
                listBox.DataSource=null;
                this.ListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                items.Save(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Edit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Edit_Click(object sender, EventArgs e)
        {
            Form window = new EditForm(listBox.SelectedItem as ItemDTO, items);
            window.Show();
            this.Hide();
        }
        /// <summary>
        /// Handles the Click event of the FormatConversion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FormatConversion_Click(object sender, EventArgs e)
        {
            try
            {
                items.Save(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the FormClosing event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


    }
}
