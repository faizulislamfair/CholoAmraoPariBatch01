using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVCWebApp.Models
{
    public class StudentModel
    {
        public String Country { get; set; }
        public String Name { get; set; }
        public String University { get; set; }
        public String Dept { get; set; }
        public Int64 Roll { get; set; }
        public Int64 Age { get; set; }
        public String District { get; set; }
    }
}