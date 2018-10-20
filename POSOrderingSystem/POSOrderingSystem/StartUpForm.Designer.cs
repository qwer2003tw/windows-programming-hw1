namespace POSOrderingSystem
{
    partial class StartUpForm
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
            this._customerButton = new System.Windows.Forms.Button();
            this._restaurantButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._startUpPanel = new System.Windows.Forms.TableLayoutPanel();
            this._startUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _customerButton
            // 
            this._customerButton.AutoSize = true;
            this._customerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._customerButton.Location = new System.Drawing.Point(10, 10);
            this._customerButton.Margin = new System.Windows.Forms.Padding(10);
            this._customerButton.Name = "_customerButton";
            this._customerButton.Size = new System.Drawing.Size(756, 122);
            this._customerButton.TabIndex = 0;
            this._customerButton.Text = "Start the Customer Program (Frontend)";
            this._customerButton.UseVisualStyleBackColor = true;
            this._customerButton.Click += new System.EventHandler(this.ClickCustomerButton);
            // 
            // _restaurantButton
            // 
            this._restaurantButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._restaurantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._restaurantButton.Location = new System.Drawing.Point(10, 152);
            this._restaurantButton.Margin = new System.Windows.Forms.Padding(10);
            this._restaurantButton.Name = "_restaurantButton";
            this._restaurantButton.Size = new System.Drawing.Size(756, 122);
            this._restaurantButton.TabIndex = 1;
            this._restaurantButton.Text = "Start the Restaurant Program (Backend)";
            this._restaurantButton.UseVisualStyleBackColor = true;
            this._restaurantButton.Click += new System.EventHandler(this.ClickRestaurantButton);
            // 
            // _exitButton
            // 
            this._exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.Location = new System.Drawing.Point(471, 294);
            this._exitButton.Margin = new System.Windows.Forms.Padding(10);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(295, 122);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // _startUpPanel
            // 
            this._startUpPanel.ColumnCount = 1;
            this._startUpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._startUpPanel.Controls.Add(this._customerButton, 0, 0);
            this._startUpPanel.Controls.Add(this._restaurantButton, 0, 1);
            this._startUpPanel.Controls.Add(this._exitButton, 0, 2);
            this._startUpPanel.Location = new System.Drawing.Point(12, 12);
            this._startUpPanel.Name = "_startUpPanel";
            this._startUpPanel.RowCount = 3;
            this._startUpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._startUpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._startUpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._startUpPanel.Size = new System.Drawing.Size(776, 426);
            this._startUpPanel.TabIndex = 3;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._startUpPanel);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this._startUpPanel.ResumeLayout(false);
            this._startUpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _customerButton;
        private System.Windows.Forms.Button _restaurantButton;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.TableLayoutPanel _startUpPanel;
    }
}