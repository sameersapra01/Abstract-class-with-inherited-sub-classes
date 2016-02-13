
// FILE         :Automobile.cs
// PROJECT      :PROG 2120
// PROGRAMMER   :XIAODONG MENG(6815328)  & SAMEER SAPRA(6845382)
// FIRST VERSION:2014/9/23
// DESCRIPTION  :
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Automobile : Vehicle
    {
        //The additional properties of the automobile class
        private int number_doors;
        private string fuel_type;



        //The accessors for the datanumber
        public int Number_doors { get { return number_doors; } set { number_doors = value; } }

        public string Fuel_type { get { return fuel_type; } set { fuel_type = value; } }


        // FUNCTION         :Automobile
        // DESCRIPTION      :The constructor of Automobile class;
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
        public Automobile(string strManufacture, string strModel, int nModelYear, int nInitialPrice, string nPurchaseDate, int nOdometer, int nEngineSize, int nNumberDoors, string strFuelType)
            : base(strManufacture, strModel, nModelYear, nInitialPrice, nPurchaseDate, nOdometer, nEngineSize)
        {
            number_doors = nNumberDoors;
            fuel_type = strFuelType;
        }


        //
        //FUNCTION          :Show
        // DESCRIPTION      :Show all the information
        //
        // PARAMETERS       :void
        // RETURNS          :void
        //
        public override void Show()
        {
            base.Show();
            System.Console.WriteLine("9. Number of doors is\t\t\t= " + number_doors);
            System.Console.WriteLine("10. Type of fuel is\t\t\t= " + fuel_type);
        }


        //
        //FUNCTION          :GetCurrentValue
        // DESCRIPTION      :Get the current value of a automobile 
        //
        // PARAMETERS       :void
        // RETURNS          :
        //                  int :The current value of a automobile
        public override int GetCurrentValue()
        {
            int diff = DateTime.Now.Year - Convert.ToDateTime(Purchase_date).Year;
            double ftemp = Initial_purchase_price;
            for (int i = 0; i < diff; i++)
            {
                ftemp = ftemp * 0.85;
            }

            if (Odometer_reading > 20000)
            {
                ftemp -= (Odometer_reading - 20000) * 0.1;
            }

            if ((int)ftemp < 500)
            {
                ftemp = 500;
            }
            return (int)ftemp;
        }



    }
}
