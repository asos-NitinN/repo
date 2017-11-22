using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total number of asset purchased");
            int _totalAssets = Convert.ToInt32(Console.ReadLine());

            int[] SerialNumber = new int[_totalAssets];
            DateTime[] PurchaseDate = new DateTime[_totalAssets];
            string[] AssetName = new string[_totalAssets];

            for(int i =0; i<_totalAssets; i++)
            {
                Console.WriteLine("Enter the serial number of the asset:");
                SerialNumber[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the purchase date of the asset:");
                PurchaseDate[i] = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);

                Console.WriteLine("Enter the name of the asset:");
                AssetName[i] = Console.ReadLine();

            }

            Console.WriteLine("Enter the start date to be searched:");
            DateTime _startDate = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);

            Console.WriteLine("Enter the end date to complete the search:");
            DateTime _endDate = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);

            int flag = 0;
            for(int i=0;i<_totalAssets;i++)
            {
                if(PurchaseDate[i] >= _startDate && PurchaseDate[i] <= _endDate)
                {
                    Console.WriteLine("Serial Number of the asset:{0}", SerialNumber[i]);
                    Console.WriteLine("Name of the asset:{0}", AssetName[i]);
                    flag = 1;
                }
            }

            if(flag==0)
            {
                Console.WriteLine("No assets purchased between the given dates.");
            }
            
           
        }
    }
}
