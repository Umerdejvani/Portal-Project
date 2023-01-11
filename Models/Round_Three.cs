using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Project.Models
{
    public class Round_Three
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public byte[] ImageAdmin { get; set; }

        public byte[] ImageCand { get; set; }
    }
}
