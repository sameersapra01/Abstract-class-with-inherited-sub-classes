//
// FILE         :Vehicle.cs
// PROJECT      :PROG 2120
// PROGRAMMER   :XIAODONG MENG(6815328)  & SAMEER SAPRA(6845382)
// FIRST VERSION:2014/9/23
// DESCRIPTION  :This file provide a abstract class for all the subclass(Truck, Automobile, Motorcycle)
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Vehicle
    {
        private string vehicle_Id;  //Used to get a specificted instance.
        private string manufacture;
        private string model;
        private int model_year;
        private int initial_purchase_price;
        private string purchase_date;
        private int odometer_reading;
        private int size_of_engine;

        //All accessor for the data number
        public string Vehicle_Id { get { return vehicle_Id; } set { vehicle_Id = value; } }

        public string Manufacture { get { return manufacture; } set { manufacture = value; } }

        public string Model { get { return model; } set { model = value; } }

        public int Model_year { get { return model_year; } set { model_year = value; } }

        public int Initial_purchase_price { get { return initial_purchase_price; } set { initial_purchase_price = value; } }

        public string Purchase_date { get { return purchase_date; } set { purchase_date = value; } }

        public int Odometer_reading { get { return odometer_reading; } set { odometer_reading = value; } }

        public int Size_of_engine { get { return size_of_engine; } set { size_of_engine = value; } }



        // FUNCTION         :Vehicle
        // DESCRIPTION      :Constructor of the abstract class;
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
        public Vehicle(string strManufacture, string strModel, int nModelYear, int nInitialPrice, string nPurchaseDate, int nOdometer, int nEngineSize)
        {

            manufacture = strManufacture;
            model = strModel;
            model_year = nModelYear;
            initial_purchase_price = nInitialPrice;
            purchase_date = nPurchaseDate;
            odometer_reading = nOdometer;
            size_of_engine = nEngineSize;
        }


        // FUNCTION         : Show
        // DESCRIPTION     : Show all the information in the base class.
        // 
        // PARAMETERS       :void
        // RETURNS          :void
        //

        public virtual void Show()
        {
            System.Console.WriteLine("## Vehicle id is\t\t\t= " + vehicle_Id);
            System.Console.WriteLine("1. Manufacturer is\t\t\t= " + manufacture);
            System.Console.WriteLine("2. Model is \t\t\t\t= " + model);
            System.Console.WriteLine("3. Model Year is \t\t\t= " + model_year);
            System.Console.WriteLine("4. Initial Purchase Price is \t\t= " + initial_purchase_price);
            System.Console.WriteLine("5. Current value of vehicle is \t\t= " + this.GetCurrentValue());
            System.Console.WriteLine("6. Purchase Date is \t\t\t= " + purchase_date);
            System.Console.WriteLine("7. Current odometer reading(in km) is   = " + odometer_reading);
            System.Console.WriteLine("8. Size of engine is \t\t\t= " + size_of_engine);
        }



        // FUNCTION         :GetCurrentValue
        // DESCRIPTION      :Get the current value.
        // 
        // PARAMETERS       :void
        // RETURNS          :
        //                   int: The current value of a vehicle.

        public abstract int GetCurrentValue();

    }


}
