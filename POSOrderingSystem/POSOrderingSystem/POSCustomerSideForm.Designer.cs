namespace POSOrderingSystem
{
    partial class POSCustomerSideForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param _name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this._mealGroupBox = new System.Windows.Forms.GroupBox();
            this._tabControl1 = new System.Windows.Forms.TabControl();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._tabPage2 = new System.Windows.Forms.TabPage();
            this._tabPage3 = new System.Windows.Forms.TabPage();
            this._descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this._pageLabel = new System.Windows.Forms.Label();
            this._addButton = new System.Windows.Forms.Button();
            this._nextButton = new System.Windows.Forms.Button();
            this._previousButton = new System.Windows.Forms.Button();
            this._mealsDataGridView = new System.Windows.Forms.DataGridView();
            this._dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this._dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn5 = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._totalLabel = new System.Windows.Forms.Label();
            this._orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._mealGroupBox.SuspendLayout();
            this._tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._orderBindingSource)).BeginInit();
            this._tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mealGroupBox
            // 
            this._mealGroupBox.Controls.Add(this._tabControl1);
            this._mealGroupBox.Controls.Add(this._descriptionTextBox);
            this._mealGroupBox.Controls.Add(this._pageLabel);
            this._mealGroupBox.Controls.Add(this._addButton);
            this._mealGroupBox.Controls.Add(this._nextButton);
            this._mealGroupBox.Controls.Add(this._previousButton);
            this._mealGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealGroupBox.Location = new System.Drawing.Point(3, 3);
            this._mealGroupBox.Name = "_mealGroupBox";
            this._tableLayoutPanel1.SetRowSpan(this._mealGroupBox, 2);
            this._mealGroupBox.Size = new System.Drawing.Size(493, 665);
            this._mealGroupBox.TabIndex = 0;
            this._mealGroupBox.TabStop = false;
            this._mealGroupBox.Text = "Meals";
            // 
            // _tabControl1
            // 
            this._tabControl1.Controls.Add(this._tabPage1);
            this._tabControl1.Controls.Add(this._tabPage2);
            this._tabControl1.Controls.Add(this._tabPage3);
            this._tabControl1.Location = new System.Drawing.Point(9, 21);
            this._tabControl1.Name = "_tabControl1";
            this._tabControl1.SelectedIndex = 0;
            this._tabControl1.Size = new System.Drawing.Size(478, 460);
            this._tabControl1.TabIndex = 14;
            this._tabControl1.SelectedIndexChanged += new System.EventHandler(this.ChangedTabControlSelectedIndex);
            // 
            // _tabPage1
            // 
            this._tabPage1.Location = new System.Drawing.Point(4, 25);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage1.Size = new System.Drawing.Size(470, 431);
            this._tabPage1.TabIndex = 0;
            this._tabPage1.Text = "壽司";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // _tabPage2
            // 
            this._tabPage2.Location = new System.Drawing.Point(4, 25);
            this._tabPage2.Name = "_tabPage2";
            this._tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage2.Size = new System.Drawing.Size(470, 431);
            this._tabPage2.TabIndex = 1;
            this._tabPage2.Text = "甜點";
            this._tabPage2.UseVisualStyleBackColor = true;
            // 
            // _tabPage3
            // 
            this._tabPage3.Location = new System.Drawing.Point(4, 25);
            this._tabPage3.Name = "_tabPage3";
            this._tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage3.Size = new System.Drawing.Size(470, 431);
            this._tabPage3.TabIndex = 2;
            this._tabPage3.Text = "飲料";
            this._tabPage3.UseVisualStyleBackColor = true;
            // 
            // _descriptionTextBox
            // 
            this._descriptionTextBox.Location = new System.Drawing.Point(13, 487);
            this._descriptionTextBox.Name = "_descriptionTextBox";
            this._descriptionTextBox.ReadOnly = true;
            this._descriptionTextBox.Size = new System.Drawing.Size(470, 75);
            this._descriptionTextBox.TabIndex = 13;
            this._descriptionTextBox.Text = "";
            // 
            // _pageLabel
            // 
            this._pageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._pageLabel.AutoSize = true;
            this._pageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._pageLabel.Location = new System.Drawing.Point(10, 621);
            this._pageLabel.Name = "_pageLabel";
            this._pageLabel.Size = new System.Drawing.Size(79, 29);
            this._pageLabel.TabIndex = 12;
            this._pageLabel.Text = "label1";
            // 
            // _addButton
            // 
            this._addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addButton.Location = new System.Drawing.Point(357, 576);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(110, 38);
            this._addButton.TabIndex = 11;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.ClickAddButton);
            // 
            // _nextButton
            // 
            this._nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._nextButton.Location = new System.Drawing.Point(357, 620);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(110, 38);
            this._nextButton.TabIndex = 10;
            this._nextButton.Text = "Next Page";
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this.ClickNextPageButton);
            // 
            // _previousButton
            // 
            this._previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._previousButton.Location = new System.Drawing.Point(197, 620);
            this._previousButton.Name = "_previousButton";
            this._previousButton.Size = new System.Drawing.Size(154, 38);
            this._previousButton.TabIndex = 9;
            this._previousButton.Text = "Previous Page";
            this._previousButton.UseVisualStyleBackColor = true;
            this._previousButton.Click += new System.EventHandler(this.ClickPreviousPageButton);
            // 
            // _mealsDataGridView
            // 
            this._mealsDataGridView.AllowUserToAddRows = false;
            this._mealsDataGridView.AutoGenerateColumns = false;
            this._mealsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._mealsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._mealsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._dataGridViewTextBoxColumn1,
            this._dataGridViewTextBoxColumn2,
            this._dataGridViewTextBoxColumn3,
            this._dataGridViewTextBoxColumn4,
            this._dataGridViewTextBoxColumn5,
            this._dataGridViewTextBoxColumn6});
            this._mealsDataGridView.DataSource = this._orderItemBindingSource;
            this._mealsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealsDataGridView.Location = new System.Drawing.Point(502, 3);
            this._mealsDataGridView.Name = "_mealsDataGridView";
            this._mealsDataGridView.RowHeadersVisible = false;
            this._mealsDataGridView.RowTemplate.Height = 24;
            this._mealsDataGridView.Size = new System.Drawing.Size(605, 597);
            this._mealsDataGridView.TabIndex = 1;
            this._mealsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickMealsDataGridViewCellContent);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this._dataGridViewTextBoxColumn1.DataPropertyName = "Delete";
            this._dataGridViewTextBoxColumn1.HeaderText = "Delete";
            this._dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this._dataGridViewTextBoxColumn1.ReadOnly = true;
            this._dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _dataGridViewTextBoxColumn2
            // 
            this._dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this._dataGridViewTextBoxColumn2.HeaderText = "Name";
            this._dataGridViewTextBoxColumn2.Name = "_dataGridViewTextBoxColumn2";
            this._dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn3
            // 
            this._dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this._dataGridViewTextBoxColumn3.HeaderText = "Unit Price";
            this._dataGridViewTextBoxColumn3.Name = "_dataGridViewTextBoxColumn3";
            this._dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn4
            // 
            this._dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            this._dataGridViewTextBoxColumn4.HeaderText = "Category";
            this._dataGridViewTextBoxColumn4.Name = "_dataGridViewTextBoxColumn4";
            this._dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn5
            // 
            this._dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this._dataGridViewTextBoxColumn5.HeaderText = "Qty";
            this._dataGridViewTextBoxColumn5.Name = "_dataGridViewTextBoxColumn5";
            this._dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _dataGridViewTextBoxColumn6
            // 
            this._dataGridViewTextBoxColumn6.DataPropertyName = "Subtotal";
            this._dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this._dataGridViewTextBoxColumn6.Name = "_dataGridViewTextBoxColumn6";
            this._dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // _orderItemBindingSource
            // 
            this._orderItemBindingSource.DataSource = typeof(POSOrderingSystem.Model.OrderItem);
            // 
            // _totalLabel
            // 
            this._totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._totalLabel.AutoSize = true;
            this._totalLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._orderBindingSource, "TotalPrice", true));
            this._totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._totalLabel.ForeColor = System.Drawing.Color.DarkRed;
            this._totalLabel.Location = new System.Drawing.Point(951, 623);
            this._totalLabel.Margin = new System.Windows.Forms.Padding(10);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(149, 38);
            this._totalLabel.TabIndex = 2;
            this._totalLabel.Text = "Total:0元";
            this._totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _orderBindingSource
            // 
            this._orderBindingSource.DataSource = typeof(POSOrderingSystem.Model.Order);
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 2;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this._tableLayoutPanel1.Controls.Add(this._mealsDataGridView, 1, 0);
            this._tableLayoutPanel1.Controls.Add(this._mealGroupBox, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._totalLabel, 1, 1);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 2;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(1110, 671);
            this._tableLayoutPanel1.TabIndex = 3;
            // 
            // POSCustomerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 671);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Name = "POSCustomerSideForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.POSCustomerSideForm_Shown);
            this._mealGroupBox.ResumeLayout(false);
            this._mealGroupBox.PerformLayout();
            this._tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._mealsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._orderBindingSource)).EndInit();
            this._tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _mealGroupBox;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.Button _previousButton;
        private System.Windows.Forms.DataGridView _mealsDataGridView;
        private System.Windows.Forms.Label _totalLabel;
        private System.Windows.Forms.Label _pageLabel;
        private System.Windows.Forms.RichTextBox _descriptionTextBox;
        private System.ComponentModel.BackgroundWorker _backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.BindingSource _orderItemBindingSource;
        private System.Windows.Forms.BindingSource _orderBindingSource;
        private System.Windows.Forms.TabControl _tabControl1;
        private System.Windows.Forms.TabPage _tabPage1;
        private System.Windows.Forms.TabPage _tabPage2;
        private System.Windows.Forms.TabPage _tabPage3;
        private System.Windows.Forms.DataGridViewButtonColumn _dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn4;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn6;
    }
}

