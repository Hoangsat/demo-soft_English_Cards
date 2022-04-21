using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary dict;
        public Form1()
        {
            InitializeComponent();
            dict= new Dictionary();
            ShowCard(1);
        }
        public void ShowCard(int curr)
        {
            if (dict.Image(curr))
            picture_card.Image= Image.FromFile(dict.Image(curr));
        }

        
    }
}
