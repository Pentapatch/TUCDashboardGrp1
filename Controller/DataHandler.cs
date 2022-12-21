﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TUCDashboardGrp1.Controller
{

    
    //

    internal class DataHandler
    {

        public List<BookingClass> BookingClassList { get; private set; } = new();

        // https://stackoverflow.com/questions/59576074/how-to-get-response-like-this-by-using-a-sql-server-stored-procedure

        public BookingClass CreateBooking()   
        {
            var booking = new BookingClass { Name = DateTime.UtcNow.Ticks.ToString() };   // Using DateTime Now to populate with unique "id's"
            BookingClassList.Add(booking);

            return booking;
        }

        public List<BookingClass> GetBookings()
        {
            return BookingClassList;
        }
        
    }
   

}
