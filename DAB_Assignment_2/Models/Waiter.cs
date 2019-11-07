using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAB_Assignment_2.Models
{
    public class Waiter : Person
    {
        public int WaiterId { get; set; }
        public int Salary { get; set; }
        public virtual List<Table> Tables { get; set; }
    }
}
