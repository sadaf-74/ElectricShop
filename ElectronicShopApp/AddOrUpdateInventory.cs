using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicShopCodeFirstFromDB;
using EFControllerUtilities;

namespace ElectronicShopApp
{
    public partial class AddOrUpdateInventory : Form
    {
        public AddOrUpdateInventory()
        {
            InitializeComponent();

            this.Load += AddUpdateInventroy_Load;
            buttonAddInventory.Click += ButtonAddInventory_Click;
            buttonUpdateInventory.Click += ButtonUpdateInventory_Click;
            listBoxAddUpdateInventory.SelectedIndexChanged += (s, e) => InventorySelected();
        }

        /// <summary>
        /// This method is used to load data each time the form is shown.
        /// It reset text boxes and load listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUpdateInventroy_Load(object sender, EventArgs e)
        {
            listBoxAddUpdateInventory.DataSource =
                Controller<ElectronicShopEntities, Inventory>.SetBindingList();
            listBoxAddUpdateInventory.SelectedIndex = -1;
            textBoxCurrentManager.ResetText();
            textBoxNameManager.ResetText();
            textBoxQuantityManager.ResetText();
            textBoxTypeManager.ResetText();
            textBoxUnitPriceManager.ResetText();
            textBoxVoltageManager.ResetText();
            textBoxVersionManager.ResetText();

            foreach (var category in Controller<ElectronicShopEntities, Category>.GetEntities())
            {
                listBoxCategory.Items.Add(category);
            }
        }

        /// <summary>
        /// This method is used to fill text boxes with selected inventory
        /// </summary>
        private void InventorySelected()
        {

            if (!(listBoxAddUpdateInventory.SelectedItem is Inventory inventory))
                return;
            textBoxCurrentManager.Text = inventory.Current;
            textBoxNameManager.Text = inventory.Name;
            textBoxQuantityManager.Text = inventory.UnitInStock.ToString();
            textBoxTypeManager.Text = inventory.Type;
            textBoxUnitPriceManager.Text = inventory.UnitPrice.ToString();
            textBoxVoltageManager.Text = inventory.Voltage;
            textBoxVersionManager.Text = inventory.Version;

            for (int i = 0; i < listBoxCategory.Items.Count; i++)
            {
                if (inventory.CategoryId == (listBoxCategory.Items[i] as Category)?.CategoryId)
                {
                    listBoxCategory.SetSelected(i, true);
                }
            }
        }

        /// <summary>
        /// This method is used to add an inventory to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddInventory_Click(object sender, EventArgs e)
        {
            Category category = listBoxCategory.SelectedItem as Category;
            Inventory newInventory = new Inventory()
            {
                Name = textBoxNameManager.Text,
                Voltage = textBoxVoltageManager.Text,
                Version = textBoxVersionManager.Text,
                Type = textBoxTypeManager.Text,
                Current = textBoxCurrentManager.Text,
                UnitPrice = double.Parse(textBoxUnitPriceManager.Text),
                UnitInStock = int.Parse(textBoxQuantityManager.Text),
                CategoryId = category?.CategoryId,

            };

            if (Controller<ElectronicShopEntities, Inventory>.AddEntity(newInventory) == null)
            {
                MessageBox.Show("Error adding Inventory");
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// This method is used to update an inventory information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateInventory_Click(object sender, EventArgs e)
        {
            if (!(listBoxAddUpdateInventory.SelectedItem is Inventory inventory))
            {
                MessageBox.Show("Select inventory to be updated");
                return;
            }
            inventory.Current = textBoxCurrentManager.Text;
            inventory.Name = textBoxNameManager.Text;
            inventory.UnitPrice = double.Parse(textBoxUnitPriceManager.Text);
            inventory.UnitInStock = int.Parse(textBoxQuantityManager.Text);
            inventory.Voltage = textBoxVoltageManager.Text;
            inventory.Version = textBoxVersionManager.Text;
            inventory.Type = textBoxTypeManager.Text;
            Category category = listBoxCategory.SelectedItem as Category;
            inventory.CategoryId = category?.CategoryId;

            if (Controller<ElectronicShopEntities, Inventory>.UpdateEntity(inventory) == false)
            {
                MessageBox.Show("Error updating student");
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
