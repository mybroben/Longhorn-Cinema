﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornCinemaFinalProject.Models
{
    public class Ticket
    {
        // Properties
        // TicketID
        public Int32 TicketID { get; set; }
        // Seat
        //[Required(ErrorMessage = "Seat is required.")]
        public String Seat { get; set; }

        // Price
        [Display(Name ="Ticket Price")]
        [DisplayFormat(DataFormatString ="{0:C}")]
        public Decimal TicketPrice { get; set; }        

        [Display(Name = "Senior Citizen Discount")]
        public String SeniorCitizenDiscount { get; set; }

        [Display(Name = "Early Purchase Discount")]
        public String EarlyDiscount { get; set; }

        // Navigation Properties
        // Order
        public virtual Order Order { get; set; }
        // Showing
        public virtual Showing Showing { get; set; }
    

    }
}