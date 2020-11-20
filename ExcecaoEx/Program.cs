using System;
using ExcecaoEx.Enities;
using ExcecaoEx.Enities.Exceptions;

namespace ExcecaoEx
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Romm number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());


                reservation.UpDateDates(checkin, checkout);
                Console.WriteLine("Reservation Update: " + reservation);
            }
            catch (DomainException e) //Capturando uma possivel exceção do meu ApplicationException
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
