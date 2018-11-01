// file:	Model\Order.cs
//
// summary:	Implements the order class

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSOrderingSystem.Model
{
    /// <summary>   An order. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

    public class Order : INotifyPropertyChanged
    {
        /// <summary>   Occurs when a property value changes. </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>   The order items. </summary>
        readonly BindingList<OrderItem> _orderItems;

        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

        public Order()
        {
            _orderItems = new BindingList<OrderItem>();
            _orderItems.ListChanged += _meals_ListChanged;
        }

        /// <summary>   Event handler. Called by _meals for list changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        List changed event information. </param>

        private void _meals_ListChanged(object sender, ListChangedEventArgs e)
        {
            NotifyPropertyChanged(nameof(TotalPrice));
        }

        /// <summary>   Gets the order items. </summary>
        ///
        /// <value> The order items. </value>

        public BindingList<OrderItem> OrderItems
        {
            get
            {
                return _orderItems;
            }
        }

        /// <summary>   Gets the total number of price. </summary>
        ///
        /// <value> The total number of price. </value>

        public string TotalPrice
        {
            get
            {
                return $"Total:{GetTotalOfPrice()}元";
            }
        }

        /// <summary>   Deletes the meal described by index. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="index">    Zero-based index of the. </param>

        public void DeleteMeal(int index)
        {
            _orderItems.RemoveAt(index);
            NotifyPropertyChanged(nameof(TotalPrice));
        }

        /// <summary>   Adds a meal. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="meal"> The meal. </param>

        public void AddMeal(Meal meal)
        {
            var result = _orderItems.SingleOrDefault(x => x.Name == meal.Name);
            if (result != null)
            {
                result.Quantity++;
            }
            else
            {
                OrderItem orderItem = new OrderItem(meal);
                _orderItems.Add(orderItem);
            }
            NotifyPropertyChanged(nameof(TotalPrice));
        }

        /// <summary>   Gets total of price. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   The total of price. </returns>

        private int GetTotalOfPrice()
        {
            return _orderItems.Sum(item => item.Subtotal);
        }

        /// <summary>   Notifies a property changed. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="propertyName"> Name of the property. </param>

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
