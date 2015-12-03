using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_10
{
    public class Order
    {

        private string dish;
        private List<string> addons;
        private int dishPrice;

        // a series of strings; 
        private string AddOnStringBuilder;
       

        public int DishPrice
        {
            get
            {
                return dishPrice;
            }

            set
            {
                dishPrice = value;
            }
        }

        public string Dish
        {
            get
            {
                return dish;
            }
            set
            {
                dish = value;
            }
        }

        public List<string> SelectedAddons
        {
            get
            {
                return addons;
            }
            set
            {
                addons = value;
            }
        }

        
        public string ReadDish()
        {
            this.Dish = dish;
            return this.Dish;
        }

        public string GetAddOnsTOaString
        {
            get
            {
                return AddOnStringBuilder;
            }
            set
            {
                AddOnStringBuilder = value;
            }
        }
    }
}