using System;
using System.Collections.Generic;
using System.Text;
using ExcecaoEx.Enities.Exceptions;

namespace ExcecaoEx.Enities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int room, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in");
            }

            RoomNumber = room;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Romm " + RoomNumber + ", check - in: " + CheckIn.ToString("d") + ", " + "check out: " +
                   CheckOut.ToString("d") + ", " + Duration() + " nights";
        }

        public void UpDateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn <= now || checkOut <= now)
            {
                //Se a condição acima não ocorrer. Lançar a exceção

                throw new DomainException("Reservation dates for update must be future dates ");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in");
            } 

            CheckIn = checkIn;
            CheckOut = checkOut;

            
        }
    }
}
