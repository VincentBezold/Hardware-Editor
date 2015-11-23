using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hardware_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    

            public int PriceInput()
            {
                int PriceInput = Int32.Parse(Price.Text);
                return PriceInput;
            }







        private void Gaming_Click(object sender, EventArgs e)
        {
            int Price = PriceInput();
            Solution.Content = null;
            double PriceP = ProductCalc.ProductCalculation(Price * (1 / 5.0), Component.Processor);
            double PriceGC = ProductCalc.ProductCalculation(Price * (1 / 5.0), Component.GraphicCard);
            
            string NameGC = ProductCalc.Adding(PriceGC, Component.GraphicCard);
            string NameP = ProductCalc.Adding(PriceP, Component.Processor);
            ProductCalc.RamCalculation(Price);

            Solution.Content = PriceGC + " " + NameGC + "\n" + PriceP + " " + NameP + "\n" + Ram.PriceReturned + " Gb";



        }


        private void Office_Click(object sender, EventArgs e)
            {

            }

            private void Allrounder_Click(object sender, EventArgs e)
            {

            }

            private void Price_TextChanged(object sender, EventArgs e)
            {

            }

        
    }
}
