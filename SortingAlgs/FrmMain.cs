using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgs
{
    public partial class FrmMain : Form
    {
        int[] myNumbers;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Console.SetOut(new ControlWriter(TxtConsole));

            Console.WriteLine("Please enter a set of numbers into the textbox above separated by commas (',').");
            Console.WriteLine("Then select a sorting algorithm to run.");
        }

        private void BtnQuickSort_Click(object sender, EventArgs e)
        {
            SetNumberArrayAndShowResults();
        }

        private void BtnBubbleSort_Click(object sender, EventArgs e)
        {
            SetNumberArrayAndShowResults();
        }

        private void BtnInsertSort_Click(object sender, EventArgs e)
        {
            SetNumberArrayAndShowResults();
        }

        private void BtnSelectSort_Click(object sender, EventArgs e)
        {
            SetNumberArrayAndShowResults();
        }

        private void SetNumberArrayAndShowResults()
        {
            if(TxtNumbers.Text.Length == 0 || TxtNumbers.Text == null)
            {
                Console.WriteLine("Please enter at least two numbers.");
                return;
            }
            try
            {
                myNumbers = Array.ConvertAll(TxtNumbers.Text.Split(','), int.Parse);
                if (myNumbers.Length < 2)
                {
                    Console.WriteLine("Please enter at least two numbers.");
                    myNumbers = null;
                    return;
                }
                if(myNumbers.Length > 10)
                {
                    Console.WriteLine("Please enter no more than 10 numbers.");
                    myNumbers = null;
                    return;
                }
                
                Console.WriteLine("You have entered: ");
                foreach(int num in myNumbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error, ensure you have entered the numbers correctly: \r\n{0}", ex.Message);
            }
        }
    }
}
