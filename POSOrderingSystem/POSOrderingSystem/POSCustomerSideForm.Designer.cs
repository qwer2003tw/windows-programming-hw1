﻿namespace POSOrderingSystem
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
            this._mealGroupBox = new System.Windows.Forms.GroupBox();
            this._pageLabel = new System.Windows.Forms.Label();
            this._addButton = new System.Windows.Forms.Button();
            this._nextButton = new System.Windows.Forms.Button();
            this._previousButton = new System.Windows.Forms.Button();
            this._mealsDataGridView = new System.Windows.Forms.DataGridView();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalLabel = new System.Windows.Forms.Label();
            this._mealGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _mealGroupBox
            // 
            this._mealGroupBox.Controls.Add(this._pageLabel);
            this._mealGroupBox.Controls.Add(this._addButton);
            this._mealGroupBox.Controls.Add(this._nextButton);
            this._mealGroupBox.Controls.Add(this._previousButton);
            this._mealGroupBox.Location = new System.Drawing.Point(12, 12);
            this._mealGroupBox.Name = "_mealGroupBox";
            this._mealGroupBox.Size = new System.Drawing.Size(497, 632);
            this._mealGroupBox.TabIndex = 0;
            this._mealGroupBox.TabStop = false;
            this._mealGroupBox.Text = "Meals";
            // 
            // _pageLabel
            // 
            this._pageLabel.AutoSize = true;
            this._pageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._pageLabel.Location = new System.Drawing.Point(6, 596);
            this._pageLabel.Name = "_pageLabel";
            this._pageLabel.Size = new System.Drawing.Size(79, 29);
            this._pageLabel.TabIndex = 12;
            this._pageLabel.Text = "label1";
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(375, 550);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(110, 23);
            this._addButton.TabIndex = 11;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(375, 603);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(110, 23);
            this._nextButton.TabIndex = 10;
            this._nextButton.Text = "Next Page";
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // _previousButton
            // 
            this._previousButton.Location = new System.Drawing.Point(259, 603);
            this._previousButton.Name = "_previousButton";
            this._previousButton.Size = new System.Drawing.Size(110, 23);
            this._previousButton.TabIndex = 9;
            this._previousButton.Text = "Previous Page";
            this._previousButton.UseVisualStyleBackColor = true;
            this._previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // _mealsDataGridView
            // 
            this._mealsDataGridView.AllowUserToAddRows = false;
            this._mealsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._mealsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._name,
            this._price});
            this._mealsDataGridView.Location = new System.Drawing.Point(515, 12);
            this._mealsDataGridView.Name = "_mealsDataGridView";
            this._mealsDataGridView.RowHeadersVisible = false;
            this._mealsDataGridView.RowTemplate.Height = 24;
            this._mealsDataGridView.Size = new System.Drawing.Size(472, 591);
            this._mealsDataGridView.TabIndex = 1;
            // 
            // name
            // 
            this._name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._name.HeaderText = "Name";
            this._name.Name = "name";
            this._name.ReadOnly = true;
            // 
            // price
            // 
            this._price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._price.HeaderText = "Unit Price";
            this._price.Name = "price";
            this._price.ReadOnly = true;
            // 
            // _totalLabel
            // 
            this._totalLabel.AutoSize = true;
            this._totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._totalLabel.ForeColor = System.Drawing.Color.DarkRed;
            this._totalLabel.Location = new System.Drawing.Point(792, 606);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(149, 38);
            this._totalLabel.TabIndex = 2;
            this._totalLabel.Text = "Total:0元";
            // 
            // POSCustomerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 662);
            this.Controls.Add(this._totalLabel);
            this.Controls.Add(this._mealsDataGridView);
            this.Controls.Add(this._mealGroupBox);
            this.Name = "POSCustomerSideForm";
            this.Text = "Form1";
            this._mealGroupBox.ResumeLayout(false);
            this._mealGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _mealGroupBox;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.Button _previousButton;
        private System.Windows.Forms.DataGridView _mealsDataGridView;
        private System.Windows.Forms.Label _totalLabel;
        private System.Windows.Forms.Label _pageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _price;
    }
}
