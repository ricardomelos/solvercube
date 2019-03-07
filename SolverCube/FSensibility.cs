using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolverCube
{
    public partial class FSensibility : Form
    {
        private int* intRed;
        private int* intGreen;
        private int* intBlue;
        private int* intRange;

        public FSensibility(ref int *intRedRef, ref int *intGreenRef, ref int *intBlueRef, ref int *intRangeRef)
        {
            InitializeComponent();
            unsafe
            {
                intRed = intRedRef;
                intGreen = intGreenRef;
                intBlue = intBlueRef;
                intRange = intRangeRef;
            }                
           
        }
        private void FSensibility_Load(object sender, EventArgs e)
        {
            unsafe
            {
                hscRed.Value = *intRed;
                hscGreen.Value = *intGreen;
                hscBlue.Value = *intBlue;
                hscRange.Value = *intRange;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btCancel_Click(sender, e);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            unsafe
            {
                *intRed = hscRed.Value;
                *intGreen = hscGreen.Value;
                *intBlue = hscBlue.Value;
                *intRange = hscRange.Value;
            }

        }

        
    }
}
