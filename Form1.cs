using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int line = 0;

        private void submitButton_Click(object sender, EventArgs e)
        {
            int numberOfCheckboxes = Convert.ToInt32(numCheckboxTextbox.Text);

            for (int i = 0; i < numberOfCheckboxes; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = false;
                checkBox.Text = "";

                //Learned from doing this that you can't assign the checkbox sign manually with checkbox.Size = blah,
                //you have to create this System.Drawing Object
                //Also we are setting the size manually because if we don't the checkbox has blank space to the right that overlaps and obscures other checkboxes
                checkBox.Size = new System.Drawing.Size(15, 15);

                //In the below line of code you can change the number after "i" to space the checkboxes further apart horizontally,
                //and the number after "line" to space them further apart vertically
                checkBox.Location = new System.Drawing.Point(10 + (i*20), 60 + (line*25));
                this.Controls.Add(checkBox);
            }
        }

        private void newLineButton_Click(object sender, EventArgs e)
        {
            //See submitButton_Click for use. This is intended to start a new row of checkboxes
            //Bad comment that should not be allowed
            line++;
        }
    }
}
