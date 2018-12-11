namespace POSOrderingSystem
{
    partial class POSRestaurantSideForm
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
            this.components = new System.ComponentModel.Container();
            this._tabControl1 = new System.Windows.Forms.TabControl();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._listBox1 = new System.Windows.Forms.ListBox();
            this.mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._deleteSelectedMealButton = new System.Windows.Forms.Button();
            this._addMealButton = new System.Windows.Forms.Button();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this._mealDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._selectedMealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._browserButton = new System.Windows.Forms.Button();
            this._imagePathTextBox = new System.Windows.Forms.TextBox();
            this._mealPriceTextBox = new System.Windows.Forms.TextBox();
            this._mealCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._mealAddButton = new System.Windows.Forms.Button();
            this._mealNameTextBox = new System.Windows.Forms.TextBox();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this._imagePathLabel = new System.Windows.Forms.Label();
            this._mealCategoryLabel = new System.Windows.Forms.Label();
            this._dollarLabel = new System.Windows.Forms.Label();
            this._mealPriceLabel = new System.Windows.Forms.Label();
            this._mealNameLabel = new System.Windows.Forms.Label();
            this._tabPage2 = new System.Windows.Forms.TabPage();
            this._button4 = new System.Windows.Forms.Button();
            this._button3 = new System.Windows.Forms.Button();
            this._groupBox2 = new System.Windows.Forms.GroupBox();
            this._button7 = new System.Windows.Forms.Button();
            this._listBox4 = new System.Windows.Forms.ListBox();
            this._mealsByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._label8 = new System.Windows.Forms.Label();
            this._textBox2 = new System.Windows.Forms.TextBox();
            this._selectedCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._label7 = new System.Windows.Forms.Label();
            this._listBox2 = new System.Windows.Forms.ListBox();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._tabControl1.SuspendLayout();
            this._tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).BeginInit();
            this._groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._selectedMealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._categoryBindingSource)).BeginInit();
            this._tabPage2.SuspendLayout();
            this._groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealsByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._selectedCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabControl1
            // 
            this._tabControl1.Controls.Add(this._tabPage1);
            this._tabControl1.Controls.Add(this._tabPage2);
            this._tabControl1.Location = new System.Drawing.Point(12, 12);
            this._tabControl1.Name = "_tabControl1";
            this._tabControl1.SelectedIndex = 0;
            this._tabControl1.Size = new System.Drawing.Size(813, 426);
            this._tabControl1.TabIndex = 0;
            // 
            // _tabPage1
            // 
            this._tabPage1.Controls.Add(this._listBox1);
            this._tabPage1.Controls.Add(this._deleteSelectedMealButton);
            this._tabPage1.Controls.Add(this._addMealButton);
            this._tabPage1.Controls.Add(this._groupBox1);
            this._tabPage1.Location = new System.Drawing.Point(4, 25);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage1.Size = new System.Drawing.Size(805, 397);
            this._tabPage1.TabIndex = 0;
            this._tabPage1.Text = "Meal Manager";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // _listBox1
            // 
            this._listBox1.DataSource = this.mealBindingSource;
            this._listBox1.DisplayMember = "Name";
            this._listBox1.FormattingEnabled = true;
            this._listBox1.ItemHeight = 16;
            this._listBox1.Location = new System.Drawing.Point(6, 6);
            this._listBox1.Name = "_listBox1";
            this._listBox1.Size = new System.Drawing.Size(333, 340);
            this._listBox1.TabIndex = 4;
            this._listBox1.SelectedIndexChanged += new System.EventHandler(this.ChangeSelectedIndex);
            // 
            // mealBindingSource
            // 
            this.mealBindingSource.DataSource = typeof(POSOrderingSystem.Model.Meal);
            // 
            // _deleteSelectedMealButton
            // 
            this._deleteSelectedMealButton.Location = new System.Drawing.Point(174, 352);
            this._deleteSelectedMealButton.Name = "_deleteSelectedMealButton";
            this._deleteSelectedMealButton.Size = new System.Drawing.Size(165, 39);
            this._deleteSelectedMealButton.TabIndex = 3;
            this._deleteSelectedMealButton.Text = "Delete Selected Meal";
            this._deleteSelectedMealButton.UseVisualStyleBackColor = true;
            this._deleteSelectedMealButton.Click += new System.EventHandler(this._deleteSelectedMealButton_Click);
            // 
            // _addMealButton
            // 
            this._addMealButton.Location = new System.Drawing.Point(6, 352);
            this._addMealButton.Name = "_addMealButton";
            this._addMealButton.Size = new System.Drawing.Size(120, 39);
            this._addMealButton.TabIndex = 2;
            this._addMealButton.Text = "Add New Meal";
            this._addMealButton.UseVisualStyleBackColor = true;
            this._addMealButton.Click += new System.EventHandler(this.ClickMealAddButton);
            // 
            // _groupBox1
            // 
            this._groupBox1.Controls.Add(this._mealDescriptionRichTextBox);
            this._groupBox1.Controls.Add(this._browserButton);
            this._groupBox1.Controls.Add(this._imagePathTextBox);
            this._groupBox1.Controls.Add(this._mealPriceTextBox);
            this._groupBox1.Controls.Add(this._mealCategoryComboBox);
            this._groupBox1.Controls.Add(this._mealAddButton);
            this._groupBox1.Controls.Add(this._mealNameTextBox);
            this._groupBox1.Controls.Add(this._descriptionLabel);
            this._groupBox1.Controls.Add(this._imagePathLabel);
            this._groupBox1.Controls.Add(this._mealCategoryLabel);
            this._groupBox1.Controls.Add(this._dollarLabel);
            this._groupBox1.Controls.Add(this._mealPriceLabel);
            this._groupBox1.Controls.Add(this._mealNameLabel);
            this._groupBox1.Location = new System.Drawing.Point(345, 6);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(454, 385);
            this._groupBox1.TabIndex = 0;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "Edit Meal";
            // 
            // _mealDescriptionRichTextBox
            // 
            this._mealDescriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._selectedMealBindingSource, "Descript", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._mealDescriptionRichTextBox.Location = new System.Drawing.Point(9, 163);
            this._mealDescriptionRichTextBox.Name = "_mealDescriptionRichTextBox";
            this._mealDescriptionRichTextBox.Size = new System.Drawing.Size(439, 177);
            this._mealDescriptionRichTextBox.TabIndex = 12;
            this._mealDescriptionRichTextBox.Text = "";
            this._mealDescriptionRichTextBox.TextChanged += new System.EventHandler(this.ChangeRichTextBoxText);
            // 
            // _selectedMealBindingSource
            // 
            this._selectedMealBindingSource.DataSource = typeof(POSOrderingSystem.Model.Meal);
            // 
            // _browserButton
            // 
            this._browserButton.Location = new System.Drawing.Point(373, 99);
            this._browserButton.Name = "_browserButton";
            this._browserButton.Size = new System.Drawing.Size(75, 23);
            this._browserButton.TabIndex = 11;
            this._browserButton.Text = "Browse...";
            this._browserButton.UseVisualStyleBackColor = true;
            this._browserButton.Click += new System.EventHandler(this.ClickBrowserButton);
            // 
            // _imagePathTextBox
            // 
            this._imagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._selectedMealBindingSource, "ImagePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._imagePathTextBox.Location = new System.Drawing.Point(199, 99);
            this._imagePathTextBox.Name = "_imagePathTextBox";
            this._imagePathTextBox.Size = new System.Drawing.Size(168, 22);
            this._imagePathTextBox.TabIndex = 10;
            this._imagePathTextBox.TextChanged += new System.EventHandler(this.ChangeImagePathText);
            // 
            // _mealPriceTextBox
            // 
            this._mealPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._selectedMealBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this._mealPriceTextBox.Location = new System.Drawing.Point(111, 67);
            this._mealPriceTextBox.MaxLength = 10;
            this._mealPriceTextBox.Name = "_mealPriceTextBox";
            this._mealPriceTextBox.Size = new System.Drawing.Size(52, 22);
            this._mealPriceTextBox.TabIndex = 9;
            this._mealPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressPriceText);
            // 
            // _mealCategoryComboBox
            // 
            this._mealCategoryComboBox.AccessibleName = "comboBox";
            this._mealCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "Name", true));
            this._mealCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._selectedMealBindingSource, "Category", true));
            this._mealCategoryComboBox.DataSource = this._categoryBindingSource;
            this._mealCategoryComboBox.DisplayMember = "Name";
            this._mealCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._mealCategoryComboBox.FormattingEnabled = true;
            this._mealCategoryComboBox.Location = new System.Drawing.Point(336, 67);
            this._mealCategoryComboBox.Name = "_mealCategoryComboBox";
            this._mealCategoryComboBox.Size = new System.Drawing.Size(112, 24);
            this._mealCategoryComboBox.TabIndex = 8;
            this._mealCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeComboBoxSelectedIndex);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(POSOrderingSystem.Model.Category);
            // 
            // _categoryBindingSource
            // 
            this._categoryBindingSource.DataSource = typeof(POSOrderingSystem.Model.Category);
            // 
            // _mealAddButton
            // 
            this._mealAddButton.Location = new System.Drawing.Point(373, 346);
            this._mealAddButton.Name = "_mealAddButton";
            this._mealAddButton.Size = new System.Drawing.Size(75, 39);
            this._mealAddButton.TabIndex = 7;
            this._mealAddButton.Text = "Save";
            this._mealAddButton.UseVisualStyleBackColor = true;
            this._mealAddButton.Click += new System.EventHandler(this.ClickAddMeal);
            // 
            // _mealNameTextBox
            // 
            this._mealNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._selectedMealBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._mealNameTextBox.Location = new System.Drawing.Point(111, 35);
            this._mealNameTextBox.Name = "_mealNameTextBox";
            this._mealNameTextBox.Size = new System.Drawing.Size(337, 22);
            this._mealNameTextBox.TabIndex = 6;
            this._mealNameTextBox.TextChanged += new System.EventHandler(this.ChangeMealNameText);
            // 
            // _descriptionLabel
            // 
            this._descriptionLabel.AutoSize = true;
            this._descriptionLabel.Location = new System.Drawing.Point(6, 131);
            this._descriptionLabel.Name = "_descriptionLabel";
            this._descriptionLabel.Size = new System.Drawing.Size(113, 17);
            this._descriptionLabel.TabIndex = 5;
            this._descriptionLabel.Text = "Meal Description";
            // 
            // _imagePathLabel
            // 
            this._imagePathLabel.AutoSize = true;
            this._imagePathLabel.Location = new System.Drawing.Point(6, 99);
            this._imagePathLabel.Name = "_imagePathLabel";
            this._imagePathLabel.Size = new System.Drawing.Size(187, 17);
            this._imagePathLabel.TabIndex = 4;
            this._imagePathLabel.Text = "Meal Image Relative Path (*)";
            // 
            // _mealCategoryLabel
            // 
            this._mealCategoryLabel.AutoSize = true;
            this._mealCategoryLabel.Location = new System.Drawing.Point(212, 67);
            this._mealCategoryLabel.Name = "_mealCategoryLabel";
            this._mealCategoryLabel.Size = new System.Drawing.Size(118, 17);
            this._mealCategoryLabel.TabIndex = 3;
            this._mealCategoryLabel.Text = "Meal Category (*)";
            // 
            // _dollarLabel
            // 
            this._dollarLabel.AutoSize = true;
            this._dollarLabel.Location = new System.Drawing.Point(169, 67);
            this._dollarLabel.Name = "_dollarLabel";
            this._dollarLabel.Size = new System.Drawing.Size(37, 17);
            this._dollarLabel.TabIndex = 2;
            this._dollarLabel.Text = "NTD";
            // 
            // _mealPriceLabel
            // 
            this._mealPriceLabel.AutoSize = true;
            this._mealPriceLabel.Location = new System.Drawing.Point(6, 67);
            this._mealPriceLabel.Name = "_mealPriceLabel";
            this._mealPriceLabel.Size = new System.Drawing.Size(93, 17);
            this._mealPriceLabel.TabIndex = 1;
            this._mealPriceLabel.Text = "Meal Price (*)";
            // 
            // _mealNameLabel
            // 
            this._mealNameLabel.AutoSize = true;
            this._mealNameLabel.Location = new System.Drawing.Point(6, 35);
            this._mealNameLabel.Name = "_mealNameLabel";
            this._mealNameLabel.Size = new System.Drawing.Size(98, 17);
            this._mealNameLabel.TabIndex = 0;
            this._mealNameLabel.Text = "Meal Name (*)";
            // 
            // _tabPage2
            // 
            this._tabPage2.Controls.Add(this._button4);
            this._tabPage2.Controls.Add(this._button3);
            this._tabPage2.Controls.Add(this._groupBox2);
            this._tabPage2.Controls.Add(this._listBox2);
            this._tabPage2.Location = new System.Drawing.Point(4, 25);
            this._tabPage2.Name = "_tabPage2";
            this._tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage2.Size = new System.Drawing.Size(805, 397);
            this._tabPage2.TabIndex = 1;
            this._tabPage2.Text = "Category Manager";
            this._tabPage2.UseVisualStyleBackColor = true;
            // 
            // _button4
            // 
            this._button4.Location = new System.Drawing.Point(157, 352);
            this._button4.Name = "_button4";
            this._button4.Size = new System.Drawing.Size(182, 39);
            this._button4.TabIndex = 8;
            this._button4.Text = "Delete Selected Category";
            this._button4.UseVisualStyleBackColor = true;
            // 
            // _button3
            // 
            this._button3.Location = new System.Drawing.Point(7, 352);
            this._button3.Name = "_button3";
            this._button3.Size = new System.Drawing.Size(110, 39);
            this._button3.TabIndex = 7;
            this._button3.Text = "Add Category";
            this._button3.UseVisualStyleBackColor = true;
            this._button3.Click += new System.EventHandler(this.ClickClearSelected);
            // 
            // _groupBox2
            // 
            this._groupBox2.Controls.Add(this._button7);
            this._groupBox2.Controls.Add(this._listBox4);
            this._groupBox2.Controls.Add(this._label8);
            this._groupBox2.Controls.Add(this._textBox2);
            this._groupBox2.Controls.Add(this._label7);
            this._groupBox2.Location = new System.Drawing.Point(345, 6);
            this._groupBox2.Name = "_groupBox2";
            this._groupBox2.Size = new System.Drawing.Size(454, 385);
            this._groupBox2.TabIndex = 6;
            this._groupBox2.TabStop = false;
            this._groupBox2.Text = "Edit Meal";
            // 
            // _button7
            // 
            this._button7.Location = new System.Drawing.Point(373, 346);
            this._button7.Name = "_button7";
            this._button7.Size = new System.Drawing.Size(75, 39);
            this._button7.TabIndex = 4;
            this._button7.Text = "Save";
            this._button7.UseVisualStyleBackColor = true;
            this._button7.Click += new System.EventHandler(this.ClickAddCategory);
            // 
            // _listBox4
            // 
            this._listBox4.DataSource = this._mealsByCategoryBindingSource;
            this._listBox4.DisplayMember = "Name";
            this._listBox4.FormattingEnabled = true;
            this._listBox4.ItemHeight = 16;
            this._listBox4.Location = new System.Drawing.Point(9, 92);
            this._listBox4.Name = "_listBox4";
            this._listBox4.Size = new System.Drawing.Size(439, 244);
            this._listBox4.TabIndex = 3;
            // 
            // _mealsByCategoryBindingSource
            // 
            this._mealsByCategoryBindingSource.DataSource = typeof(POSOrderingSystem.Model.Meal);
            // 
            // _label8
            // 
            this._label8.AutoSize = true;
            this._label8.Location = new System.Drawing.Point(6, 72);
            this._label8.Name = "_label8";
            this._label8.Size = new System.Drawing.Size(182, 17);
            this._label8.TabIndex = 2;
            this._label8.Text = "Meal(s) Using this Category";
            // 
            // _textBox2
            // 
            this._textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._selectedCategoryBindingSource, "Name", true));
            this._textBox2.Location = new System.Drawing.Point(137, 32);
            this._textBox2.Name = "_textBox2";
            this._textBox2.Size = new System.Drawing.Size(311, 22);
            this._textBox2.TabIndex = 1;
            this._textBox2.TextChanged += new System.EventHandler(this.ChangeTextBoxTextEnable);
            // 
            // _selectedCategoryBindingSource
            // 
            this._selectedCategoryBindingSource.DataSource = typeof(POSOrderingSystem.Model.Category);
            // 
            // _label7
            // 
            this._label7.AutoSize = true;
            this._label7.Location = new System.Drawing.Point(6, 32);
            this._label7.Name = "_label7";
            this._label7.Size = new System.Drawing.Size(125, 17);
            this._label7.TabIndex = 0;
            this._label7.Text = "Category Name (*)";
            // 
            // _listBox2
            // 
            this._listBox2.DataSource = this._categoryBindingSource;
            this._listBox2.DisplayMember = "Name";
            this._listBox2.FormattingEnabled = true;
            this._listBox2.ItemHeight = 16;
            this._listBox2.Location = new System.Drawing.Point(6, 6);
            this._listBox2.Name = "_listBox2";
            this._listBox2.Size = new System.Drawing.Size(333, 340);
            this._listBox2.TabIndex = 5;
            this._listBox2.SelectedIndexChanged += new System.EventHandler(this.ChangeListBoxSelectedIndex);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.FileName = "openFileDialog1";
            // 
            // POSRestaurantSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this._tabControl1);
            this.Name = "POSRestaurantSideForm";
            this.Text = "POSRestaurantSideForm";
            this._tabControl1.ResumeLayout(false);
            this._tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).EndInit();
            this._groupBox1.ResumeLayout(false);
            this._groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._selectedMealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._categoryBindingSource)).EndInit();
            this._tabPage2.ResumeLayout(false);
            this._groupBox2.ResumeLayout(false);
            this._groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealsByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._selectedCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl1;
        private System.Windows.Forms.TabPage _tabPage1;
        private System.Windows.Forms.TabPage _tabPage2;
        private System.Windows.Forms.GroupBox _groupBox1;
        private System.Windows.Forms.Button _deleteSelectedMealButton;
        private System.Windows.Forms.Button _addMealButton;
        private System.Windows.Forms.ListBox _listBox1;
        private System.Windows.Forms.Button _button4;
        private System.Windows.Forms.Button _button3;
        private System.Windows.Forms.GroupBox _groupBox2;
        private System.Windows.Forms.ListBox _listBox2;
        private System.Windows.Forms.Button _mealAddButton;
        private System.Windows.Forms.TextBox _mealNameTextBox;
        private System.Windows.Forms.Label _descriptionLabel;
        private System.Windows.Forms.Label _imagePathLabel;
        private System.Windows.Forms.Label _mealCategoryLabel;
        private System.Windows.Forms.Label _dollarLabel;
        private System.Windows.Forms.Label _mealPriceLabel;
        private System.Windows.Forms.Label _mealNameLabel;
        private System.Windows.Forms.Label _label7;
        private System.Windows.Forms.Button _browserButton;
        private System.Windows.Forms.TextBox _imagePathTextBox;
        private System.Windows.Forms.TextBox _mealPriceTextBox;
        private System.Windows.Forms.ComboBox _mealCategoryComboBox;
        private System.Windows.Forms.ListBox _listBox4;
        private System.Windows.Forms.Label _label8;
        private System.Windows.Forms.TextBox _textBox2;
        private System.Windows.Forms.RichTextBox _mealDescriptionRichTextBox;
        private System.Windows.Forms.Button _button7;
        private System.Windows.Forms.BindingSource _selectedMealBindingSource;
        private System.Windows.Forms.BindingSource _categoryBindingSource;
        private System.Windows.Forms.BindingSource _mealsByCategoryBindingSource;
        private System.Windows.Forms.BindingSource _selectedCategoryBindingSource;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.BindingSource mealBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}