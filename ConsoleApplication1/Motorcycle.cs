
// FILE         :Motorcycle.cs
// PROJECT      :PROG 2120
// PROGRAMMER   :XIAODONG MENG(6815328)  & SAMEER SAPRA(6845382)
// FIRST VERSION:2014/9/23
// DESCRIPTION  :This file provide the implementation of the subclass Motorcycle.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Motorcycle : Vehicle
    {
        //The additional data number for Truck class
        private string motorcycle_type;

        public string Motorcycle_type { get { return motorcycle_type; } set { motorcycle_type = value; } }


        // FUNCTION         : Motorcycle
        // DESCRIPTION      : Constructor of the Motorcycle class. Call the baseclass's constructor first, then initialize the additional data number of the Motorcycle class.
        // 
        // PARAMETERS       : string  strManufacter   : The initial value of manufacture datanumber;
        //                    string  strModel        : The initial value of the model datanumber;
        //                    int     nModelYear      : The initial value of the model_year datanumber;
        //                    int     nInitialPrice   : The Initial value of the initial_purchase_price datanumber;
        //                   string  nInitialPrice   : The initial value of the nPurchaseDate datanumber;
        //                   int     nOdometer       : The initial value of the  nOdometer datanumber;
        //                   int     nEngineSize     :The initial value of the   nEngineSize datanumber;
        // RETURNS          :
        //                  void

        public Motorcycle(string strManufacture, string strModel, int nModelYear, int nInitialPrice, string nPurchaseDate, int nOdometer, int nEngineSize, string type)
            : base(strManufacture, strModel, nModelYear, nInitialPrice, nPurchaseDate, nOdometer, nEngineSize)
        {
            motorcycle_type = type;
        }


        //
        //FUNCTION          :GetCurrentValue
        // DESCRIPTION      :Get the current of a motorcycle.
        //
        // PARAMETERS       : void
        // RETURNS          :
        //                  int : the current of a motorcycle.
        public override int GetCurrentValue()
        {
            int diff = DateTime.Now.Year - Convert.ToDateTime(Purchase_date).Year;
            double ftemp = Initial_purchase_price;
            for (int i = 0; i < diff; i++)
            {
                ftemp = ftemp * 0.85;
            }
            if ((int)ftemp < 1500)
            {
                ftemp = 1500;
            }
            return (int)ftemp;
        }

        //
        //FUNCTION          :Show
        // DESCRIPTION      :Show all the information of a motorcycle
        //
        // PARAMETERS       :void
        // RETURNS          :void
        //
        public override void Show()
        {
            base.Show();
            System.Console.WriteLine("9. Type of motorcycle \t\t\t= " + motorcycle_type);

        }

    }
}
