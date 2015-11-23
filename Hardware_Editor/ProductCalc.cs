using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Editor
{

    class ProductCalc
    {
        public static List<string> GraphiccardType = new List<string> { "gtx1", "gty2", "gtx3" };
        public static List<int> GraficardPrice = new List<int> { 200, 500, 150 };
        public static List<string> ProcessorType = new List<string> { "i5", "i7", "i3" };
        public static List<int> ProcessorPrice = new List<int> { 250, 300, 150 };
        public static List<string> MainboardType = new List<string> { "arock1", "arock2", "arock3" };
        public static List<int> MainboardPrice = new List<int> { 60, 100, 130 };


        public static Ram RamCalculation(int Price)
        {
            Ram ClassNeededRamCalc = new Ram();
            Ram.PriceReturned = 0;
            Ram.RamName = "";
            if (Price > 1000)
            {
                Ram.PriceReturned = 151;
                Ram.RamName = "16gb";

            }
            else if (Price < 1500 && Price > 500)
            {
                Ram.PriceReturned = 100;
                Ram.RamName = "8gb";
            }
            else if (Price < 500)
            {
                Ram.PriceReturned = 100;
                Ram.RamName = "8gb";
            }
            return ClassNeededRamCalc;

        }


        //Adds the matching product name
        public static string Adding(double Price, Component Type)
        {
            string ProductName = "";
            List<int> ArrayElements = new List<int>();
            List<string> ArrayTypes = new List<string>();
            /*switch (Type)
            {
                case "Graphiccard":
                    ArrayElements = GraficardPrice;
                    break;
                case "Processor":
                    ArrayElements = ProcessorPrice;
                    break;
            }*/
            if (Type == Component.GraphicCard)
            {
                ArrayElements = GraficardPrice;
                ArrayTypes = GraphiccardType;
            }
            else if (Type == Component.Processor)
            {
                ArrayElements = ProcessorPrice;
                ArrayTypes = ProcessorType;
            }
            for (int i = 0; i < ArrayElements.Count; i++)
            {
                if (ArrayElements[i] == Price)
                {
                    ProductName = ArrayTypes[i];
                }

            }
            if (Price == 0)
            {
                ProductName = "Not enough money";
                
            }
            return ProductName;
        }

        //Looks for the right Product
        public static double ProductCalculation(double Price, Component Type)
        {
            int MaxPrice = 0;
            List<int> ProductPrice = new List<int>();
            //List<int> GraficardPrice = new List<int>();

            /*switch (Type)
            {
                case "Processor":
                    ProductPrice = ProcessorPrice;
                    break;
                case "Graphiccard":
                    ProductPrice = GraficardPrice;
                    break;
                
            }*/
            if (Type == Component.Processor)
            {
                ProductPrice = ProcessorPrice;
            }
            else if (Type == Component.GraphicCard)
            {
                ProductPrice = GraficardPrice;
            }

            

            for (int i = 0; i < ProductPrice.Count; i++)
            {

                if ((MaxPrice < ProductPrice[i]) && (ProductPrice[i] < Price))
                {
                    MaxPrice = ProductPrice[i];

                }
                

            }
            
            return MaxPrice;


        }
    }
    enum Component //: Byte
    {
        GraphicCard, 
        Processor
    }
}

