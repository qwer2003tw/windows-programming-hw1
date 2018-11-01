using System.ComponentModel;

namespace POSOrderingSystem.Model
{

    public class OrderItem : INotifyPropertyChanged
    {
        readonly Meal _meal;
        public OrderItem(Meal meal)
        {
            _meal = meal;
            _meal.PropertyChanged += _meal_PropertyChanged;
        }

        /// <summary>   Event handler. Called by _meal for property changed events. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Property changed event information. </param>

        private void _meal_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyPropertyChanged(nameof(Subtotal));
        }

        int _quantity = 1;
        const string DELETE_TEXT = "X";

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>   Gets the delete. </summary>
        ///
        /// <value> The delete. </value>

        [DisplayName("Delete")]
        public string Delete
        {
            get
            {
                return DELETE_TEXT;
            }
        }

        /// <summary>   Gets the name. </summary>
        ///
        /// <value> The name. </value>

        [DisplayName("Name")]
        public string Name
        {
            get
            {
                return _meal.Name;
            }
        }
        /// <summary>   Gets the category. </summary>
        ///
        /// <value> The category. </value>

        [DisplayName("Category")]
        public string Category
        {
            get
            {
                return _meal.Category.Name;
            }
        }
        /// <summary>   Gets the price. </summary>
        ///
        /// <value> The price. </value>

        [DisplayName("Unit Price")]
        public int Price
        {
            get
            {
                return _meal.Price;
            }
        }

        /// <summary>   Gets or sets the quantity. </summary>
        ///
        /// <value> The quantity. </value>

        [DisplayName("Qty")]
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                NotifyPropertyChanged(nameof(Quantity));
                NotifyPropertyChanged(nameof(Subtotal));
            }
        }

        /// <summary>   Gets the subtotal. </summary>
        ///
        /// <value> The subtotal. </value>

        [DisplayName("Subtotal")]
        public int Subtotal
        {
            get
            {
                return _meal.Price * _quantity;
            }
        }
        /// <summary>   Gets the descript. </summary>
        ///
        /// <value> The descript. </value>

        public string Descript
        {
            get
            {
                return _meal.Descript;
            }
        }

        /// <summary>   Gets the full pathname of the image file. </summary>
        ///
        /// <value> The full pathname of the image file. </value>

        public string ImagePath
        {
            get
            {
                return _meal.ImagePath;
            }
        }
                       
        /// <summary>   Gets button data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <returns>   An array of object. </returns>

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

