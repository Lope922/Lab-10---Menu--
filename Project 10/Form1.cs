﻿using System;
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

        //public struct Order
        //{
        //    //public string Dish;
        //    //public List<string> Addons;
        //    //public string addonString; 
        //    //public int DishPrice; 
        //}

        // create a variable to store the food type selected. 
        FoodTypes DishSelection = new FoodTypes();
        
        public Order newOrder = new Order(); 

        // exit button event
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

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
                newOrder.Dish = DishSelection.ToString();

                


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

        //public List<string> GetAddOns(GroupBox gbAddons, List<String> addOns)
        public List<string> GetAddOns(Order obj)
        {
            // use the list to store the addons
            //original line of code that uses lambda expressions and loops over the control form 
            //var checkedCbs = groupBox2.Controls.OfType<CheckBox>().Where(c => c.Visible && c.Checked);

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        newOrder.SelectedAddons.Add(chk.Text.ToString());
                    }
                }
            }

            if (obj.SelectedAddons.Count == 0)
            {
                // then don't display add ons 

                // or addon's equals none 
            }
            else if (obj.SelectedAddons.Count > 0)
            {
                for (int i = 0; i < obj.SelectedAddons.Count - 1; i++)
                {
                    obj.GetAddOnsString += obj.SelectedAddons[i];
                }
            }
            return newOrder.SelectedAddons;
        }
        #endregion 

        public void DisplayAddOn(Order obj)
        {
           // variable to store string 
            //foreach (string s in obj.SelectedAddons)
            //{
            //    obj.Dish  += s + ","; 
            //}
            MessageBox.Show("Dish " + newOrder.Dish + "Dish Addons: " + newOrder.GetAddOnsTOaString + "Price:" + obj.DishPrice.ToString());
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


