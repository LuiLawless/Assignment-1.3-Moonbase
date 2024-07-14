//Assignment 1.3: Moonbase by Robert Delgado
//With assistance from my teacher Mrs. Coddington and some assistance
//from OpenAI chatgpt


using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the height and width of the form
            this.Height = 1080;
            this.Width = 1920;

            // Define the path to the moonbase background image
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "debug", "moonbase.jpeg");

            // Check if the image file exists. OpenAI insisted I needed to use a
            //if statement to make sure the file path existed. We didnt cover this in our
            //lecture sessions, so I had to research. 
            if (File.Exists(imagePath))
            {
                // Set the background image
                this.BackgroundImage = Image.FromFile(imagePath);
                // Set the background image layout to stretch
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                // Display an error message if the image file is not found because we
                //to display an error.
                MessageBox.Show("Image not found: " + imagePath);
            }
        }
    }
}
