﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Dtos.About
{
    public class ResultAboutDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desciption { get; set; }
        public string ImageUrl { get; set; }
    }
}
