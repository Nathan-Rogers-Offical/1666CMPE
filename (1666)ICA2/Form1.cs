//***********************************************************************************
//Program: Form1.cs (File name: (1666)ICA2
//Description: A form that displays when certain actions, like load, paint, and closing happen
//Date: Jan. 16/2024
//Author: Nathan Rogers
//Course: CMPE1666
//Class: CNTA01
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {

        //********************************************************************************************
        //Method: public Form1()
        //Purpose: tells the user the form is constructing
        //*********************************************************************************************

        public Form1()
        {
            InitializeComponent(); // Begins the creation of our form
            System.Diagnostics.Trace.WriteLine($"Constucting...");
        }

        //********************************************************************************************
        //Method: private void Form1_Load(object sender, EventArgs e)
        //Purpose: tells the user the form is loading
        //Parameters: object sender - sends the information to our Form1.cs [Design]
        // EventArgs e - Obtains what event happens that will be sent due to sender
        //*********************************************************************************************

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"The Form is loading..."); // Write when the form is opening for the first time
        }

        //********************************************************************************************
        //Method: private void Form1_Activated(object sender, EventArgs e)
        //Purpose: Displays when the form has been activated
        //Parameters: object sender - sends the information to our Form1.cs [Design]
        // EventArgs e - Obtains what event happens that will be sent due to sender
        //*********************************************************************************************

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Note that DateTime is just to show when this event happened
            System.Diagnostics.Trace.WriteLine($"Activated at: {DateTime.Now}"); // Write when the form is open / visable, deactivated when exited
        }

        //********************************************************************************************
        //Method: private void Form1_Shown(object sender, EventArgs e)
        //Purpose: Displays when the form was shown to the user
        //Parameters: object sender - sends the information to our Form1.cs [Design]
        // EventArgs e - Obtains what event happens that will be sent due to sender
        //*********************************************************************************************

        private void Form1_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"The Form was shown at: {DateTime.Now}"); // Write when the form was displayed for the user
        }

        //********************************************************************************************
        //Method: private void Form1_Paint(object sender, PaintEventArgs e)
        //Purpose: Displays when the window of the form has been altered
        //Parameters: object sender - sends the information to our Form1.cs [Design]
        // PaintEventArgs e - Obtains what event happens that will be sent due to sender
        //*********************************************************************************************

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"The Form was painted at: {DateTime.Now}"); // Write when the form window has been altered
        }

        //********************************************************************************************
        //Method: private void Form1_MouseClick(object sender, MouseEventArgs e)
        //Purpose: Displays when a mouse click was detected
        //Parameters: object sender - sends the information to our Form1.cs [Design]
        // MouseEventArgs e - Obtains what event happens that will be sent due to sender
        //*********************************************************************************************

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"A click was detected at: {DateTime.Now}"); // Write when the form detects a mouse click
        }

        //********************************************************************************************
        //Method: private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //Purpose: Displays why the form is closing
        //Parameters: object sender - sends the information to our Form1.cs [Design]
        // FormClosingEventArgs e - Obtains what event happens that will be sent due to sender
        //*********************************************************************************************

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Note that CloseReason is just showing for what reason the form is closing
            System.Diagnostics.Trace.WriteLine($"The Form is closing due too: {e.CloseReason}"); // Write when the form is closing
        }

        //********************************************************************************************
        //Method: private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //Purpose: Displays when the form closed
        //Parameters: object sender - sends the information to our Form1.cs [Design]
        // FormClosedEventArgs e - Obtains what event happens that will be sent due to sender
        //*********************************************************************************************

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"The Form was closed at: {DateTime.Now}"); // Write when the form is fully closed
        }

        //********************************************************************************************
        //Method: private void Form1_Deactivate(object sender, EventArgs e)
        //Purpose: Displays that the form is deactivating
        //Parameters: object sender - sends the information to our Form1.cs [Design]
        // EventArgs e - Obtains what event happens that will be sent due to sender
        //*********************************************************************************************

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"Deactivated at: {DateTime.Now} ... Goodbye World!"); // Write when the form is closed / not visable, activated when re-opened
        }

    }
}
