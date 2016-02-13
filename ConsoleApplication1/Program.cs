//
// FILE         :Program.cs
// PROJECT      :PROG 2120
// PROGRAMMER   :XIAODONG MENG(6815328) & SAMEER SAPRA(6845382)
// FIRST VERSION:2014/9/23
// DESCRIPTION  :The function in this file provide read the database file and wirte the vechile infor to the database file, and the entrance of the application.
//
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication1
{

    class Program
    {
        //FUNCTION        : writeFile
        //DESCRIPTION     : write all the cars' information in the memory to the database.txt
        //PARAMETERS      :
        //                ref ArrayList motorcycleArry: The reference of the arrarylist save the motorcycle instances.
        //                ref ArrayList autoMobileArray: The reference of the arrarylist save the automobile instances.
        //                ref ArrayList truckArray:       The reference of the arrarylist save the truck instances.
        //RETURNS         :void
        private static void writeFile(ref ArrayList motorcycleArry, ref ArrayList autoMobileArray, ref ArrayList truckArray)
        {
            //New a streamwriter for  to write file, create a  new one if database.txt do not exist.
            System.IO.StreamWriter file = new System.IO.StreamWriter("Database.txt", true);

            foreach (Motorcycle it in motorcycleArry)
            {
                //Combine all the information of a motrocycle instance to a string.
                string lines = "motorcycle"; //Indicate the following line save a motorcycle information.


                lines += "|";

                lines += it.Manufacture;

                lines += "|";

                lines += it.Model;

                lines += "|";

                lines += it.Model_year;

                lines += "|";

                lines += it.Initial_purchase_price;

                lines += "|";

                lines += it.Purchase_date;

                lines += "|";

                lines += it.Odometer_reading;

                lines += "|";

                lines += it.Size_of_engine;

                lines += "|";

                lines += it.Motorcycle_type;

                file.WriteLine(lines);

            }

            foreach (Automobile it in autoMobileArray)
            {
                //Combine all the information of a automobile instance to a string.
                string lines = "automobile"; //Indicate the following line save a automobile information.

                lines += "|";
                lines += it.Manufacture;

                lines += "|";

                lines += it.Model;

                lines += "|";

                lines += it.Model_year;

                lines += "|";

                lines += it.Initial_purchase_price;

                lines += "|";

                lines += it.Purchase_date;

                lines += "|";

                lines += it.Odometer_reading;

                lines += "|";

                lines += it.Size_of_engine;

                lines += "|";

                lines += it.Number_doors;

                lines += "|";

                lines += it.Fuel_type;

                file.WriteLine(lines);

            }

            foreach (Truck it in truckArray)
            {
                //Combine all the information of a truckArray instance to a string.
                string lines = "truck";//Indicate the following line save a truck information.

                lines += "|";
                lines += it.Manufacture;

                lines += "|";

                lines += it.Model;

                lines += "|";

                lines += it.Model_year;

                lines += "|";

                lines += it.Initial_purchase_price;

                lines += "|";

                lines += it.Purchase_date;

                lines += "|";

                lines += it.Odometer_reading;

                lines += "|";

                lines += it.Size_of_engine;

                lines += "|";

                lines += it.Cargo_capacity;

                lines += "|";

                lines += it.Towing_capacity;

                file.WriteLine(lines);

            }

            file.Close();
        }

        //FUNCTION        :readFile
        //DESCRIPTION     :read content of the database.txt and generate instance according to the content. and save the instance to the arraylist.
        //
        //PARAMETERS      :
        //                ref ArrayList motorcycleArry: The reference of the arrarylist save the motorcycle instances.
        //                ref ArrayList autoMobileArray: The reference of the arrarylist save the automobile instances.
        //                ref ArrayList truckArray:       The reference of the arrarylist save the truck instances.
        //RETURNS         :void
        private static void readFile(ref ArrayList motorcycleArry, ref ArrayList autoMobileArray, ref ArrayList truckArray)
        {
            // int motor_id = 0;
            int auto_id = 0;
            int truck_id = 0;
            int motor_id = 0;

            if (!File.Exists("Database.txt"))
            {
                File.Create("Database.txt").Close();
                return;
            }

            System.IO.StreamReader file = new System.IO.StreamReader("Database.txt");

            string line;

            char[] delimiterChars = { '|' };

            while ((line = file.ReadLine()) != null)
            {

                string[] words = line.Split(delimiterChars);


                if (words[0] == "automobile")
                {
                    //new instance according to the information from the database.txt file.
                    Automobile temp = new Automobile(words[1], words[2], Convert.ToInt32(words[3]), Convert.ToInt32(words[4]), words[5], Convert.ToInt32(words[6]), Convert.ToInt32(words[7]), Convert.ToInt32(words[8]), words[9]);
                    auto_id++;
                    //generate the vehicle id.
                    string strId = "AM" + auto_id;
                    temp.Vehicle_Id = strId;
                    //add a instance to the arraylist.
                    autoMobileArray.Add(temp);

                }
                else if (words[0] == "truck")
                {
                    Truck temp = new Truck(words[1], words[2], Convert.ToInt32(words[3]), Convert.ToInt32(words[4]), words[5], Convert.ToInt32(words[6]), Convert.ToInt32(words[7]), (float)Convert.ToDecimal(words[8]), (float)Convert.ToDecimal(words[9]));
                    truck_id++;
                    string strId2 = "ST" + truck_id;
                    temp.Vehicle_Id = strId2;
                    truckArray.Add(temp);
                }
                else if (words[0] == "motorcycle")
                {
                    Motorcycle temp = new Motorcycle(words[1], words[2], Convert.ToInt32(words[3]), Convert.ToInt32(words[4]), words[5], Convert.ToInt32(words[6]), Convert.ToInt32(words[7]), words[8]);
                    motor_id++;
                    string strId3 = "MC" + motor_id;
                    temp.Vehicle_Id = strId3;
                    motorcycleArry.Add(temp);
                }

            }
            //close file 
            file.Close();

        }


        static void Main(string[] args)
        {
            //Get the memeory to save the instance.
            ArrayList arrMotro = new ArrayList();
            ArrayList arrAuto = new ArrayList();
            ArrayList arrTruck = new ArrayList();

            readFile(ref arrMotro, ref arrAuto, ref arrTruck);

            UI obj1 = new UI();
            //Set the initial id in the UI to genereate vehicle id base on the current amount of each type of the instance.
            obj1.Set_vehicles_id(arrMotro.Count, arrAuto.Count, arrTruck.Count);
            //Pass the container to the UI instance. So UI can access the container.
            obj1.SetArrayList(ref arrMotro, ref arrAuto, ref arrTruck);
            //Show the UI.
            obj1.main_menu();

            //Write all the information to database.txt file.
            writeFile(ref arrMotro, ref arrAuto, ref arrTruck);
        }


    }
}
