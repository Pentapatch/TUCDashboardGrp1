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

        private List<BookingClass> bookingClassList;

        public DataHandler()
        {
            bookingClassList = new List<BookingClass>();
        }






        /// <summary>
        /// https://stackoverflow.com/questions/59576074/how-to-get-response-like-this-by-using-a-sql-server-stored-procedure
        /// </summary>
        /// <returns></returns>

        // List here! 
        

        public BookingClass CreateBooking()   
        {
            var booking = new BookingClass { Name = DateTime.UtcNow.Ticks.ToString() };   // Using DateTime Now to populate with unique "id's"
            bookingClassList.Add(booking);

            return booking;
        }

        public List<BookingClass> GetBookings()
        {
            return bookingClassList;
        }
        
        //public void ListBookings()
        //{
            
        //    // Get the LIST "bookings" and feed it to the appropriated Widget
        //    // ForeEach Element in LIST -> IF ROOM = Group -> Group Widget ELSE -> LectureHall
            
        //}

    }
   

}
