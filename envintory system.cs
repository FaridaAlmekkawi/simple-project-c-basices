using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace envintory_system
{
    internal class Program
    {
        const int CountProduct = 100;
         static string[,] product = new string[CountProduct,3];
         static int InputIndex = 0;
        static void Main(string[] args)
        {
            //  add product 
            // update product  
            // view product ( id, name , Qountity , price )
            // exit 
           

            while (true) {
                Console.WriteLine("welcome to envintory system app , enter your choose from 1 to 4  ");
                Console.WriteLine("==================================================================");
                Console.WriteLine("1- Add product ");
                Console.WriteLine("2- Update Product ");
                Console.WriteLine("3- View Product ");
                Console.WriteLine("4- Exit ");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        // add product 
                        Addproduct();
                        break; 
                    case 2:
                        // update product 
                        Updateproduct();
                        break;
                    case 3:
                        // view product 
                        viewProduct();
                        break;
                    case 4:
                        // exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("your choose unvalid , try again choose number between 1 to 4 ");
                        break;
                }

            }
        }

       private static void Addproduct()
        {
            Console.WriteLine("Enter product name:");
            String name = Console.ReadLine();

            Console.WriteLine("Enter product Quantity:");
            string Quantity = Console.ReadLine();

            Console.WriteLine("Enter product price:");
            string Price = Console.ReadLine();


            product[InputIndex, 0] = name;
            product[InputIndex, 1] = Quantity;
            product[InputIndex, 2] = Price;
            
            InputIndex++;
            Console.WriteLine(" product added successfully ");
            


        }
       private static void viewProduct()
        {
            if (InputIndex > 0)
            {
                for (int i = 0; i < InputIndex; i++)

                {
                    Console.WriteLine(" product list ");
                    Console.WriteLine($" product ID:{i} \n product Name:{product [i,0]} \n product Quantity:{product [i,1]} \n product Price:{product [i,2]}");
                }
            }
        }
        private static void Updateproduct()
        {
            Console.WriteLine(" enter product name  to update ");
            string searchproduct = Console.ReadLine();
            int productIndexUpdate = -1;
            if (InputIndex > 0)
            {
                for (int i = 0; i < InputIndex; i++)
                {
                    if (product[i, 0] == searchproduct)
                    {
                        productIndexUpdate = i;
                        break;
                    }
                }
                if (productIndexUpdate != -1)
                    {
                        Console.WriteLine("enter Quntity Updated");
                        string NewQuntity = Console.ReadLine();
                        product[productIndexUpdate, 1] = NewQuntity;
                        Console.WriteLine(" Quntity updated successfuly !");
                }
                
            }
            else
            {
                Console.WriteLine("product not found ");
            }
        }
    }
}
