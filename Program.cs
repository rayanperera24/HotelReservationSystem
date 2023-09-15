using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationsystem
{

    class rooms
    {
        protected int roomno;
        protected int feeforastay;


        public void askname()
        {
            string name;
            Console.WriteLine("------Welcome------\n\nWhats your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("------Welcome Mr/Mrs." + name+"------");
        }

        public void displayroomnumbers()
        {
            Console.WriteLine();
            Console.WriteLine("What room would you like to book ?");
            Console.WriteLine("        ROOM1------Luxuryroom\n        ROOM2------Deluxeroom\n        ROOM3------Suitroom\n");
        }
        public int setdata(int r01, int r02, int r03)
        {
            
            Console.WriteLine("Enter the room number you want:");
            roomno = Convert.ToInt32(Console.ReadLine());
            if (roomno == 1)
            {
                Console.WriteLine();
                Console.WriteLine("-------You Have booked our finest luxury room-------");
                Console.WriteLine("-------FEE FOR A STAY IN LUXURY ROOM-------$" + r01);
                return r01;

            }
            else if (roomno == 2)
            {
                Console.WriteLine();
                Console.WriteLine("-------You Have booked our finest Deluxe room-------");
                Console.WriteLine("-------FEE FOR A STAY IN DELUXE ROOM-------$" + r02);
                return r02;
            }
            else if(roomno == 3)
            {
                Console.WriteLine();
                Console.WriteLine("-------You Have booked our finest Suit room-------");
                Console.WriteLine("-------FEE FOR A STAY IN SUIT ROOM-------$" + r03);
                return r03;

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("-------Sorry " + roomno+ " is already BOOKED-------");
            }

            return 0;

        }



    }

    class reservations :rooms
    {
        int daystobebook;
       

        public  void setdaystobebook()
        {
            Console.WriteLine();
            Console.WriteLine("How many days Would you Like to Stay Sir/Madam");
            daystobebook=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-------For " + daystobebook+" days");
        }

        public void calpayment(int feeforastay)

        {
      
            Console.WriteLine("-------YOUR PAYMENT -------" + daystobebook * feeforastay+"$");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            rooms rooms = new rooms();
            reservations r1 = new reservations();
            int feeforstay;
            rooms.askname();
            
            rooms.displayroomnumbers();
            feeforstay = rooms.setdata(100, 200, 300); 
            r1.setdaystobebook();
            r1.calpayment(feeforstay);
            



            Console.ReadKey();

        }
    }
}
