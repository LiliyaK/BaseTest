using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsPriceListWindowsFormsApp
{
    /// <summary>
    /// view for editing form 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EditForm : Form
    {
        /// <summary>
        /// The items
        /// </summary>
        IItemService items;
        /// <summary>
        /// Initializes a new instance of the <see cref="EditForm"/> class.
        /// </summary>
        /// <param name="items">The items.</param>
        public EditForm(IItemService items)
        {
            InitializeComponent();
            FormLabel.Text = "Add Record";
            this.items = items;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditForm"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="items">The items.</param>
        public EditForm(ItemDTO item, IItemService items)
        {
            InitializeComponent();
            this.items = items;
            textBox1.Text = item.Date.ToShortDateString().ToString();
            textBox2.Text = item.BrandName;
            textBox3.Text = item.Price.ToString();
            FormLabel.Text = "Edit Record";
            try
            {
                items.Delete(new ItemDTO(DateTime.ParseExact(textBox1.Text, "dd.MM.yyyy", null), textBox2.Text, Int32.Parse(textBox3.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the Save control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                items.Add(new ItemDTO(DateTime.ParseExact(textBox1.Text, "dd.MM.yyyy", null), textBox2.Text, Int32.Parse(textBox3.Text)));
                Form win = new Form1(items);
                win.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Handles the FormClosing event of the EditForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
