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
    public partial class POSRestaurantSideForm : Form
    {
        public POSRestaurantSideForm()
        {
            InitializeComponent();
        }

        /// <summary>   Event handler. Called by _okButton for click events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        private void ClickOkButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
