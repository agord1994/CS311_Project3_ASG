namespace CS311_Project3_ASG
{
    public partial class mnForm : Form
    {
        float runningTotal=0;
        String CrustType;
        String[] Toppings;
        public mnForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbCanadianBacon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void CrustTypeMeth()
        {
            if (rdoRegular.Checked)
            {  
                CrustType += "regular crust ";
            }
            else if(rdoThick.Checked)
            {
                CrustType += "thick crust ";
            }
            else if (rdoThin.Checked)
            {
                CrustType += " thin crust ";
            }
            else
            {
                CrustType += "";
            }
        }

        private void rboThick_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboRegular_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rboThin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbPepperoni_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            clear();
            CrustTypeMeth();
            CalculatePizzaSize();
            Summarize();
        }
        private void Summarize()
        {
            //rtfOrderSummary.Text
                String orderSummary= "You Ordered a " + cboPizzaSize.Text + " with "+CrustType+ "and the following toppings:\n";

            if (ckbPepperoni.Checked)
            {
                runningTotal = runningTotal + 2;
                String pep = "Pepperoni\n";
                 orderSummary =orderSummary+pep;

            }//end if 
            if (ckbSausage.Checked)
            {
                runningTotal = runningTotal + 2;
                String saus = "Sausage\n";
                orderSummary =orderSummary+ saus;
            }//end else if
            if (ckbCanadianBacon.Checked)
            {
                runningTotal = runningTotal + 2;
                String bac = "Canadian Bacon\n";
                orderSummary = orderSummary + bac;


            }//end else if
            if (ckbSpicyItalianSausage.Checked)
            {
                runningTotal = runningTotal + 2;
                String iSaus = "Italian Sausage\n";
                orderSummary = orderSummary + iSaus;

            }//end else if
            if (ckbOnion.Checked)
            {
                runningTotal = runningTotal + 1;
                String onion = "Onion\n";
                orderSummary = orderSummary + onion;
            }//end else if
            if (ckbGreenPepper.Checked)
            {
                runningTotal = runningTotal + 1;
                String gp = "Green Pepper\n";
                orderSummary = orderSummary + gp;
            }//end else if
            if (ckbBlackOlives.Checked)
            {
                runningTotal = runningTotal + 1;
                String bo = "Black Olives\n";
                orderSummary = orderSummary + bo;
            }//end else if

            if (ckbGreenOlives.Checked)
            {
                runningTotal = runningTotal + 1;
                String go = "Green Olives\n";
                orderSummary = orderSummary + go;
            }//end else if
            if (ckbBananaPeppers.Checked)
            {
                runningTotal = runningTotal + 1;
                String bp = "Banana Peppers\n";
                orderSummary = orderSummary + bp;
            }//end else if
            if (ckbJalapeno.Checked)
            {
                runningTotal = runningTotal + 1;
                String j = "Jalapenos\n";
                orderSummary = orderSummary + j;
            }//end else if
            if (ckbExtraCheese.Checked)
            {
                runningTotal = runningTotal + 1;
                String ex = "Extra Cheese\n";
                orderSummary = orderSummary + ex;
            }//end else if
            if (ckbMushroom.Checked)
            {
                runningTotal = runningTotal + 1;
                String mush = "Mushroom\n";
                orderSummary = orderSummary + mush;
            }//end else if

            rtfOrderSummary.Text = orderSummary;

            float runningTotalAlias = runningTotal;
            float salesTax= (float)(runningTotalAlias * .06);

            float total= runningTotalAlias+ salesTax;


            txtSubTotal.Text = runningTotal.ToString("C");
            txtTax.Text = salesTax.ToString("C");
            txtTotal.Text = total.ToString("C");


        }//end Summarize
        private void CalculatePizzaSize()
        {
            if (cboPizzaSize.SelectedItem=="Small")
            {
                runningTotal =runningTotal+2;
            }//end if 
            if (cboPizzaSize.SelectedItem == "Medium")
            {
                runningTotal =runningTotal+ 5;
            }//end else if
            if (cboPizzaSize.SelectedItem == "Large")
            {
                runningTotal =runningTotal+ 10;
            }//end else if
            if (cboPizzaSize.SelectedItem == "X-Large")
            {
                runningTotal =runningTotal+ 15;
            }//end else if
            if (cboPizzaSize.SelectedItem == "Ginormous")
            {
                runningTotal =runningTotal+ 20;
            }//end else if
        }//end CalculatePizzaSize

        private void clear()
        {
            runningTotal = 0;
            rtfOrderSummary.Text = "";
            CrustType = "";

        }
    }
}