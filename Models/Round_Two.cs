using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Project.Models
{
    public class Round_Two
    {
        public Boolean Q1 { get; set; }
        public Boolean Q2 { get; set; }
        public Boolean Q3 { get; set; }
        public Boolean Q4 { get; set; }
        public Boolean Q5 { get; set; }
        public Boolean Q6 { get; set; }
        public Boolean Q7 { get; set; }
        public Boolean Q8 { get; set; }
        public Boolean Q9 { get; set; }
        public Boolean Q10 { get; set; }

        [Key]
        public int Candidate_ID { get; set; }

        public Boolean Passed { get; set; }
    }
}
