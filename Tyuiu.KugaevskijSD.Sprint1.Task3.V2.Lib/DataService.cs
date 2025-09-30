namespace Tyuiu.KugaevskijSD.Sprint1.Task3.V2.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;


    public class DataService : ISprint1Task3V2
    {
        public double PurchaseAmount(double priceNotebook, int amountNotebook, double pricePencil, int amountPencil)
        {
            return Math.Round(((priceNotebook * amountNotebook) + (pricePencil * amountPencil)), 3);
        }
    }
