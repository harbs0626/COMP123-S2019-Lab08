using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab08
{
    public partial class Lab08Form : Form
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public string Username { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the Constructor for Lab08Form
        /// </summary>
        public Lab08Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method clears the text boxes on the form
        /// </summary>
        private void ClearForm()
        {
            this.IDTextBox.Clear();
            this.NameTextBox.Clear();
            this.AgeTextBox.Clear();
            this.SubmitButton.Enabled = false;
            this.GenerateID();
        }

        /// <summary>
        /// This is the Event Handler for the SubmitButton click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Username = this.NameTextBox.Text;
            UserAge = float.Parse(this.AgeTextBox.Text);
            this.OutputLabel.Text = $"Name: {this.NameTextBox.Text} - Age: {this.AgeTextBox.Text}";
            this.ClearForm();
        }

        /// <summary>
        /// This is the Event Handler for the NameTextBox_TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SubmitButton.Enabled = (this.NameTextBox.Text.Length == 0) ? false : true;
        }

        /// <summary>
        /// This is the Event Handler for the AgeTextBox_TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(this.AgeTextBox.Text);
                this.SubmitButton.Enabled = (this.NameTextBox.Text.Length == 0 && this.AgeTextBox.Text.Length > 0) ? false : true;
            }
            catch
            {
                this.SubmitButton.Enabled = false;
            }
        }

        /// <summary>
        /// This is the Event Handler for the Lab08Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void GenerateID()
        {
            int fNum = new Random().Next(0, 99);
            int sNum = new Random().Next(1000, 9999);
            string idNum = Convert.ToString(fNum) + "-" +
                Convert.ToString(sNum);
            this.IDTextBox.Text = idNum;
        }
    }
}
