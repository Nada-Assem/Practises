﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.BLL.DTOs
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int TopicId { get; set; }
    }
}
