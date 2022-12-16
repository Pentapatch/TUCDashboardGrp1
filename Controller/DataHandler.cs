using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TUCDashboardGrp1.Controller
{

    


    internal class DataHandler
    {
        /// <summary>
        /// https://stackoverflow.com/questions/59576074/how-to-get-response-like-this-by-using-a-sql-server-stored-procedure
        /// </summary>
        /// <returns></returns>

        

        public BookingClass CreateBooking()   // Arg = Database response
        {
            BookingClass booking = new();
            
            /*
             *  O -> datorn
             *  datorn > värden
             *  Get Bookings for varje Object 
             *  värde 1,2,3 = LIST<obj1.värden>
             */
             



            // Populate with database values
            // booking.Room = * // Parse the Room Value from the ARG response
            return booking;
        }

        public List<BookingClass> GetBookings()
        {
            List<BookingClass> bookings = new();
            // CreateBooking for each element in the database
            return bookings;
        }
        
        //public void ListBookings()
        //{
            
        //    // Get the LIST "bookings" and feed it to the appropriated Widget
        //    // ForeEach Element in LIST -> IF ROOM = Group -> Group Widget ELSE -> LectureHall
            
        //}

    }


   

}
