﻿using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels.ProductViewModels
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public int SizeId { get; set; }
        public List<Models.Size> Sizes { get; set; }
        public IEnumerable<int> Product_sizeList { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
