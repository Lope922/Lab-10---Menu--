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
        // a series of strings; 
       private string AddOnStringBuilder;
        private int dishPrice;

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
              AddOnStringBuilder += "" + value;
          }
      }

      //public List<string> GetAddOns()
      //{
      //    // use the list to store the addons
      //    //original line of code that uses lambda expressions and loops over the control form 
      //    //var checkedCbs = groupBox2.Controls.OfType<CheckBox>().Where(c => c.Visible && c.Checked);
          
      //    foreach (Control c in Form1.ActiveForm.Controls)
      //    {
      //        if (c is CheckBox)
      //        {
      //            CheckBox chk = (CheckBox)c;
      //            if (chk.Checked)
      //            {
      //              this.SelectedAddons.Add(chk.Text.ToString());
      //            }
      //        }
      //    }

      //    if (this.SelectedAddons.Count == 0)
      //    {
      //        // then don't display add ons 

      //        // or addon's equals none 
      //    }
      //    else if (this.SelectedAddons.Count > 0)
      //    {
      //        for (int i = 0; i < this.SelectedAddons.Count - 1; i++)
      //        {
      //            this.GetAddOnsString += this.SelectedAddons[i];
      //        }
      //    }
      //    return this.SelectedAddons;
      //}
      //todo fix this tomorrow 

       }
}
        //public override string ToString(string sep)
        //{
        //    // todo look into book example on override to string in class chapter. 
        //   return string.Format("Dish Type: " + Dish + sep + Addons.ToString() + sep + "Price:" + DishPrice);
 
        //}
 