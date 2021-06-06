namespace WindowsFormsApp2
{
    partial class Form1
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
            this.LogInForm_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BrowseTabPage = new System.Windows.Forms.TabPage();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearButton = new System.Windows.Forms.TabPage();
            this.FindSimilarCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearTextBoxButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FoundId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoundPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoundQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.byNameRadioButton = new System.Windows.Forms.RadioButton();
            this.byIdRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddTabPage = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.LatestAdditionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditTabPage = new System.Windows.Forms.TabPage();
            this.ByIdEditRadioButton = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NewPriceTextBox = new System.Windows.Forms.TextBox();
            this.NewQuantityTextBox = new System.Windows.Forms.TextBox();
            this.NewIdTextBox = new System.Windows.Forms.TextBox();
            this.NewNameTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentPriceTextBox = new System.Windows.Forms.TextBox();
            this.CurrentQuantityTextBox = new System.Windows.Forms.TextBox();
            this.CurrentIdTextBox = new System.Windows.Forms.TextBox();
            this.CurrentNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchEditButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearSearchEditTextBoxButton = new System.Windows.Forms.Button();
            this.ByNameEditRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchEditTextBox = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LoginStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ReadyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CompletedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.BrowseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ClearButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.AddTabPage.SuspendLayout();
            this.EditTabPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInForm_Button
            // 
            this.LogInForm_Button.AccessibleName = "LogInForm_Button";
            this.LogInForm_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInForm_Button.BackColor = System.Drawing.Color.Cyan;
            this.LogInForm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInForm_Button.Location = new System.Drawing.Point(517, 0);
            this.LogInForm_Button.Name = "LogInForm_Button";
            this.LogInForm_Button.Size = new System.Drawing.Size(77, 24);
            this.LogInForm_Button.TabIndex = 0;
            this.LogInForm_Button.Text = "LogIn";
            this.LogInForm_Button.UseVisualStyleBackColor = false;
            this.LogInForm_Button.Click += new System.EventHandler(this.LogInForm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BrowseTabPage);
            this.tabControl1.Controls.Add(this.ClearButton);
            this.tabControl1.Controls.Add(this.AddTabPage);
            this.tabControl1.Controls.Add(this.EditTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 490);
            this.tabControl1.TabIndex = 2;
            // 
            // BrowseTabPage
            // 
            this.BrowseTabPage.Controls.Add(this.RefreshButton);
            this.BrowseTabPage.Controls.Add(this.dataGridView1);
            this.BrowseTabPage.Location = new System.Drawing.Point(4, 22);
            this.BrowseTabPage.Name = "BrowseTabPage";
            this.BrowseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BrowseTabPage.Size = new System.Drawing.Size(586, 464);
            this.BrowseTabPage.TabIndex = 0;
            this.BrowseTabPage.Text = "Browse";
            this.BrowseTabPage.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Location = new System.Drawing.Point(3, 438);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(580, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product,
            this.Price,
            this.Quantity});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 458);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // ClearButton
            // 
            this.ClearButton.Controls.Add(this.FindSimilarCheckBox);
            this.ClearButton.Controls.Add(this.ClearTextBoxButton);
            this.ClearButton.Controls.Add(this.DeleteButton);
            this.ClearButton.Controls.Add(this.dataGridView2);
            this.ClearButton.Controls.Add(this.label6);
            this.ClearButton.Controls.Add(this.byNameRadioButton);
            this.ClearButton.Controls.Add(this.byIdRadioButton);
            this.ClearButton.Controls.Add(this.SearchTextBox);
            this.ClearButton.Controls.Add(this.SearchButton);
            this.ClearButton.Location = new System.Drawing.Point(4, 22);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Padding = new System.Windows.Forms.Padding(3);
            this.ClearButton.Size = new System.Drawing.Size(586, 464);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Search";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // FindSimilarCheckBox
            // 
            this.FindSimilarCheckBox.AutoSize = true;
            this.FindSimilarCheckBox.Checked = true;
            this.FindSimilarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FindSimilarCheckBox.Location = new System.Drawing.Point(149, 46);
            this.FindSimilarCheckBox.Name = "FindSimilarCheckBox";
            this.FindSimilarCheckBox.Size = new System.Drawing.Size(106, 17);
            this.FindSimilarCheckBox.TabIndex = 10;
            this.FindSimilarCheckBox.Text = "find similar ones?";
            this.FindSimilarCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearTextBoxButton
            // 
            this.ClearTextBoxButton.Location = new System.Drawing.Point(500, 19);
            this.ClearTextBoxButton.Name = "ClearTextBoxButton";
            this.ClearTextBoxButton.Size = new System.Drawing.Size(75, 20);
            this.ClearTextBoxButton.TabIndex = 9;
            this.ClearTextBoxButton.Text = "Clear";
            this.ClearTextBoxButton.UseVisualStyleBackColor = true;
            this.ClearTextBoxButton.Click += new System.EventHandler(this.ClearTextBoxButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(501, 68);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoundId,
            this.FoundName,
            this.FoundPrice,
            this.FoundQuantity});
            this.dataGridView2.Location = new System.Drawing.Point(3, 97);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(586, 364);
            this.dataGridView2.TabIndex = 7;
            // 
            // FoundId
            // 
            this.FoundId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoundId.HeaderText = "Id";
            this.FoundId.Name = "FoundId";
            // 
            // FoundName
            // 
            this.FoundName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoundName.HeaderText = "Name";
            this.FoundName.Name = "FoundName";
            // 
            // FoundPrice
            // 
            this.FoundPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoundPrice.HeaderText = "Price";
            this.FoundPrice.Name = "FoundPrice";
            // 
            // FoundQuantity
            // 
            this.FoundQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoundQuantity.HeaderText = "Quantity";
            this.FoundQuantity.Name = "FoundQuantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enter Id or Name to search!";
            // 
            // byNameRadioButton
            // 
            this.byNameRadioButton.AutoSize = true;
            this.byNameRadioButton.Checked = true;
            this.byNameRadioButton.Location = new System.Drawing.Point(70, 45);
            this.byNameRadioButton.Name = "byNameRadioButton";
            this.byNameRadioButton.Size = new System.Drawing.Size(73, 17);
            this.byNameRadioButton.TabIndex = 5;
            this.byNameRadioButton.TabStop = true;
            this.byNameRadioButton.Text = "by Name?";
            this.byNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // byIdRadioButton
            // 
            this.byIdRadioButton.AutoSize = true;
            this.byIdRadioButton.Location = new System.Drawing.Point(9, 45);
            this.byIdRadioButton.Name = "byIdRadioButton";
            this.byIdRadioButton.Size = new System.Drawing.Size(56, 17);
            this.byIdRadioButton.TabIndex = 4;
            this.byIdRadioButton.Text = "by ID?";
            this.byIdRadioButton.UseVisualStyleBackColor = true;
            this.byIdRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTextBox.Location = new System.Drawing.Point(8, 19);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(486, 20);
            this.SearchTextBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(8, 68);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(486, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddTabPage
            // 
            this.AddTabPage.Controls.Add(this.label17);
            this.AddTabPage.Controls.Add(this.LatestAdditionTextBox);
            this.AddTabPage.Controls.Add(this.label4);
            this.AddTabPage.Controls.Add(this.label3);
            this.AddTabPage.Controls.Add(this.PriceTextBox);
            this.AddTabPage.Controls.Add(this.QuantityTextBox);
            this.AddTabPage.Controls.Add(this.IdTextBox);
            this.AddTabPage.Controls.Add(this.ProductTextBox);
            this.AddTabPage.Controls.Add(this.label2);
            this.AddTabPage.Controls.Add(this.label1);
            this.AddTabPage.Controls.Add(this.AddButton);
            this.AddTabPage.Location = new System.Drawing.Point(4, 22);
            this.AddTabPage.Name = "AddTabPage";
            this.AddTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddTabPage.Size = new System.Drawing.Size(586, 464);
            this.AddTabPage.TabIndex = 1;
            this.AddTabPage.Text = "Add";
            this.AddTabPage.UseVisualStyleBackColor = true;
            this.AddTabPage.Click += new System.EventHandler(this.AddTabPage_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(8, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Latest addition :";
            // 
            // LatestAdditionTextBox
            // 
            this.LatestAdditionTextBox.Enabled = false;
            this.LatestAdditionTextBox.Location = new System.Drawing.Point(8, 152);
            this.LatestAdditionTextBox.Multiline = true;
            this.LatestAdditionTextBox.Name = "LatestAdditionTextBox";
            this.LatestAdditionTextBox.Size = new System.Drawing.Size(570, 306);
            this.LatestAdditionTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(294, 23);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(141, 20);
            this.PriceTextBox.TabIndex = 3;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(441, 23);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(137, 20);
            this.QuantityTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(8, 23);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(134, 20);
            this.IdTextBox.TabIndex = 1;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Location = new System.Drawing.Point(148, 23);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(140, 20);
            this.ProductTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(8, 68);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(570, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditTabPage
            // 
            this.EditTabPage.Controls.Add(this.ByIdEditRadioButton);
            this.EditTabPage.Controls.Add(this.label16);
            this.EditTabPage.Controls.Add(this.label12);
            this.EditTabPage.Controls.Add(this.label13);
            this.EditTabPage.Controls.Add(this.NewPriceTextBox);
            this.EditTabPage.Controls.Add(this.NewQuantityTextBox);
            this.EditTabPage.Controls.Add(this.NewIdTextBox);
            this.EditTabPage.Controls.Add(this.NewNameTextBox);
            this.EditTabPage.Controls.Add(this.label14);
            this.EditTabPage.Controls.Add(this.label15);
            this.EditTabPage.Controls.Add(this.EditButton);
            this.EditTabPage.Controls.Add(this.label8);
            this.EditTabPage.Controls.Add(this.label9);
            this.EditTabPage.Controls.Add(this.CurrentPriceTextBox);
            this.EditTabPage.Controls.Add(this.CurrentQuantityTextBox);
            this.EditTabPage.Controls.Add(this.CurrentIdTextBox);
            this.EditTabPage.Controls.Add(this.CurrentNameTextBox);
            this.EditTabPage.Controls.Add(this.label10);
            this.EditTabPage.Controls.Add(this.label11);
            this.EditTabPage.Controls.Add(this.SearchEditButton);
            this.EditTabPage.Controls.Add(this.label7);
            this.EditTabPage.Controls.Add(this.label5);
            this.EditTabPage.Controls.Add(this.ClearSearchEditTextBoxButton);
            this.EditTabPage.Controls.Add(this.ByNameEditRadioButton);
            this.EditTabPage.Controls.Add(this.SearchEditTextBox);
            this.EditTabPage.Location = new System.Drawing.Point(4, 22);
            this.EditTabPage.Name = "EditTabPage";
            this.EditTabPage.Size = new System.Drawing.Size(586, 464);
            this.EditTabPage.TabIndex = 3;
            this.EditTabPage.Text = "Edit";
            this.EditTabPage.UseVisualStyleBackColor = true;
            // 
            // ByIdEditRadioButton
            // 
            this.ByIdEditRadioButton.AutoSize = true;
            this.ByIdEditRadioButton.Location = new System.Drawing.Point(11, 45);
            this.ByIdEditRadioButton.Name = "ByIdEditRadioButton";
            this.ByIdEditRadioButton.Size = new System.Drawing.Size(56, 17);
            this.ByIdEditRadioButton.TabIndex = 44;
            this.ByIdEditRadioButton.Text = "by ID?";
            this.ByIdEditRadioButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(8, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 43;
            this.label16.Text = "New data:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Price";
            // 
            // NewPriceTextBox
            // 
            this.NewPriceTextBox.Location = new System.Drawing.Point(295, 267);
            this.NewPriceTextBox.Name = "NewPriceTextBox";
            this.NewPriceTextBox.Size = new System.Drawing.Size(141, 20);
            this.NewPriceTextBox.TabIndex = 39;
            // 
            // NewQuantityTextBox
            // 
            this.NewQuantityTextBox.Location = new System.Drawing.Point(442, 267);
            this.NewQuantityTextBox.Name = "NewQuantityTextBox";
            this.NewQuantityTextBox.Size = new System.Drawing.Size(133, 20);
            this.NewQuantityTextBox.TabIndex = 40;
            // 
            // NewIdTextBox
            // 
            this.NewIdTextBox.Location = new System.Drawing.Point(9, 267);
            this.NewIdTextBox.Name = "NewIdTextBox";
            this.NewIdTextBox.Size = new System.Drawing.Size(134, 20);
            this.NewIdTextBox.TabIndex = 35;
            // 
            // NewNameTextBox
            // 
            this.NewNameTextBox.Location = new System.Drawing.Point(149, 267);
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.NewNameTextBox.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(146, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Product";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Id";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(9, 312);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(566, 23);
            this.EditButton.TabIndex = 34;
            this.EditButton.Text = "Edit data";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Price";
            // 
            // CurrentPriceTextBox
            // 
            this.CurrentPriceTextBox.Enabled = false;
            this.CurrentPriceTextBox.Location = new System.Drawing.Point(291, 171);
            this.CurrentPriceTextBox.Name = "CurrentPriceTextBox";
            this.CurrentPriceTextBox.Size = new System.Drawing.Size(141, 20);
            this.CurrentPriceTextBox.TabIndex = 30;
            // 
            // CurrentQuantityTextBox
            // 
            this.CurrentQuantityTextBox.Enabled = false;
            this.CurrentQuantityTextBox.Location = new System.Drawing.Point(438, 171);
            this.CurrentQuantityTextBox.Name = "CurrentQuantityTextBox";
            this.CurrentQuantityTextBox.Size = new System.Drawing.Size(137, 20);
            this.CurrentQuantityTextBox.TabIndex = 31;
            // 
            // CurrentIdTextBox
            // 
            this.CurrentIdTextBox.Enabled = false;
            this.CurrentIdTextBox.Location = new System.Drawing.Point(8, 171);
            this.CurrentIdTextBox.Name = "CurrentIdTextBox";
            this.CurrentIdTextBox.Size = new System.Drawing.Size(131, 20);
            this.CurrentIdTextBox.TabIndex = 26;
            // 
            // CurrentNameTextBox
            // 
            this.CurrentNameTextBox.Enabled = false;
            this.CurrentNameTextBox.Location = new System.Drawing.Point(145, 171);
            this.CurrentNameTextBox.Name = "CurrentNameTextBox";
            this.CurrentNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.CurrentNameTextBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Product";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Id";
            // 
            // SearchEditButton
            // 
            this.SearchEditButton.Location = new System.Drawing.Point(8, 68);
            this.SearchEditButton.Name = "SearchEditButton";
            this.SearchEditButton.Size = new System.Drawing.Size(566, 23);
            this.SearchEditButton.TabIndex = 25;
            this.SearchEditButton.Text = "Search";
            this.SearchEditButton.UseVisualStyleBackColor = true;
            this.SearchEditButton.Click += new System.EventHandler(this.SearchEditButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Enter Id or Name to search!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Сurrent data:";
            // 
            // ClearSearchEditTextBoxButton
            // 
            this.ClearSearchEditTextBoxButton.Location = new System.Drawing.Point(500, 19);
            this.ClearSearchEditTextBoxButton.Name = "ClearSearchEditTextBoxButton";
            this.ClearSearchEditTextBoxButton.Size = new System.Drawing.Size(75, 20);
            this.ClearSearchEditTextBoxButton.TabIndex = 13;
            this.ClearSearchEditTextBoxButton.Text = "Clear";
            this.ClearSearchEditTextBoxButton.UseVisualStyleBackColor = true;
            this.ClearSearchEditTextBoxButton.Click += new System.EventHandler(this.ClearSearchEditTextBoxButton_Click);
            // 
            // ByNameEditRadioButton
            // 
            this.ByNameEditRadioButton.AutoSize = true;
            this.ByNameEditRadioButton.Checked = true;
            this.ByNameEditRadioButton.Location = new System.Drawing.Point(73, 45);
            this.ByNameEditRadioButton.Name = "ByNameEditRadioButton";
            this.ByNameEditRadioButton.Size = new System.Drawing.Size(73, 17);
            this.ByNameEditRadioButton.TabIndex = 12;
            this.ByNameEditRadioButton.TabStop = true;
            this.ByNameEditRadioButton.Text = "by Name?";
            this.ByNameEditRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchEditTextBox
            // 
            this.SearchEditTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchEditTextBox.Location = new System.Drawing.Point(8, 19);
            this.SearchEditTextBox.Name = "SearchEditTextBox";
            this.SearchEditTextBox.Size = new System.Drawing.Size(486, 20);
            this.SearchEditTextBox.TabIndex = 10;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Location = new System.Drawing.Point(517, 0);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(77, 23);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "LogOut";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginStatusLabel,
            this.ReadyStatusLabel,
            this.CompletedStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(594, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip4";
            // 
            // LoginStatusLabel
            // 
            this.LoginStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.LoginStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginStatusLabel.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.LoginStatusLabel.Name = "LoginStatusLabel";
            this.LoginStatusLabel.Size = new System.Drawing.Size(17, 17);
            this.LoginStatusLabel.Text = "⬤";
            // 
            // ReadyStatusLabel
            // 
            this.ReadyStatusLabel.Name = "ReadyStatusLabel";
            this.ReadyStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.ReadyStatusLabel.Text = "Ready";
            this.ReadyStatusLabel.Visible = false;
            // 
            // CompletedStatusLabel
            // 
            this.CompletedStatusLabel.Name = "CompletedStatusLabel";
            this.CompletedStatusLabel.Size = new System.Drawing.Size(146, 17);
            this.CompletedStatusLabel.Text = "✓ Successfully completed!";
            this.CompletedStatusLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 542);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LogInForm_Button);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AGoods - Accounting of goods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.BrowseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ClearButton.ResumeLayout(false);
            this.ClearButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.AddTabPage.ResumeLayout(false);
            this.AddTabPage.PerformLayout();
            this.EditTabPage.ResumeLayout(false);
            this.EditTabPage.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInForm_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BrowseTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage AddTabPage;
        private System.Windows.Forms.TabPage EditTabPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TabPage ClearButton;
        private System.Windows.Forms.RadioButton byNameRadioButton;
        private System.Windows.Forms.RadioButton byIdRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoundId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoundPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoundQuantity;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearTextBoxButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CompletedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ReadyStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LoginStatusLabel;
        private System.Windows.Forms.Button SearchEditButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearSearchEditTextBoxButton;
        private System.Windows.Forms.RadioButton ByNameEditRadioButton;
        private System.Windows.Forms.TextBox SearchEditTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NewPriceTextBox;
        private System.Windows.Forms.TextBox NewQuantityTextBox;
        private System.Windows.Forms.TextBox NewIdTextBox;
        private System.Windows.Forms.TextBox NewNameTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CurrentPriceTextBox;
        private System.Windows.Forms.TextBox CurrentQuantityTextBox;
        private System.Windows.Forms.TextBox CurrentIdTextBox;
        private System.Windows.Forms.TextBox CurrentNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox FindSimilarCheckBox;
        private System.Windows.Forms.RadioButton ByIdEditRadioButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox LatestAdditionTextBox;
    }
}

