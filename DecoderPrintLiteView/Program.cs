using System;




namespace DevoderPrintView
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start
            Console.WriteLine("\t\nDECODER PRINT LITE\n\n\nPlease press any button to continue...");
            Console.ReadKey();
            

            int input;
            bool inputStatus;
            while(true)
            {
                // Main menu
                Console.Clear();
                Console.Write("\n1. Encryption\n2. Decoding\n\nEnter menu point: ");
                inputStatus = Int32.TryParse(Console.ReadLine(), out input);
                if (!inputStatus)
                {
                    Console.WriteLine($"Incorrect value!\nPress any button to continue...");
                    Console.ReadKey();
                    continue;
                }
                switch(input)
                {
                    case 1:
                        GoToEncodingPage();
                        break;
                    case 2: 
                        GoToDecodingPage();
                        break;
                    default:
                        Console.WriteLine($"Point {input} missing from menu!\nPress any button to continue...");
                        Console.ReadKey();
                        continue;
                }
            }



        }

        // encoding page
        public static void GoToEncodingPage()
        {
            int input;
            bool inputStatus;            
            while(true)
            {
                Console.Clear();
                Console.Write("\n\tPlease, choose encoding algoritm\n\n"+
                "\t1. Cesar\n"+
                "\t2. XOR-encoding\n"+
                "\t3. Playfair cipher\n\n"+
                
                "\tAlgorimt point: ");
                inputStatus = Int32.TryParse(Console.ReadLine(), out input);
                if (!inputStatus)
                {
                    Console.WriteLine($"Incorrect value!\nPress any button to continue...");
                    Console.ReadKey();
                    continue;
                }
                switch(input)
                {
                    case 1:
   
                        break;
                    case 2: 

                        break;
                    case 3:

                        break;
                    default:
                        Console.WriteLine($"Point {input} missing from menu!\nPress any button to continue...");
                        Console.ReadKey();
                        continue;
                }
                Console.ReadKey();
                System.Environment.Exit(-1);

            }

            // Console.ReadKey();
            // System.Environment.Exit(-1);
        }

        // decoding page
        public static void GoToDecodingPage()
        {
            Console.Clear();
            Console.WriteLine("Decoding...");
            Console.ReadKey();
            System.Environment.Exit(-1);
        }



    }
}