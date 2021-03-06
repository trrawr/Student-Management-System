﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StorageManagementSystem.Models
{
    public class DBVenue
    {
        [Key]
        public int Venue_ID { get; set; }


        public string Venue_AdminEmail { get; set; }

        public string Venue_LoginPassword { get; set; }

        public string Venue_Latitude { get; set; }


        public string Venue_Longitude { get; set; }

        public string Venue_ContactNumber { get; set; }
        [DataType(DataType.Time)]
        public DateTime Venue_WeekDayStartTime{ get; set; }
        [DataType(DataType.Time)]
        public DateTime Venue_WeekDayEndTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime Venue_WeekEedStartTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime Venue_WeekendEndTime { get; set; }



        public string Venue_BusinessHoursWeekend { get; set; }
        public string Venue_Name { get; set; }

        
    }
}
