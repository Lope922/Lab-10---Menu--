using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Project 10-2: Process lunch orders

For this project, you’ll create a form that accepts a lunch order from the user and then calculates the order subtotal and total.
The design of the Lunch Order form


Operation
For each order, the user selects a main course item and the application displays the associated add-on items. Then, the user can select zero or more of these add-ons.
When the user clicks the Place Order button, the application calculates and displays the subtotal, tax, and total due for the order.

Add-ons
For a hamburger, the three add-on items are: (1) Lettuce, tomato, and onions; (2) Mayonnaise and mustard; and (3) French fries. The price of each is 75 cents.
For a pizza, the three add-on items are: (1) Pepperoni, (2) Sausage, and (3) Olives. The price of each is 50 cents.
For a salad, the three items are (1) Croutons, (2) Bacon bits, and (3) Bread sticks. The price of each is 25 cents.

Specifications
The subtotal is equal to the cost of the main course item, plus the cost of the add-ons. The tax is the subtotal * .0775. And the total due is the subtotal + tax.
When the user selects a main course, the application should remove check marks from any of the add-on items and clear the order totals.
When the user checks or unchecks an add-on item, the application should clear the order totals.

Enhancements
One way to enhance this application would be to have it provide for handling more than one item per order. Then, each time the user clicks the Place Order button, the application should add the item ordered to the order totals. You also need to add a New Order button to clear the order totals and begin a new order. You also want to add a list box to the form that displays the items for each order.

 */
namespace Project_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // create a variable to store the food type selected. 
        FoodTypes DishSelection = new FoodTypes();
        
        public Order newOrder = new Order(); 

        // exit button event
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //todo rewrite each method to refresh the checkbox and uncheck them each time the radiobutton changes position 

        //work in the price as well 

        # region Main Dish Items
        // Check Changed events for main dishes -- Sets sets food type set to enumeration. 
        private void radioButtonHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHamburger.Checked == true)
            {
                DishSelection = FoodTypes.Hamburger;
                UpdateDisplayBasedOnDishSelection(DishSelection); 
            }
        }
        //private enum readFoodTypeSelection(RadioButton rdoButtons)
        private void radioButtonPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPizza.Checked == true)
            {
                DishSelection = FoodTypes.Pizza;
                UpdateDisplayBasedOnDishSelection(DishSelection);
            }
        }
        private void radioButtonSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSalad.Checked == true)
            {
                DishSelection = FoodTypes.Salad;
                UpdateDisplayBasedOnDishSelection(DishSelection); 
            }
        }
        #endregion

        // ADD ITEM to Order EVENT
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // as long as they have made a selection. 
            if (DishSelection.ToString().Equals("none"))
            {
                MessageBox.Show("please make a dish selection from the Dish Group Box", "No dish Selected");
            }
            
            else
            {
                // start creating the order 
                // set dish selection equal to the radio button checked. 
                newOrder.Dish = DishSelection.ToString();

                //selected addons is the list of addons 
                // so getaddons sould return a list or set the list equalt to the neworder selected addons
                newOrder.SelectedAddons = GetAddOns();
                newOrder.GetAddOnsTOaString =  AddOnListToString(); 
                // next comes reading the selcted addons to a displayable text. 

                // then go back and try to wokr with the prices. 

                //newOrder.SelectedAddons = GetAddOns(newOrder);
                DisplayAddOn(newOrder);
            }
        }    

        //TODOS

                // create a method to loop throught the groupboxes and add values to the list of add ons 
                // work up a price sheet based on selection. 
            
            //MessageBox.Show("Selected food type is " + DishSelection.ToString() +
              //"\nFood enum value = " + DishSelection.GetHashCode());

            //read dish selection test that options are displayed properly. 
            //UpdateDisplayBasedOnDishSelection(DishSelection); 
            //DishSelection.Equals(0);


        // DISH SETTINGS - MAKE ADJUSTMENTS HERE TO THE FOOD NAMES AND ADD ONS 

        #region MyMethods
        private void UpdateDisplayBasedOnDishSelection(FoodTypes DishSelection)
        {

            switch (DishSelection.GetHashCode())
            {

                case 1:
                    {
                        checkBox1.Text = "Pepperoni";
                        checkBox1.Visible = true; 
                        checkBox2.Text = "Sausage";
                        checkBox2.Visible = true; 

                        checkBox3.Text = "Cheese";
                        checkBox3.Visible = true;

                        checkBox4.Visible = false;
                        checkBox5.Visible = false; 

                        break;
                    }

                case 2:
                    {
                        checkBox1.Text = "Lettuce";
                        checkBox1.Visible = true; 
                        checkBox2.Text = "Tomato";
                        checkBox2.Visible = true;
                        checkBox3.Visible = true;
                        checkBox3.Text = "Onion";
                        checkBox4.Text = "Mustard";
                        checkBox4.Visible = true;
                        checkBox5.Visible = true;
                        checkBox5.Text = "Mayo";
                        break;
                    }
                case 3:
                    {
                        checkBox1.Text = "Crutons";
                        checkBox1.Visible = true;
                        checkBox2.Text = "Bacon Bits";
                        checkBox2.Visible = true;
                        checkBox3.Text = "Bread Sticks";
                        checkBox3.Visible = true;

                        checkBox4.Visible = false;
                        checkBox5.Visible = false; 

                        break;
                    }
                case 0 :
                    {
                        checkBox1.Visible = false;
                        checkBox2.Visible = false;
                        checkBox3.Visible = false;
                        checkBox4.Visible = false;
                        checkBox5.Visible = false;
                        break;
                        //todo fix salad right now it's tied into no selection made. 
                    }
            }
        }



        //this method reads the combo box and add its to the objects selected add on list 
        public List<string> GetAddOns()
        {
            // use the list to store the addons
            List<string> AO = (groupBoxAddOns.Controls.OfType<CheckBox>().Where(c => c.Visible && c.Checked).Select(c => c.Text).ToList());
            newOrder.SelectedAddons = AO; 
            return newOrder.SelectedAddons; 
        }

        // this loops over the addons list and builds a string from its contents 
        public string AddOnListToString()
        {
            int maxRange = newOrder.SelectedAddons.Count - 1; 
            for (int i = 0; i < maxRange; i++)
            {
                newOrder.GetAddOnsTOaString += "" + newOrder.SelectedAddons[i];
            }
            return newOrder.GetAddOnsTOaString; 
        }
        
        #endregion 

        public void DisplayAddOn(Order obj)
        {
            MessageBox.Show("Dish " + newOrder.Dish + " Dish Addons: " + newOrder.GetAddOnsTOaString + "Price:" + obj.DishPrice.ToString());
        }
        // Experimental below here 
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDisplayBasedOnDishSelection(DishSelection); 
        }
    }
}
    public enum FoodTypes
    {
        none,
        Pizza,
        Hamburger,
        Salad
    }



