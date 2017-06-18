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
        Settings settings;
        const string SETTINGS_FILE = "settings.json";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            settings = Settings.LoadSettings(SETTINGS_FILE);
            ChkAscending.Checked = settings.AscendingOrder;
            ChkSaveNumbers.Checked = settings.RememberNumbers;
            if(settings.RememberNumbers)
                TxtNumbers.Text = string.Join(", ", settings.Numbers.Select(i => i.ToString()));

            Console.SetOut(new ControlWriter(TxtConsole));

            Console.WriteLine("Please enter a set of numbers into the textbox above separated by commas (',').");
            Console.WriteLine("Then select a sorting algorithm to run.");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetNumberArray();
            if (ChkSaveNumbers.Checked && myNumbers != null)
                settings.Numbers = myNumbers;
            settings.AscendingOrder = ChkAscending.Checked;
            settings.RememberNumbers = ChkSaveNumbers.Checked;
            Settings.SaveSettings(SETTINGS_FILE, settings);
        }

        private void BtnQuickSort_Click(object sender, EventArgs e)
        {
            SetNumberArray();

            Console.WriteLine("Original: ");
            foreach (int num in myNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        private void BtnBubbleSort_Click(object sender, EventArgs e)
        {
            SetNumberArray();

            Console.WriteLine("Original: ");
            foreach (int num in myNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            if (myNumbers != null && myNumbers.Length > 0)
            {
                myNumbers = Sorting.BubbleSort(myNumbers);
                Console.WriteLine("Sorted: ");
                foreach (int number in myNumbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }

        private void BtnInsertSort_Click(object sender, EventArgs e)
        {
            SetNumberArray();

            Console.WriteLine("Original: ");
            foreach (int num in myNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        private void BtnSelectSort_Click(object sender, EventArgs e)
        {
            SetNumberArray();

            Console.WriteLine("Original: ");
            foreach (int num in myNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        private void SetNumberArray()
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
                    return;
                }
                if(myNumbers.Length > 10)
                {
                    Console.WriteLine("Please enter no more than 10 numbers.");
                    return;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error, ensure you have entered the numbers correctly: \r\n{0}", ex.Message);
            }
        }
    }
}
