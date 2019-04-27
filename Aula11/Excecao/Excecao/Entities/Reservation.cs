using Excecao.Entities.Exception;
using System;
using System.Text;

namespace Excecao.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn > checkOut)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //   return (CheckOut - CheckIn).Days;
            return (int)CheckOut.Subtract(CheckIn).TotalDays;
        }

        public void UpdateDays(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkIn > checkOut)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }


            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Reservation: Room {RoomNumber}, check-in: {CheckIn.ToShortDateString()}, check-out: {CheckOut.ToShortDateString()}, {Duration()} nights ");
            return builder.ToString();
        }
    }
}
