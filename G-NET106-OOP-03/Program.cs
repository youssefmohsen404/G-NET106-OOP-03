using G_NET106_OOP_02.part2;

namespace G_NET106_OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region Q1
            //Overloading, Overriding, and Binding
            // a)  What is the difference between Method Overloading and Method Overriding?

            // method overloading: is using the same function with it's name but changing in it's type
            // or parameters type or parameter arrangment or number of parameters
            // and it is a static polymorphism

            //method overriding : using a function inherited from the parent class in the derived class
            // by making the parent function virtual and using a override keyword in the new function
            // in the derived class then changing in fucntions's body in the derived class 
            // and method overriding is a dynamic polymorphism  

            //b)  What is the difference between Static Binding and Dynamic Binding?
            // static binding : is resolved in compile time a the compiler decide which function should be called
            // and it's depending on the reference parent type not the object type

            //dynamic binding : same as static but it's deciding which function should be called based on object type 
            //not the reference parent and the static is faster in excution (virtual , overriding )



            #endregion
            #endregion
            #region Q2
            //Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            // this sealed class can't be inherited from other classes we use it to protect 
            // the implementation of the class

            // b)  What is the difference between a sealed class and a sealed method?
            //the sealed class as we mentioned in the previous Q and it's functions implicitly can't be overridden
            // the sealed method if it inherited from other class and u marked the method as sealed 
            // u can't override it   

            //c)  Can a sealed method be overridden? Why?
            // selaed methods can't be overriden because using sealed keyword explicitly prevents overriding 
            //on the method 


            #endregion

            #region part2
           
            //driver
            Console.WriteLine("driver: ");
            Console.WriteLine("driver id:");
            int driverId = int.Parse(Console.ReadLine());
            Console.WriteLine("driver name:");
            string driverName = Console.ReadLine();
            Console.WriteLine("phone number:");
            int PhoneNumber = int.Parse(Console.ReadLine());
            Driver driver  = new Driver(driverId , driverName , PhoneNumber);


            //delivery center
            DeliveryCenter deliveryCenter = new DeliveryCenter(3);
            Console.WriteLine("Enter delivery center name");
            do { deliveryCenter.centerName = Console.ReadLine(); } while (string.IsNullOrEmpty(deliveryCenter.centerName));

            deliveryCenter.driver = driver;
           
            
            //standard shipment
            Console.WriteLine("standard shipment");
            Console.WriteLine("tracking code :");
            string trackingCode = Console.ReadLine();
            Console.WriteLine("describtion :");
            string describtion = Console.ReadLine();
            Console.WriteLine("weight :");
            decimal weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("delivery fee :");
            decimal deliveryFee = decimal.Parse(Console.ReadLine());


            StandardShipment standardShipment = new StandardShipment(trackingCode, describtion, weight, deliveryFee);
            Console.WriteLine("estimated cost:");
            Console.WriteLine(standardShipment.EstimatedCost); ;

            deliveryCenter.AddShipment(standardShipment);


            Console.WriteLine("=======================================");
            //express shipment
            Console.WriteLine("Express shipment");
            Console.WriteLine("tracking code :");
            string trackingCodeExpress = Console.ReadLine();
            Console.WriteLine("describtion :");
            string describtionExpress = Console.ReadLine();
            Console.WriteLine("weight :");
            decimal weightExpress = decimal.Parse(Console.ReadLine());
            Console.WriteLine("delivery fee :");
            decimal deliveryFeeExpress = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Extra fee");
            decimal extraFeeExpress = decimal.Parse(Console.ReadLine());
            ExpressShipment expressShipment = new ExpressShipment(trackingCodeExpress, describtionExpress, weightExpress, deliveryFeeExpress, extraFeeExpress);
            Console.WriteLine("estimated cost:");
            Console.WriteLine(expressShipment.EstimatedCost);

            deliveryCenter.AddShipment(expressShipment);

            Console.WriteLine("=======================================");
            //international shipment
            Console.WriteLine("International shipment");
            Console.WriteLine("tracking code :");
            string trackingCodeInter = Console.ReadLine();
            Console.WriteLine("describtion :");
            string describtionInter = Console.ReadLine();
            Console.WriteLine("weight :");
            decimal weightInter = decimal.Parse(Console.ReadLine());
            Console.WriteLine("delivery fee :");
            decimal deliveryFeeInter = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Destination country:");
            string country = Console.ReadLine();
            Console.WriteLine("Custom fees :");
            decimal customFees = decimal.Parse(Console.ReadLine());
            Console.WriteLine("====================");



            InternationalShipment internationalShipment = new InternationalShipment(trackingCodeInter, describtionInter, weightInter, deliveryFeeInter, country, customFees);

            Console.WriteLine("estimated cost:");
            Console.WriteLine(internationalShipment.EstimatedCost);

            deliveryCenter.AddShipment(internationalShipment);

            //print all shipments
            Console.WriteLine("all shipments");
            deliveryCenter.PrintAllShipments();
            Console.WriteLine("====================");
            //delivery helper
            Console.WriteLine("printing using delivery helper.....");
            DeliveryHelper.PrintShipmentDetails(standardShipment);
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            DeliveryHelper.PrintShipmentDetails(internationalShipment);

            Console.WriteLine("====================");


            //update weight 
            Console.WriteLine("weight is updating.....");
            Shipment shipment = new Shipment();
            shipment.UpdateWeight(20);
            shipment.UpdateWeight(20, 20);
            Console.WriteLine("====================");

            //shipment mixed list
            Console.WriteLine("print using shipments.....");
            Shipment[] mixedShipments = new Shipment[3];
            mixedShipments = [standardShipment, expressShipment, internationalShipment];
            foreach(Shipment mixed in mixedShipments)
            {
                mixed.PrintShipment();
            }
            Console.WriteLine("====================");

            //sealed class
            // i can create an object from the class like  any class but i can't inherit it from another class
          //  PriorityInternationalShipment priority = new PriorityInternationalShipment(20,);






            /*
                        Console.WriteLine(deliveryCenter["sh002"]);
                        Console.WriteLine("====================");

                        Console.WriteLine("enter tracking code to remove");
                        string code = Console.ReadLine();
                        deliveryCenter.RemoveShipment(code);
                        Console.WriteLine($"{code}removed");
                        Console.WriteLine("====================");

                        Console.WriteLine("updated shipments");
                        deliveryCenter.PrintAllShipments();
            */








            #endregion
        }
    }
}
