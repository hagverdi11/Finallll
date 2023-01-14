﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels.Slider
{
    public class SliderEditVM
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IFormFile Photo { get; set; }
    }
}
