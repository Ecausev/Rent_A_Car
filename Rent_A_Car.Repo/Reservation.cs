//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rent_A_Car.Repo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int Res_ID { get; set; }
        public int Veh_ID { get; set; }
        public int Cli_ID { get; set; }
        public int Emp_ID { get; set; }
        public System.DateTime Date_Created { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ResCalendar ResCalendar { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
