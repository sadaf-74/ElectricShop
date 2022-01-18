
namespace ElectronicShopApp
{
    partial class ElectronicShopMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAdministrator = new System.Windows.Forms.TabPage();
            this.labelVersion = new System.Windows.Forms.Label();
            this.listBoxVersion = new System.Windows.Forms.ListBox();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.buttonAddUpdateCustomer = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelSelectedItems = new System.Windows.Forms.Label();
            this.dataGridViewSelectedItems = new System.Windows.Forms.DataGridView();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.listBoxCurrent = new System.Windows.Forms.ListBox();
            this.labelCurent = new System.Windows.Forms.Label();
            this.listBoxVoltage = new System.Windows.Forms.ListBox();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabPageManager = new System.Windows.Forms.TabPage();
            this.buttonAddUpdateInventory = new System.Windows.Forms.Button();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.tabPageSalesOrder = new System.Windows.Forms.TabPage();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonDeleteAllOrders = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonOrderFilter = new System.Windows.Forms.Button();
            this.listBoxOrderInventory = new System.Windows.Forms.ListBox();
            this.listBoxOrderCustomer = new System.Windows.Forms.ListBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.tabPageDatabaseBackup = new System.Windows.Forms.TabPage();
            this.buttonRestoreXML = new System.Windows.Forms.Button();
            this.buttonBackupXML = new System.Windows.Forms.Button();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPageAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPageManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.tabPageSalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPageDatabaseBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAdministrator);
            this.tabControlMain.Controls.Add(this.tabPageManager);
            this.tabControlMain.Controls.Add(this.tabPageSalesOrder);
            this.tabControlMain.Controls.Add(this.tabPageDatabaseBackup);
            this.tabControlMain.Location = new System.Drawing.Point(29, 14);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1584, 1030);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageAdministrator
            // 
            this.tabPageAdministrator.AutoScroll = true;
            this.tabPageAdministrator.Controls.Add(this.labelVersion);
            this.tabPageAdministrator.Controls.Add(this.listBoxVersion);
            this.tabPageAdministrator.Controls.Add(this.buttonDeleteItem);
            this.tabPageAdministrator.Controls.Add(this.textBoxTotalPrice);
            this.tabPageAdministrator.Controls.Add(this.labelTotalPrice);
            this.tabPageAdministrator.Controls.Add(this.buttonOrder);
            this.tabPageAdministrator.Controls.Add(this.labelCustomer);
            this.tabPageAdministrator.Controls.Add(this.buttonAddUpdateCustomer);
            this.tabPageAdministrator.Controls.Add(this.labelQuantity);
            this.tabPageAdministrator.Controls.Add(this.textBoxQuantity);
            this.tabPageAdministrator.Controls.Add(this.labelSelectedItems);
            this.tabPageAdministrator.Controls.Add(this.dataGridViewSelectedItems);
            this.tabPageAdministrator.Controls.Add(this.buttonAddItem);
            this.tabPageAdministrator.Controls.Add(this.listBoxCurrent);
            this.tabPageAdministrator.Controls.Add(this.labelCurent);
            this.tabPageAdministrator.Controls.Add(this.listBoxVoltage);
            this.tabPageAdministrator.Controls.Add(this.labelVoltage);
            this.tabPageAdministrator.Controls.Add(this.labelType);
            this.tabPageAdministrator.Controls.Add(this.labelCategory);
            this.tabPageAdministrator.Controls.Add(this.listBoxType);
            this.tabPageAdministrator.Controls.Add(this.listBoxCategory);
            this.tabPageAdministrator.Controls.Add(this.dataGridViewCustomers);
            this.tabPageAdministrator.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdministrator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdministrator.Name = "tabPageAdministrator";
            this.tabPageAdministrator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdministrator.Size = new System.Drawing.Size(1576, 1001);
            this.tabPageAdministrator.TabIndex = 0;
            this.tabPageAdministrator.Text = "Administrator";
            this.tabPageAdministrator.UseVisualStyleBackColor = true;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(892, 330);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(56, 17);
            this.labelVersion.TabIndex = 23;
            this.labelVersion.Text = "Version";
            // 
            // listBoxVersion
            // 
            this.listBoxVersion.FormattingEnabled = true;
            this.listBoxVersion.ItemHeight = 16;
            this.listBoxVersion.Location = new System.Drawing.Point(888, 366);
            this.listBoxVersion.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVersion.Name = "listBoxVersion";
            this.listBoxVersion.Size = new System.Drawing.Size(159, 116);
            this.listBoxVersion.TabIndex = 22;
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(989, 533);
            this.buttonDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteItem.TabIndex = 21;
            this.buttonDeleteItem.Text = "Delelte Item";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(165, 848);
            this.textBoxTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxTotalPrice.TabIndex = 20;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(56, 852);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(88, 17);
            this.labelTotalPrice.TabIndex = 19;
            this.labelTotalPrice.Text = "Total Price =";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(848, 848);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(100, 28);
            this.buttonOrder.TabIndex = 18;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(56, 16);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(68, 17);
            this.labelCustomer.TabIndex = 17;
            this.labelCustomer.Text = "Customer";
            // 
            // buttonAddUpdateCustomer
            // 
            this.buttonAddUpdateCustomer.Location = new System.Drawing.Point(1171, 132);
            this.buttonAddUpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddUpdateCustomer.Name = "buttonAddUpdateCustomer";
            this.buttonAddUpdateCustomer.Size = new System.Drawing.Size(108, 76);
            this.buttonAddUpdateCustomer.TabIndex = 16;
            this.buttonAddUpdateCustomer.Text = "Add Or Update Customer";
            this.buttonAddUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(628, 539);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(61, 17);
            this.labelQuantity.TabIndex = 15;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(705, 533);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(132, 22);
            this.textBoxQuantity.TabIndex = 14;
            // 
            // labelSelectedItems
            // 
            this.labelSelectedItems.AutoSize = true;
            this.labelSelectedItems.Location = new System.Drawing.Point(56, 545);
            this.labelSelectedItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedItems.Name = "labelSelectedItems";
            this.labelSelectedItems.Size = new System.Drawing.Size(100, 17);
            this.labelSelectedItems.TabIndex = 13;
            this.labelSelectedItems.Text = "Selected Items";
            // 
            // dataGridViewSelectedItems
            // 
            this.dataGridViewSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedItems.Location = new System.Drawing.Point(56, 578);
            this.dataGridViewSelectedItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSelectedItems.Name = "dataGridViewSelectedItems";
            this.dataGridViewSelectedItems.RowHeadersWidth = 51;
            this.dataGridViewSelectedItems.Size = new System.Drawing.Size(1077, 251);
            this.dataGridViewSelectedItems.TabIndex = 12;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(873, 533);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(100, 28);
            this.buttonAddItem.TabIndex = 11;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // listBoxCurrent
            // 
            this.listBoxCurrent.FormattingEnabled = true;
            this.listBoxCurrent.ItemHeight = 16;
            this.listBoxCurrent.Location = new System.Drawing.Point(679, 366);
            this.listBoxCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCurrent.Name = "listBoxCurrent";
            this.listBoxCurrent.Size = new System.Drawing.Size(159, 116);
            this.listBoxCurrent.TabIndex = 8;
            // 
            // labelCurent
            // 
            this.labelCurent.AutoSize = true;
            this.labelCurent.Location = new System.Drawing.Point(675, 330);
            this.labelCurent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurent.Name = "labelCurent";
            this.labelCurent.Size = new System.Drawing.Size(55, 17);
            this.labelCurent.TabIndex = 7;
            this.labelCurent.Text = "Current";
            // 
            // listBoxVoltage
            // 
            this.listBoxVoltage.FormattingEnabled = true;
            this.listBoxVoltage.ItemHeight = 16;
            this.listBoxVoltage.Location = new System.Drawing.Point(475, 366);
            this.listBoxVoltage.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVoltage.Name = "listBoxVoltage";
            this.listBoxVoltage.Size = new System.Drawing.Size(159, 116);
            this.listBoxVoltage.TabIndex = 6;
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Location = new System.Drawing.Point(471, 330);
            this.labelVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(56, 17);
            this.labelVoltage.TabIndex = 5;
            this.labelVoltage.Text = "Voltage";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(264, 330);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 17);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Type";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(52, 330);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(65, 17);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category";
            // 
            // listBoxType
            // 
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 16;
            this.listBoxType.Location = new System.Drawing.Point(268, 366);
            this.listBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(159, 116);
            this.listBoxType.TabIndex = 2;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 16;
            this.listBoxCategory.Location = new System.Drawing.Point(56, 366);
            this.listBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(159, 116);
            this.listBoxCategory.TabIndex = 1;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(56, 48);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1077, 261);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // tabPageManager
            // 
            this.tabPageManager.AutoScroll = true;
            this.tabPageManager.Controls.Add(this.buttonAddUpdateInventory);
            this.tabPageManager.Controls.Add(this.dataGridViewInventory);
            this.tabPageManager.Location = new System.Drawing.Point(4, 25);
            this.tabPageManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageManager.Name = "tabPageManager";
            this.tabPageManager.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageManager.Size = new System.Drawing.Size(1576, 1001);
            this.tabPageManager.TabIndex = 1;
            this.tabPageManager.Text = "Manager";
            this.tabPageManager.UseVisualStyleBackColor = true;
            // 
            // buttonAddUpdateInventory
            // 
            this.buttonAddUpdateInventory.Location = new System.Drawing.Point(307, 363);
            this.buttonAddUpdateInventory.Name = "buttonAddUpdateInventory";
            this.buttonAddUpdateInventory.Size = new System.Drawing.Size(829, 61);
            this.buttonAddUpdateInventory.TabIndex = 29;
            this.buttonAddUpdateInventory.Text = "Add OR Update Inventory";
            this.buttonAddUpdateInventory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(45, 42);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(1415, 261);
            this.dataGridViewInventory.TabIndex = 0;
            // 
            // tabPageSalesOrder
            // 
            this.tabPageSalesOrder.AutoScroll = true;
            this.tabPageSalesOrder.Controls.Add(this.buttonClearFilter);
            this.tabPageSalesOrder.Controls.Add(this.buttonDeleteAllOrders);
            this.tabPageSalesOrder.Controls.Add(this.buttonDeleteOrder);
            this.tabPageSalesOrder.Controls.Add(this.buttonOrderFilter);
            this.tabPageSalesOrder.Controls.Add(this.listBoxOrderInventory);
            this.tabPageSalesOrder.Controls.Add(this.listBoxOrderCustomer);
            this.tabPageSalesOrder.Controls.Add(this.dataGridViewOrders);
            this.tabPageSalesOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageSalesOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSalesOrder.Name = "tabPageSalesOrder";
            this.tabPageSalesOrder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSalesOrder.Size = new System.Drawing.Size(1576, 1001);
            this.tabPageSalesOrder.TabIndex = 2;
            this.tabPageSalesOrder.Text = "Sales Order";
            this.tabPageSalesOrder.UseVisualStyleBackColor = true;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(1313, 249);
            this.buttonClearFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(139, 69);
            this.buttonClearFilter.TabIndex = 7;
            this.buttonClearFilter.Text = "Clear Filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAllOrders
            // 
            this.buttonDeleteAllOrders.Location = new System.Drawing.Point(1313, 153);
            this.buttonDeleteAllOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteAllOrders.Name = "buttonDeleteAllOrders";
            this.buttonDeleteAllOrders.Size = new System.Drawing.Size(139, 71);
            this.buttonDeleteAllOrders.TabIndex = 6;
            this.buttonDeleteAllOrders.Text = "Delete All Orders";
            this.buttonDeleteAllOrders.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(1313, 54);
            this.buttonDeleteOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(139, 66);
            this.buttonDeleteOrder.TabIndex = 5;
            this.buttonDeleteOrder.Text = "Delete Order";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // buttonOrderFilter
            // 
            this.buttonOrderFilter.Location = new System.Drawing.Point(792, 380);
            this.buttonOrderFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOrderFilter.Name = "buttonOrderFilter";
            this.buttonOrderFilter.Size = new System.Drawing.Size(152, 69);
            this.buttonOrderFilter.TabIndex = 4;
            this.buttonOrderFilter.Text = "Filter";
            this.buttonOrderFilter.UseVisualStyleBackColor = true;
            // 
            // listBoxOrderInventory
            // 
            this.listBoxOrderInventory.FormattingEnabled = true;
            this.listBoxOrderInventory.ItemHeight = 16;
            this.listBoxOrderInventory.Location = new System.Drawing.Point(339, 380);
            this.listBoxOrderInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxOrderInventory.Name = "listBoxOrderInventory";
            this.listBoxOrderInventory.Size = new System.Drawing.Size(405, 244);
            this.listBoxOrderInventory.TabIndex = 3;
            // 
            // listBoxOrderCustomer
            // 
            this.listBoxOrderCustomer.FormattingEnabled = true;
            this.listBoxOrderCustomer.ItemHeight = 16;
            this.listBoxOrderCustomer.Location = new System.Drawing.Point(41, 380);
            this.listBoxOrderCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxOrderCustomer.Name = "listBoxOrderCustomer";
            this.listBoxOrderCustomer.Size = new System.Drawing.Size(237, 244);
            this.listBoxOrderCustomer.TabIndex = 2;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(41, 33);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1240, 304);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // tabPageDatabaseBackup
            // 
            this.tabPageDatabaseBackup.AutoScroll = true;
            this.tabPageDatabaseBackup.Controls.Add(this.buttonRestoreXML);
            this.tabPageDatabaseBackup.Controls.Add(this.buttonBackupXML);
            this.tabPageDatabaseBackup.Location = new System.Drawing.Point(4, 25);
            this.tabPageDatabaseBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDatabaseBackup.Name = "tabPageDatabaseBackup";
            this.tabPageDatabaseBackup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDatabaseBackup.Size = new System.Drawing.Size(1576, 1001);
            this.tabPageDatabaseBackup.TabIndex = 3;
            this.tabPageDatabaseBackup.Text = "Database Backup";
            this.tabPageDatabaseBackup.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreXML
            // 
            this.buttonRestoreXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreXML.Location = new System.Drawing.Point(300, 325);
            this.buttonRestoreXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRestoreXML.Name = "buttonRestoreXML";
            this.buttonRestoreXML.Size = new System.Drawing.Size(647, 82);
            this.buttonRestoreXML.TabIndex = 1;
            this.buttonRestoreXML.Text = "Restore Data from XML File";
            this.buttonRestoreXML.UseVisualStyleBackColor = true;
            // 
            // buttonBackupXML
            // 
            this.buttonBackupXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupXML.Location = new System.Drawing.Point(300, 169);
            this.buttonBackupXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackupXML.Name = "buttonBackupXML";
            this.buttonBackupXML.Size = new System.Drawing.Size(647, 82);
            this.buttonBackupXML.TabIndex = 0;
            this.buttonBackupXML.Text = "Backup Data to XML File";
            this.buttonBackupXML.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(52, 34);
            this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(411, 261);
            this.dataGridViewCategories.TabIndex = 1;
            // 
            // ElectronicShopMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1882, 1055);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ElectronicShopMainForm";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAdministrator.ResumeLayout(false);
            this.tabPageAdministrator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPageManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.tabPageSalesOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPageDatabaseBackup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAdministrator;
        private System.Windows.Forms.TabPage tabPageManager;
        private System.Windows.Forms.TabPage tabPageSalesOrder;
        private System.Windows.Forms.TabPage tabPageDatabaseBackup;
        private System.Windows.Forms.Button buttonRestoreXML;
        private System.Windows.Forms.Button buttonBackupXML;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Button buttonOrderFilter;
        private System.Windows.Forms.ListBox listBoxOrderInventory;
        private System.Windows.Forms.ListBox listBoxOrderCustomer;
        private System.Windows.Forms.Button buttonDeleteAllOrders;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonClearFilter;
		private System.Windows.Forms.ListBox listBoxCategory;
		private System.Windows.Forms.ListBox listBoxType;
		private System.Windows.Forms.Label labelVoltage;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Button buttonAddItem;
		private System.Windows.Forms.ListBox listBoxCurrent;
		private System.Windows.Forms.Label labelCurent;
		private System.Windows.Forms.ListBox listBoxVoltage;
		private System.Windows.Forms.Label labelSelectedItems;
		private System.Windows.Forms.DataGridView dataGridViewSelectedItems;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Button buttonAddUpdateCustomer;
		private System.Windows.Forms.Label labelCustomer;
		private System.Windows.Forms.Button buttonOrder;
		private System.Windows.Forms.TextBox textBoxTotalPrice;
		private System.Windows.Forms.Label labelTotalPrice;
		private System.Windows.Forms.Button buttonDeleteItem;
		private System.Windows.Forms.ListBox listBoxVersion;
		private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonAddUpdateInventory;
    }
}

