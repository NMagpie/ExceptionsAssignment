namespace Exceptions
{
    internal class Car
    {

        private readonly Seat[] seats = [new Seat(), new Seat(), new Seat(), new Seat()];

        public void SeatOn(int seatNr) {
            try
            {
                seats[seatNr].SeatOn();
            }
            catch (InvalidSeatStateException)
            {
                //4. Rethrow exception​s

                throw;
            }
            catch (IndexOutOfRangeException e)
            {
                //4. Rethrow exception​s

                throw new IndexOutOfRangeException($"No such seat in the car: {seatNr}!", e);
            }

            Console.WriteLine($"A passenger has succesfully sat on seat {seatNr}.");
        }

        public void FreeSeat(int seatNr)
        {
            seats[seatNr].FreeSeat();

            Console.WriteLine($"A passenger has succesfully freed seat {seatNr}.");
        }

        public void FreeAllSeats()
        {
            foreach (var seat in seats)
                seat.FreeSeat();

            Console.WriteLine("All seats have been freed successfully.");
        }

        private class Seat
        {
            private bool isFree = true;

            //1. Create methods which checks input arguments and throws exceptions​

            public void SeatOn()
            {
                if (!isFree)
                    throw new InvalidSeatStateException("The seat must be free to seat on!");

                isFree = false;
            }

            public void FreeSeat() => isFree = true;

        }
    }
}
