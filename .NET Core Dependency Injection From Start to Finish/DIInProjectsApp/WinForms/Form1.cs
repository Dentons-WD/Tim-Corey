using DIDemoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1(IMessages messages)
        {
            InitializeComponent();

            helloText.Text = messages.SayHello();
            goodbyeText.Text = messages.SayGoodBye();
        }

    }
}
