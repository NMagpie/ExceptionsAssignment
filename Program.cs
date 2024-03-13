using Exceptions;

var car = new Car();

//3. Write try-catch-finally block with multiple catch statements​

try
{
    car.SeatOn(1);

    //5. Add conditional compilation symbols

#if EXCEPTION_TESTING
    car.SeatOn(-1);
#endif

#if DEBUG
    car.SeatOn(1);
#endif
}
catch (InvalidSeatStateException e)
{
    Console.WriteLine(e.Message);
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    car.FreeAllSeats();
}