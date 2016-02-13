


/*FILE          : UI.cs
 *PROJECT       : Prog2120 - Assignment2
 *PROGRAMMER    : SAMEER SAPRA(6845382) & XIAODONG MENG(6815328) 
 *FIRST VERSION : 9/23/2014
 *DESCRIPTION   : This file is for User interface which gives a menu type interface. User can add,delete,view and change the odometer reading of the vehicle.
 *                It validates all user input according to the input type. User can press 6 to exit from the program.It refernce 3 list declared in main and stores
 *                the objects of different sub class/vehicle type in the 3 different list.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApplication1
{
    class UI
    {
        //Global variables.
        ArrayList list_motorcycle;  //declared in main file and being used as reference to store all motorcycles objects.
        ArrayList list_automobile;  //declared in main file and being used as reference to store all automobiles objects.
        ArrayList list_truck;      //declared in main file and being used as reference to store all small trucks objects.

        //Used for vehicle id, which gives a unique id to each vehicle.
        int motorcycle_id = 0;
        int automobile_id = 0;
        int truck_id = 0;


        //
        // FUNCTION NAME : Set_vehicles_id(int id1 ,int id2 ,int id3)
        //
        // PARAMETERS    : int id1 : reads all motorcycles from file and stores the number of motorcycles in the global variable which will given new unique ID for it. 
        //               : int id2 : reads all automobiles from file and stores the number of automobile in the global variable which will given new unique ID for it.
        //               : int id3 : reads all small trucks form file and stores the number of motorcycles in the global variable which will given new unique ID for it.
        //
        // RETURN        : void
        // DESCRIPTION   : This function is called in main to set the initial values for the global variables used.Copies the value of each parameter and store in global variables to generate unique ID's. 
        //

        public void Set_vehicles_id(int id1 ,int id2 ,int id3)
        {
            motorcycle_id = id1;
            automobile_id = id2;
            truck_id = id3;
        }



        // FUNCTION NAME : SetArrayList(ref ArrayList motorcycleArray, ref ArrayList autoMobileArray, ref ArrayList truckArray)
        //
        // PARAMETERS    : ref ArrayList motorcycleArray    : stores the reference of motrocycle arraylist declared in main to the global variable.
        //               : ref ArrayList autoMobileArray    : stores the reference of motrocycle arraylist of declared in main to the global variable.
        //               : ref ArrayList truckArray         : stores the reference of truck arraylist of declared in main to the global variable.
        //
        // RETURN        : void

        //
        // DESCRIPTION   : It is called in main and stores the refernce of each arraylist to these global variables which will be used to store moe vehicles.
        
        public void SetArrayList(ref ArrayList motorcycleArray, ref ArrayList autoMobileArray, ref ArrayList truckArray)
        {
            list_motorcycle = motorcycleArray;
            list_automobile = autoMobileArray;
            list_truck = truckArray;
        }


        //
        // FUNCTION NAME : main_menu()
        // PARAMETERS    : void
        // RETURN        : void
        // DESCRIPTION   : It gives the user a main interface and its sub interface of each of the options of the main interface.It calls different fucntions to validate the user input 
        //                 and calls abstract show method to display the vehicle.
        //

       public void main_menu()
        {
           //when user presses6 to exit, it becomes true means exit from the main while loop.
            bool stop = false;
            while (!stop)
            {
               //local variables
                bool go_to_mainpage = false;
                
                int m_year = 0;
                
                //clear the screen.
                Console.Clear();
                //changes the color of text.
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("\n\t\t\tSameer & Daive Motors Vehicle Comapny.\n\n\n");


                //initial interface of this program.
                System.Console.WriteLine("1. Add a vehicle. ");
                System.Console.WriteLine("2. View a vehicle.");
                System.Console.WriteLine("3. Delete a vehicle.");
                System.Console.WriteLine("4. View all vehicles.");
                System.Console.WriteLine("5. Modify the odometer reading.");
                System.Console.WriteLine("6. Exit");
                System.Console.Write("\nEnter your option:");
              
                //wait for a key to get into switch case.
                ConsoleKeyInfo option = Console.ReadKey();
                switch (option.KeyChar)
                {
                        
                    case '1':
                       
                        while (!go_to_mainpage)
                        {
                            //clear the screen.
                            Console.Clear();

                            //sub meny of add vehicle option.
                            System.Console.WriteLine("\n\t\tMain Page > Add vehicle\n\n");
                            System.Console.WriteLine("1. Motorcycle.");
                            System.Console.WriteLine("2. Automobile.");
                            System.Console.WriteLine("3. Small Truck.");
                            System.Console.WriteLine("4. Go back.");
                            Console.Write("\nEnter your option:");

                            //waits for a key from the user to enter in switch case.
                            option = Console.ReadKey();
                            switch (option.KeyChar)
                            {
                                case '1':
                                    System.Console.Clear();
                                    System.Console.WriteLine("\n\t\tMain Page > Add vehicle > Motorcycle.\n\n");
                                    
                                    //increase the vehicle id by 1.
                                    motorcycle_id++;

                                    //validate the user data.
                                    validate_vehicle_data("motorcycle");
                                    break;
                                case '2':
                                    System.Console.Clear();
                                    System.Console.WriteLine("\n\t\tMain Page > Add vehicle > Automobile.\n\n");

                                    //increase the vehicle id by 1.
                                    automobile_id++;

                                    //validate the user data.
                                    validate_vehicle_data("automobile");
                                    break;
                                case '3':
                                    System.Console.Clear();
                                    System.Console.WriteLine("\n\t\tMain Page > Add vehicle > Small Truck.\n\n");

                                    //increase the vehicle id by 1.
                                    truck_id++;

                                    //validate the user data.
                                    validate_vehicle_data("truck");
                                    break;
                                case '4':

                                    //exit from this sub menu and goto the main menu.
                                    go_to_mainpage = true;
                                    break;
                                default:
                                    System.Console.WriteLine("\n\t( ERROR - Enter a valid option... )");
                                    Console.WriteLine("Press Any Key To Continue.");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        
                        break;

                    case '2':
                        while (!go_to_mainpage)
                        {
                            bool goto_viewvehicle_menu = false;
                            int traverse_each_vehicle = 0;
                            Console.Clear();

                            //sub menu of view vehicle option.
                            System.Console.WriteLine("\n\n\tMain Page > View vehicle\n");
                            System.Console.WriteLine("Search for a vehicle by:\n");
                            System.Console.WriteLine("1. Type.");
                            System.Console.WriteLine("2. Model Year.");
                            System.Console.WriteLine("3. Go to main page.");
                            Console.Write("\nEnter your option:");

                            //wait for the key from the user to enter.
                            option = Console.ReadKey();
                            switch (option.KeyChar)
                            {
                                 
                                    //display the vehicle by type.
                                case '1':
                                    while (!goto_viewvehicle_menu)
                                    {
                                        //clear the screen.
                                        Console.Clear();
                                        System.Console.WriteLine("\n\n\tMain Page > View vehicle > Type\n");
                                        System.Console.WriteLine("1. Motorcycle.");
                                        System.Console.WriteLine("2. Automobile.");
                                        System.Console.WriteLine("3. Small truck.");
                                        System.Console.WriteLine("4. Go back\n");
                                        System.Console.Write("Enter your option: ");

                                        //wait for a key from the user to enter.
                                        ConsoleKeyInfo option1 = Console.ReadKey();
                                        switch (option1.KeyChar)
                                        {
                                            case '1':
                                                Console.Clear();
                                                Console.WriteLine("\t\t*** Data of all motorcycles. ***\n\n");

                                                //display all the motorcycles.
                                                dislpay_vehicle("motorcycle",list_motorcycle);
                                                break;
                                            case '2':
                                                Console.Clear();
                                                Console.WriteLine("\t\t*** Data of all automobiles. ***\n\n");

                                                //display all the automobiles.
                                                dislpay_vehicle("automobile",list_automobile);
                                                break;
                                                
                                            case '3':
                                                Console.Clear();
                                                Console.WriteLine("\t\t*** Data of all Small Trucks. ***\n\n");

                                                //display all the trucks.
                                                dislpay_vehicle("truck",list_truck);
                                                break;
                                            case '4':

                                                //exit from the sub menu and goto the main menu.
                                                goto_viewvehicle_menu = true;
                                                break;
                                            default:
                                                System.Console.WriteLine("\n\t\t( ERROR - Enter a valid option... )\n");
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                    break;


                                    //display by the model year entered by the user.
                                 case '2':
                                    string search_by_model_year="";
                                    int vehicle_found = 0;
                                    int i = 0;
                                    while (true)
                                    {

                                        Console.Write("\nEnter the model year : ");

                                        //enter athe model year.
                                        search_by_model_year = Console.ReadLine();
                                            
                                        //validate the model year as integer.
                                        if (!(int.TryParse(search_by_model_year, out m_year)))
                                        {
                                            //ask again the model year from the user.
                                            Console.WriteLine("\n\t\t( ERROR - Enter a valid model year... )");
                                        }
                                        else
                                        {
                                            //model year is valid integer.
                                            break;
                                        }
                                    }
                                    Console.Clear();

                                    //display all the vehicles of all types with that model year.
                                    for (i = 0; i < 3; i++)
                                    {
                                        //create a refernce for the truck list.
                                        ArrayList ar1=list_truck;

                                        if(i==0)
                                        {
                                            //store the refernce of motorcycle list.
                                            ar1 = list_motorcycle;
                                        }
                                        if(i==1)
                                        {
                                            //store the refernce of automobile list.
                                            ar1 = list_automobile;
                                        }
                                        if(i==2)
                                        {
                                            //store the refernce of truck list.
                                            ar1 = list_truck;
                                        }

                                        // look for all vehicles with that model year.
                                        // using dynamic binding to call the function show of object in ar1 list.
                                        foreach (Vehicle a1 in ar1)
                                        {
                                           
                                            if (a1.Model_year == m_year)
                                            {
                                                //found the vehicle with that model year and show its data.
                                                a1.Show();
                                                Console.WriteLine("\n\t-------------------------\n\n");
                                                vehicle_found++;
                                            }
                                            else
                                            {
                                                //vehicle 1 checked.
                                                traverse_each_vehicle++;
                                            }
                                        }
                                    }

                                   //if vehicles are found with that model year.
                                    if(vehicle_found>0)
                                    { 
                                        Console.WriteLine("\t** There are " + vehicle_found + " vehicles with model year " + m_year + " **");
                                    }
                                   
                                     //if there is no vehicle of user model year then display an error message
                                    if(traverse_each_vehicle == (list_automobile.Count + list_motorcycle.Count + list_truck.Count))
                                    {
                                        Console.WriteLine("\n\tSorry, we dont have your vehicle with model year {0}", m_year + "...\n");
                                    }

                                  //if all lists are empty then display the message.
                                    if((list_automobile.Count == 0 ) && (list_truck.Count==0) && (list_motorcycle.Count==0))
                                    {
                                        Console.WriteLine("Sorry, our automobile,motorcycle and truck inventory are empty right now.\n");
                                    }
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                    break;

                                case '3':
                                    //get out of sub menu and goto the main page.
                                        go_to_mainpage = true;
                                        break;
                              
                                default:
                                        Console.WriteLine("\n\t\t( ERROR - Enter a valid option... )\n");
                                        Console.WriteLine("Press any key to continue...\n");
                                        Console.ReadKey();
                                        break;
                            }
                        }
                        break;
                            
                    case '3':
                        while(!go_to_mainpage)
                        {

                            //delete vehicle's sub menu.
                            Console.Clear();
                            Console.WriteLine("\n\t\tMain Page > Delete Vehicle\n");
                            System.Console.WriteLine("1. Motorcycle.");
                            System.Console.WriteLine("2. Automobile.");
                            System.Console.WriteLine("3. Small truck.");
                            System.Console.WriteLine("4. Go back\n");
                            System.Console.Write("Enter your option: ");

                            //user enters the option which vehicle to delete.
                            ConsoleKeyInfo option2 = Console.ReadKey();
                            
                            switch(option2.KeyChar)
                            {
                                case'1':
                                    //first find the vehicle id in the list first and then this function will call other function to delete the vehicle.
                                    check_vehicle_id(list_motorcycle, "delete_vehicle", "motorcycle");
                                    break;
                                case'2':
                                    //first find the vehicle id in the list first and then this function will call other function to delete the vehicle.
                                    check_vehicle_id(list_automobile, "delete_vehicle","automobile");
                                    break;
                                case'3':
                                    //first find the vehicle id in the list first and then this function will call other function to delete the vehicle.
                                    check_vehicle_id(list_truck, "delete_vehicle", "truck");
                                    break;
                                case'4':

                                    //get out of this sub menu and goto main menu.
                                    go_to_mainpage = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t( ERROR - Enter a valid option... )");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case '4':

                        //display all vehicles.
                        Console.Clear();
                        dislpay_vehicle("automobile", list_automobile);
                        dislpay_vehicle("motorcycle", list_motorcycle);
                        dislpay_vehicle("truck", list_truck);
                        break;
                    case '5':
                        
                        while (!go_to_mainpage)
                        {
                            //sub menu of change odometer.
                            Console.Clear();
                            Console.WriteLine("\n\t\tMain Page > Change odometer reading\n\n");
                            Console.WriteLine("Select the type of vehicle you want to change odometer reading:\n");
                            Console.WriteLine("1. Motorcycle.");
                            Console.WriteLine("2. Automobile.");
                            Console.WriteLine("3. Small Truck.");
                            Console.WriteLine("4. Goto Main Page");
                            Console.Write("\nEnter your option:");

                            //wait for the user to enter his choice.
                            ConsoleKeyInfo option3 = Console.ReadKey();
                           
                            switch (option3.KeyChar)
                            {
                                case'1':
                                    //first find the vehicle id in the list first and then this function will call other function to change the reading.
                                    check_vehicle_id(list_motorcycle, "change_odometer", "motorcycle");
                                    break;
                                case'2':
                                    //first find the vehicle id in the list first and then this function will call other function to change the reading.
                                    check_vehicle_id(list_automobile,"change_odometer","automobile");
                                    break;
                                case'3':
                                    //first find the vehicle id in the list first and then this function will call other function to change the reading.
                                    check_vehicle_id(list_truck,"change_odometer","truck");
                                    break;
                                case'4':
                                    //get out of this sub menu and goto the main menu.
                                    go_to_mainpage = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t (ERROR - Enter a valid option...");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                    break;
                            }
                            
                        }
                     
                        break;
                    case '6':
                        
                        //goto main menu.
                        go_to_mainpage = true;

                        //exit from the main menu and exit from the program.
                        stop = true;
                        System.Console.WriteLine();
                        System.Console.WriteLine("\t***   Exiting from the program.   ***\n");
                        break;
                    default:
                        System.Console.WriteLine("\n\t( ERROR - Enter a valid option.... )\n");
                        Console.WriteLine("Press any key to continue... ");
                        Console.ReadKey();
                        break;
                }
            }
        }

       // FUNCTION NAME : validate_vehicle_data(string vehicle_type)
       //
       // PARAMETER     : string vehicle_type: contains the type of the vehicle as a string.
       //
       // RETURN        : void
       //
       // DESCRIPTION   : It gets the input from the user and validates before adding to the list.
        
                         
       private void validate_vehicle_data(string vehicle_type)
       {
           //local variables.
           string manufacturer="";
           string model="";
           string model_year="";
           string initial_purchase_price="";
           string purchase_date="";
           string current_odometer="";
           string size_of_engine="";
           string type_of_motorcycle="";
           string number_of_doors="";
           string type_of_fuel="";
           string cargo_capacity="";
           string towing_capacity="";
           string vehicle_id = "";

       
           int m_year = 0, i_purchase_price=0, odometer=0, s_engine=0, n_doors=0, c_capacity=0, t_capacity = 0;

           //if validation fails , then it will be used to ask again.
           bool ask_again = true;

           //get the manufacturer from the user.
           while (ask_again)
           {
               System.Console.Write("Enter the manufacturer\t\t   : ");
               manufacturer = System.Console.ReadLine();

               //validate the data in other function which returns the bool value to ask again or not from the user.
               ask_again = validate_string(manufacturer);
           }

           //get the vehicle model from the user.
           ask_again = true;
           while (ask_again)
           {
               System.Console.Write("Enter the vehicle model\t\t   : ");
               model = System.Console.ReadLine();

               //validate the data in other function which returns the bool value to ask again or not from the user.
               ask_again= validate_as_num_aplha(model);
           }

           //get the vehicle model year from the user.
           ask_again = true;
           while (ask_again)
           {
               System.Console.Write("Enter the vehicle model year\t   : ");
               model_year = System.Console.ReadLine();

               //validate the data as int in other function which returns the bool value to ask again or not from the user.
               ask_again = validate_as_int(model_year, ref m_year);
            
           }

           //get the initial purchase price of motorcycle from the user.
           if (vehicle_type == "motorcycle")
           {
               ask_again = true;
               while (ask_again)
               {
                   System.Console.Write("Enter the initial purchase price \n\t (minimum value is $1500 ) : ");
                   initial_purchase_price = System.Console.ReadLine();

                   //validate the data as int in other function which returns the bool value to ask again or not from the user.
                   ask_again = validate_as_int(initial_purchase_price, ref i_purchase_price);

                   //compare it with minimum value.
                   if (i_purchase_price < 1500)
                   {
                       Console.WriteLine("\t\t\t( ERROR - Enter a value greater than $1500... )\n");
                       ask_again = true;
                   }
               }
           }

           //get the initial purchase price of automobile from the user.
           if (vehicle_type == "automobile")
           {
               ask_again = true;
               while (ask_again)
               {
                   System.Console.Write("Enter the initial purchase price \n\t (minimum value is $500 )  : ");
                   initial_purchase_price = System.Console.ReadLine();

                   //validate the data as int in other function which returns the bool value to ask again or not from the user.
                   ask_again = validate_as_int(initial_purchase_price, ref i_purchase_price);

                   //compare it with minimum value.
                   if(i_purchase_price < 500)
                   {
                       Console.WriteLine("\t\t\t( ERROR - Enter a value greater than $500... )\n");
                       ask_again = true;
                   }
               }
           }

           //get the initial purchase price of truck from the user.
           if (vehicle_type == "truck")
           {
               ask_again = true;
               while (ask_again)
               {
                   System.Console.Write("Enter the initial purchase price\n\t(minimum value is $0 )\t   : ");
                   initial_purchase_price = System.Console.ReadLine();

                   //validate the data as int in other function which returns the bool value to ask again or not from the user.
                   ask_again = validate_as_int(initial_purchase_price, ref i_purchase_price);

                   //compare it with minimum value.
                   if (i_purchase_price < 0)
                   {
                       Console.WriteLine("\t\t\t( ERROR - Enter a value greater than $0... )\n");
                       ask_again = true;
                   }
               }
           }

           //get the initial purchase date of vehicle from the user.
           ask_again = true;
           while (ask_again)
           {
               System.Console.Write("Enter the purchase date\t\t   : ");
               purchase_date = System.Console.ReadLine();

               //validate the data as datetime type in other function which returns the bool value to ask again or not from the user.
               ask_again = validate_as_date_time(purchase_date);
           }

           //get the odometer reading of vehicle from the user.
           ask_again = true;
           while (ask_again)
           {
               System.Console.Write("Enter the current odometer reading : ");
               current_odometer = System.Console.ReadLine();

               //validate the data as int in other function which returns the bool value to ask again or not from the user.
               ask_again = validate_as_int(current_odometer, ref odometer);
           }

           //get the size of engine of vehicle from the user.
           ask_again = true;
           while (ask_again)
           {
               System.Console.Write("Enter the size of engine\t   : ");
               size_of_engine = System.Console.ReadLine();

               //validate the data as int in other function which returns the bool value to ask again or not from the user.
               ask_again = validate_as_int(size_of_engine,ref s_engine);
           }

           //get the type of motorcycle from the user.
           if (vehicle_type == "motorcycle")
           {
               ask_again = true;
               while (ask_again)
               {
                   System.Console.Write("Enter the type of motorcycle \t   : ");
                   type_of_motorcycle = System.Console.ReadLine();

                   //validate the data as string in other function which returns the bool value to ask again or not from the user.
                   ask_again = validate_string(type_of_motorcycle);
               }

               //concatenate the motorcycle id to the vehicle id.
               vehicle_id = "MC" + motorcycle_id;

               //create an instance of motorcycle and call the constructor to store the data in the properties.
               Motorcycle obj = new Motorcycle(manufacturer,model,m_year,i_purchase_price,purchase_date,odometer,s_engine,type_of_motorcycle);

               //calls the accessor method of vehicle id property to set it a value.
               obj.Vehicle_Id = vehicle_id;

               //add the motorcycle object in list.
               list_motorcycle.Add(obj);

           }

           
           if(vehicle_type=="automobile")
           {
               //get the number of doors from the user.
               ask_again = true;
               while (ask_again)
               {
               
                   System.Console.Write("Enter the number of doors(2,3, or 5): ");
                   number_of_doors = System.Console.ReadLine();

                   //validate the data as int in other function which returns the bool value to ask again or not from the user.
                   ask_again = validate_as_int(number_of_doors, ref n_doors);
                   
                   //number of doors has to be between 2-5.
                   if(n_doors >=2 && n_doors<=5)
                   {
                       ask_again = false;
                   }
                   else
                   {
                       Console.WriteLine("\n\t\t\t( ERROR - Number of doors can be 2,3,4 or 5...)");
                       ask_again = true;
                   }
               }

               //get the type of fuel from the user.
               ask_again = true;
               while (ask_again)
               {
                   System.Console.Write("Enter the type of fuel\t\t   : ");
                   type_of_fuel = System.Console.ReadLine();
                   ask_again = validate_string(type_of_fuel);

                   if( (string.Compare(type_of_fuel, "Electric", true) == 0) || (string.Compare(type_of_fuel, "Diesel", true)==0) || (string.Compare(type_of_fuel, "Gas", true) == 0))
                   {
                       ask_again = false;
                   }
                   else
                   {
                       Console.WriteLine("\n\t\t\t(ERROR - Fuel type can be Electric,Diesel or Gas... )\n");
                       ask_again = true;
                   }
               }

               //concatenate the motorcycle id to the vehicle id.
               vehicle_id = "AM" + automobile_id;

               //create an instance of automobile and call the constructor to store the data in the properties.
               Automobile obj1 = new Automobile(manufacturer,model,m_year,i_purchase_price,purchase_date,odometer,s_engine,n_doors,type_of_fuel);

               //calls the accessor method of vehicle id property to set it a value.
               obj1.Vehicle_Id = vehicle_id ;

               //add the automobile object in list.
               list_automobile.Add(obj1);
              
           }


           if(vehicle_type=="truck")
           {
               //get the cargo capacity from the user.
               ask_again = true;
               while (ask_again)
               {
                   System.Console.Write("Enter the cargo capacity\t   : ");
                   cargo_capacity = System.Console.ReadLine();

                   //validate the data as int in other function which returns the bool value to ask again or not from the user.
                   ask_again = validate_as_int(cargo_capacity, ref c_capacity);
               }

               //get the towing capacity from the user.
               ask_again = true;
               while (ask_again)
               {
                   System.Console.Write("Enter the towing capacity\t   : ");
                   towing_capacity = System.Console.ReadLine();
                   ask_again = validate_as_int(towing_capacity, ref t_capacity);
               }

               //concatenate the truck id to the vehicle id.
               vehicle_id = "ST" + truck_id;


               //create an instance of truck and call the constructor to store the data in the properties.
               Truck obj2 = new Truck(manufacturer, model, m_year, i_purchase_price,purchase_date, odometer, s_engine,c_capacity,t_capacity);

               //calls the accessor method of vehicle id property to set it a value.
               obj2.Vehicle_Id = vehicle_id;

               //add the automobile object in list.
               list_truck.Add(obj2);
           }
       }



       // FUNCTION NAME : validate_string(string str)
       // PARAMETERS    : string str : stores the user input. 
       // 
       // RETURN        : true: if validation fails and ask again from the user.
       //               : false: if validation succeeds and dont ask againfrom the user.
       // DESCRIPTION   : It validates the paramater as a string.


        private bool validate_string(string str)
        {
            int i = 0;

            //if parameter is empty.
            if(str.Length==0)
            {
                System.Console.WriteLine("\t\t\t\t\t( ERROR - Enter something... )");

                //ask again from the user.
                return true;
            }

            //go through each character to check whether it is letter.
            for (i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    System.Console.WriteLine("\t\t\t\t\t( ERROR - Enter a valid string... )");

                    //ask again from the user.
                    return true;
                }
            }

            //if each character is checked in upper loop. 
            if (i == str.Length)
            {
                //dont ask again from the user.
                return false;
            }
            return false;
       }




        // FUNCTION NAME : validate_as_int(string str,ref int a)
        //
        // PARAMETERS    : string str : stores the user input. 
        //               : int a      : returns the integer value if the validation succeeds.
        //
        // RETURN        : true: if validation fails and ask again from the user.
        //               : false: if validation succeeds and dont ask againfrom the user.
        // DESCRIPTION   : It validates the paramater as a int.

        private bool validate_as_int(string str,ref int a)
        {
            if (!(int.TryParse(str,out a)))
            {
                System.Console.WriteLine("\t\t\t\t\t( ERROR - Enter a valid number... )");

                //ask again from the user.
                return true;
            }
            return false;
        }



        // FUNCTION NAME : validate_as_num_aplha(string str)
        //
        // PARAMETERS    : string str : stores the user input. 

        //
        // RETURN        : true: if validation fails and ask again from the user.
        //               : false: if validation succeeds and dont ask againfrom the user.
        // DESCRIPTION   : It validates the paramater as a integer and letter.

        private bool validate_as_num_aplha(string str)
        {
            int i = 0;

            //if user input is empty.
            if (str.Length == 0)
            {
                System.Console.WriteLine("\t\t\t\t\t( ERROR - Enter something... )");

                //ask again form the user.
                return true;
            }

            //check each character whether it is alphanum or not.
            for (i = 0; i < str.Length; i++)
            {
              
                if (char.IsLetterOrDigit(str[i]) || str[i]==' ')
                {
                    continue;
                }
                else
                {
                    System.Console.WriteLine("\t\t\t\t\t( ERROR - Enter a valid alphanumeric string... )");
                    return true;
                }
            }

            //dont ask again from the user.
            if (i == str.Length)
            {
                return false;
            }
            return false;
        }


        // FUNCTION NAME : validate_as_date_time(string str)
        //
        // PARAMETERS    : string str : stores the user input. 

        //
        // RETURN        : true: if validation fails and ask again from the user.
        //               : false: if validation succeeds and dont ask againfrom the user.
        // DESCRIPTION   : It validates the paramater as a datetime.

        private bool validate_as_date_time(string str)
        {
            try
            {
                //convert parameter into datetime type.
                DateTime dt = Convert.ToDateTime(str);

                //get the current system time.
                DateTime now = DateTime.Now;

                ////format
                //string tt = string.Format("M/dd/yyyy");
                
                //comapres the parameter date with today's date.
                int result = DateTime.Compare(dt, now);
                if (result > 0)
                {
                    Console.WriteLine("\t\t\t(ERROR - date is greater than today's date... )");

                    //ask again from the user.
                    return true;
                }
              
            }
                //if any exception occur handle here.
            catch(Exception e)
            {
                System.Console.WriteLine("\t\t\t( ERROR - Invalid Input.... \n",e.ToString());
                return true;
            }
            return false;
        }



        // FUNCTION NAME : dislpay_vehicle(string str, ArrayList l_vehicle)
        //
        // PARAMETERS    : string str          : stores the user input. 
        //               : ArrayList l_vehicle : stores the reference of the list passed according to where it is called.
        //
        // RETURN        : void

        // DESCRIPTION   : It displays the vehicle using abstract class show function.

        private void dislpay_vehicle(string str, ArrayList l_vehicle)
        {
            int vehicle_count = 1;
          
            //if list is empty.
            if (l_vehicle.Count == 0)
            {
                Console.WriteLine("\n\n\t***  Sorry, there is no vehicle in {0} inventory.  ***",str);
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }
            else
            {
                //dynamic binding is used, which will call the show method of the class's object stored in list.
                foreach (Vehicle a in l_vehicle)
                {
                    Console.WriteLine("\t # {0} " + vehicle_count + " is \n" , str);

                    //show the properies of the object.
                    a.Show();
                    Console.WriteLine("\t--------------------------\n");
                    vehicle_count++;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
         
        }

        // FUNCTION NAME : check_vehicle_id(ArrayList arry, string str, string str1)
        //
        // PARAMETERS    : ArrayList arry : stores the reference of the list passed according to where it is called.
        //
        //               : string str     : stores one of the string "change_odometer" and "delete_vehicle".
        //               : string str1    : stores the name of the type of vehicle.
        //
        // RETURN        : void

        // DESCRIPTION   : It asks first whether user knows his vehicle id or not for either deletion of vehicle or changing odometer reading. 

        void check_vehicle_id(ArrayList arry, string str, string str1)
        {
            Console.WriteLine("\nDo you know your vehicle id? (y/n)");
            ConsoleKeyInfo option3 = Console.ReadKey();

            //if user knows his vehicle id.
            if ((option3.KeyChar == 'y') || (option3.KeyChar == 'Y'))
            {
                if (str == "delete_vehicle")
                {
                    //delete a vehicle.
                    del_vehicle_or_change_odo(arry, "delete_vehicle");

                }
                if (str == "change_odometer")
                {
                    //change the odometer reading.
                    del_vehicle_or_change_odo(arry, "change_odometer");
                }
            }

                //if user doesnt know the vehicle id.
            else if ((option3.KeyChar == 'n') || (option3.KeyChar == 'N'))
            {
                Console.Clear();

                //if list is empty.
                if (arry.Count == 0)
                {
                    Console.WriteLine("\n\t***  {0} inventory is empty right now.  ***", str1);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else
                {
                    //if list is not empty then display all vehicles of type "str" parameter.
                    dislpay_vehicle(str1, arry);
                    
                    //ask user whetehr he finds his vehicle data displayed on the screen.
                    while (true)
                    {
                        Console.WriteLine("\n\n Do you find your vehicle? ( y/n )");
                        option3 = Console.ReadKey();

                        //if he finds his data displayed on screen.
                        if ((option3.KeyChar == 'y') || (option3.KeyChar == 'Y'))
                        {
                            //if user has asked to change odometer reading.
                            if (str == "change_odometer")
                            {
                                //cahnge the odometer reading.
                                del_vehicle_or_change_odo(arry, "change_odometer");
                                break;
                            }

                            //if user has asked to delete the vahicle.
                            if (str == "delete_vehicle")
                            {
                                //delete vehicle.
                                del_vehicle_or_change_odo(arry, "delete_vehicle");
                                break;
                            }
                        }
                        //if user does not find his vehicle from the vehicles diaplyed on the screen , then inform user. 
                        if ((option3.KeyChar == 'n') || (option3.KeyChar == 'N'))
                        {
                            Console.WriteLine("\n \t** Sorry, there is no record of your vehicle in our database... **\n");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
            }
        }



        // FUNCTION NAME : del_vehicle_or_change_odo(ArrayList ary,string str)
        //
        // PARAMETERS    : ArrayList l_vehicle : stores the reference of the list passed according to where it is called.
        //
        //               : string str          : stores one of the string "change_odometer" and "delete_vehicle".
        //
        // RETURN        : void

        // DESCRIPTION   : It either delete or change the odometer reading of the vehicle, and it depends on the value of str. 


        private void del_vehicle_or_change_odo(ArrayList ary,string str)
        {
            //local variables.
            string odo_reading = "";
            string vehicle_id = "";
            int new_odometer_reading = 0;
            bool found = false;
            ConsoleKeyInfo option4;
          
            //ask for vehicle ID.
            while (true)
            {
                Console.Write("\nEnter your vehicle id : ");
                vehicle_id = Console.ReadLine();

                //validate the user data first.
                if (!(validate_as_num_aplha(vehicle_id)))
                {
                    break;
                }   
            }

            //if list is empty.
            if (ary.Count == 0)
            {
                Console.WriteLine("\t\t***  Sorry, there is no such vehicle in inventory.  ***\n");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
               
            }
            else
            {
                 //dynamic binding used.
                foreach (Vehicle check_id in ary)
                {
                    //if vehicle id of object is same as user's id.
                    if (check_id.Vehicle_Id == vehicle_id)
                    {
                        Console.Clear();

                        //show the details of that object of that vehicle id.
                        check_id.Show();

                        //confirm whether this is the vehicle looking for
                        Console.WriteLine("\n\tIs this your vehicle( y/n )?");
                        option4 = Console.ReadKey();

                        //if this is the vehicle.
                        if (option4.KeyChar == 'y')
                        {
                            //if user has asked to change the odometer reading.
                            if (str == "change_odometer")
                            {
                                while (true)
                                {
                                    //ask the odometer reading.
                                    Console.Write("\nEnter the odometer reading:");
                                    odo_reading = Console.ReadLine();

                                    //validate the user input first.
                                    if (!(int.TryParse(odo_reading, out new_odometer_reading)))
                                    {
                                        Console.WriteLine("\t\t( ERROR - Enter a valid reading in km...)\n");
                                    }
                                    else
                                    {
                                        //change the odometer reading.
                                        check_id.Odometer_reading = new_odometer_reading;
                                        Console.WriteLine("\n\t***   Odometer reading has been changed successfully.   ***");
                                        Console.WriteLine("Press any key to continue.");
                                        Console.ReadKey();
                                        break;
                                    }
                                }
                                //vehicle found with that id.
                                found = true;
                            }
                            //if user has asked to delete the vehicle.
                            if(str=="delete_vehicle")
                            {
                                Console.WriteLine("\n\t**  Are you sure you want to delete this vehicle? (y/n)  **");
                                option4 = Console.ReadKey();

                                if (option4.KeyChar == 'Y' || option4.KeyChar == 'y')
                                {
                                    //remove the object from the list.
                                    ary.Remove(check_id);
                                    Console.WriteLine("\n\t ***  Vehicle with id " + vehicle_id + " is deleted successfully.  ***\n");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                }
                                if(option4.KeyChar =='N' || option4.KeyChar =='n')
                                {
                                    Console.WriteLine("\n\t ***  Vehicle not deleted from the database.  ***\n");
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadKey();
                                }
                                //vehicle found with that id.
                                found = true;
                                break;
                            }
                        }

                        //if vehicle's details shown above is not what user is looking for.
                        if(option4.KeyChar=='n')
                        {
                            //Disaplay user the message.
                            Console.WriteLine("\n\t*** Sorry we don't have any vehicle with this ID " + vehicle_id +"\n");
                            Console.WriteLine("Press any key to continue.\n");
                            Console.ReadKey();
                        }
                     
                    }
                }
                //if vehicle is not found then inform the user.
                if(!found)
                {
                    Console.WriteLine("\n\t*** Sorry, vehicle not found. ***");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
    }
}
