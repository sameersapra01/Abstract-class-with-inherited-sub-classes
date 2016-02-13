//FILE         :Truck.cs
// PROJECT      :PROG 2120
// PROGRAMMER   :XIAODONG MENG(6815328)  & SAMEER SAPRA(6845382)
// FIRST VERSION:2014/9/23
// DESCRIPTION  :This file provide the implementation of the subclass Truck
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Truck : Vehicle
    {
        //The additional data numbers for Truck class
        private float cargo_capacity;
        private float towing_capacity;

        public float Cargo_capacity { get { return cargo_capacity; } set { cargo_capacity = value; } }
        public float Towing_capacity { get { return towing_capacity; } set { towing_capacity = value; } }

        // FUNCTION         :Truck
        // DESCRIPTION      :The constructor for the Truck class.
        // 
        // PARAMETERS       : string  strManufacter   : The initial value of manufacture datanumber;
        //                    string  strModel        : The initial value of the model datanumber;
        //                    int     nModelYear      : The initial value of the model_year datanumber;
        //                    int     nInitialPrice   : The Initial value of the initial_purchase_price datanumber;
        //                   string  nInitialPrice   : The initial value of the nPurchaseDate datanumber;
        //                   int     nOdometer       : The initial value of the  nOdometer datanumber;
        //                   int     nEngineSize     :The initial value of the   nEngineSize datanumber;
        //                   float   fCargoCap       : The initial value of the    cargo_capacity datanumber;
        //                    float  fTowingCap      : The initial value of the   towing_capacity;
        // RETURNS          :
        //                  void
        //The constructor of the Truck class. Call the baseclass's constructor ,then assign the additional data numbers.
        public Truck(string strManufacture, string strModel, int nModelYear, int nInitialPrice, string nPurchaseDate, int nOdometer, int nEngineSize, float fCargoCap, float fTowingCap)
            : base(strManufacture, strModel, nModelYear, nInitialPrice, nPurchaseDate, nOdometer, nEngineSize)
        {
            cargo_capacity = fCargoCap;
            towing_capacity = fTowingCap;
        }



        //FUNCTION          :GetCurrentValue
        // DESCRIPTION      :Get the current value of a truck;
        //
        // PARAMETERS       :void
        // RETURNS          :
        //                   int: The current value of a truck;
        public override int GetCurrentValue()
        {
            int diff = DateTime.Now.Year - Convert.ToDateTime(Purchase_date).Year;
            double ftemp = Initial_purchase_price;
            for (int i = 0; i < diff; i++)
            {
                ftemp = ftemp * 0.8;
            }

            if (Odometer_reading > 25000)
            {
                ftemp -= (Odometer_reading - 25000) * 0.18;
            }

            if ((int)ftemp < 0)
            {
                ftemp = 0;
            }
            return (int)ftemp;

        }


        //FUNCTION          : Show
        // DESCRIPTION      : Show all the information of a truck.
        //
        // PARAMETERS       :void 
        // RETURNS          :
        //                   void
        public override void Show()
        {
            base.Show();
            System.Console.WriteLine("9. Cargo capacity \t\t\t= " + cargo_capacity);
            System.Console.WriteLine("10. Towing capacity \t\t\t= " + towing_capacity);
        }
    }
}
