using Lab09_CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_CustomerManager
{
    public partial class CustomerViewer : Form
    {
        public CustomerViewer()
        {
            InitializeComponent();
        }
        SampleContext context;
        byte[] Ph;
    }
}
