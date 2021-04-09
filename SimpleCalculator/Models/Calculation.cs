using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SimpleCalculator.Models
{
    public class Calculation
    {
        [Required(ErrorMessage = "Please, enter first number")]
        public double FirstNumber { get; set; }

        [Required(ErrorMessage = "Please, enter second number")]
        public double SecondNumber { get; set; }

        public double Result { get; set; }

        [Required(ErrorMessage = "Please, select operation type")]
        [EnumDataType(typeof(OperationType))]
        public OperationType OperationType { get; set; }

        public string[] LastFiveCalculations { get; set; }
    }
}

    
