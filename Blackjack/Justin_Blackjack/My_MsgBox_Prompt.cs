using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Justin_Blackjack
{
    public partial class My_MsgBox_Prompt : Form
    {
        public My_MsgBox_Prompt()
        {
            InitializeComponent();
        }

        private void myMessageBox_Load(object sender, EventArgs e)
        {

        }

        int myReturn = -1;

        public int show() {
            //On calling of this function create an instance of this form which is equal to the called instance 
            //using myMessageBox instance = this; the reason for this is so that the form that is then displayed 
            //is equal to the CURRENT instance of this form and not a new one that is created if new was used.
            My_MsgBox_Prompt box = this;
            //Display the form in showDialog form. 
            box.ShowDialog();

            //Create two on click listeners for each button, that waits for a click then triggers an event. 
            btnAnswer_One.Click += new EventHandler(this.btnAnswer_One_Click);
            btnAnswer_Two.Click += new EventHandler(this.btnAnswer_Two_Click);
            //After the two events trigger close the instance and return the values.
            this.Close();
           return myReturn;

        }

        private void btnAnswer_One_Click(object sender, EventArgs e)
        {
            //On click of answ one set the return value to 1.
            myReturn = 1;
            this.Close();
        }

        private void btnAnswer_Two_Click(object sender, EventArgs e)
        {
            //On click of answ two set the return value to 11.
            myReturn = 11;
            this.Close();
        }
    }
}
