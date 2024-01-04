using Basic.Entities.Execptions;

namespace Basic.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainExeception("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdadeDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                //thorow igual o return
                throw new DomainExeception("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainExeception("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room: "
            + RoomNumber
            + ", check-in: "
            + CheckIn.ToString("dd/MM/yyy")
              + ", check-out: "
            + CheckOut.ToString("dd/MM/yyy")
            + ", "
            + Duration()
            + " nights";

            
        }
    }
}
