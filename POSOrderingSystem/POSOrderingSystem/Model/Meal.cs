// file:	Model\Meal.cs
//
// summary:	Implements the meal class

using System;
using System.ComponentModel;

namespace POSOrderingSystem.Model
{
    /// <summary>   A meal. </summary>
    ///
    /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>

    public class Meal : INotifyPropertyChanged
    {
        /// <summary>   The name. </summary>
        string _name = string.Empty;
        /// <summary>   The price. </summary>
        int _price = 0;
        /// <summary>   The description. </summary>
        string _description = string.Empty;
        /// <summary>   Full pathname of the image file. </summary>
        string _imagePath = string.Empty;
        /// <summary>   The category. </summary>
        Category _category = new Category();
        /// <summary>   The dollar. </summary>
        const string DOLLAR = "元";

        /// <summary>   Occurs when a property value changes. </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>

        [DisplayName("Name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        /// <summary>   Gets or sets the price. </summary>
        ///
        /// <value> The price. </value>

        [DisplayName("Unit Price")]
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                NotifyPropertyChanged(nameof(Price));
            }
        }

        /// <summary>   Gets or sets the descript. </summary>
        ///
        /// <value> The descript. </value>

        public string Descript
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                NotifyPropertyChanged(nameof(Descript));
            }
        }

        /// <summary>   Gets or sets the full pathname of the image file. </summary>
        ///
        /// <value> The full pathname of the image file. </value>

        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;
                NotifyPropertyChanged(nameof(ImagePath));
            }
        }

        /// <summary>   Gets or sets the category. </summary>
        ///
        /// <value> The category. </value>

        [DisplayName("Category")]
        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                NotifyPropertyChanged(nameof(Category));
            }
        }

        /// <summary>   Gets button text. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 9/25/2018. </remarks>
        ///
        /// <returns>   The button text. </returns>

        public string GetButtonText()
        {
            return $"{_name}{Environment.NewLine}${_price}{DOLLAR}";
        }

        /// <summary>   Gets button data. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 10/9/2018. </remarks>
        ///
        /// <param name="propertyName"> Name of the property. </param>
        ///
        /// ### <returns>   An array of object. </returns>

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>   Makes a deep copy of this object. </summary>
        ///
        /// <remarks>   Chen-Tai,Peng, 2018/10/31. </remarks>
        ///
        /// <returns>   A copy of this object. </returns>

        public Meal Clone()
        {
            return new Meal()
            {
                Category = new Category() { Name = this.Category.Name },
                Descript = this.Descript,
                ImagePath = this.ImagePath,
                Name = this.Name,
                Price = this.Price
            };
        }
    }
}
