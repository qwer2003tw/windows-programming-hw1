using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSOrderingSystem
{
    public partial class StartUpForm : Form
    {
        POSCustomerSideForm _customerSideForm;
        POSRestaurantSideForm _restaurantSideForm;
        public StartUpForm()
        {
            _customerSideForm = new POSCustomerSideForm();
            _restaurantSideForm = new POSRestaurantSideForm();
            InitializeComponent();
        }

        /// <summary>   Event handler. Called by _customerButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickCustomerButton(object sender, EventArgs e)
        {
            _customerSideForm.Show();
            ((Button)sender).Enabled = false;
            _customerSideForm.FormClosing += this.EnableCustomerButton;
        }

        /// <summary>   Enables the customer button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="args">     Form closing event information. </param>

        private void EnableCustomerButton(object sender, FormClosingEventArgs args)
        {
            args.Cancel = true;
            _customerSideForm.Hide();
            _customerButton.Enabled = true;
        }

        /// <summary>   Event handler. Called by _restaurantButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickRestaurantButton(object sender, EventArgs e)
        {
            _restaurantSideForm.Show();
            _restaurantButton.Enabled = false;
            _restaurantSideForm.FormClosing += this.EnableRestaurantButton;
        }

        /// <summary>   Enables the restaurant button. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="args">     Form closing event information. </param>

        private void EnableRestaurantButton(Object sender, FormClosingEventArgs args)
        {
            args.Cancel = true;
            _restaurantSideForm.Hide();
            _restaurantButton.Enabled = true;
        }

        /// <summary>   Event handler. Called by _exitButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>

        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
