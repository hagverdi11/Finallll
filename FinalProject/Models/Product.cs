﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }
        public int Discount { get; set; }
        public DateTime CreateDate { get; set; }
        public int ProductCategoryId { get; set; }
        public int BrandId { get; set; }
        public Brand Brands { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<Product_Size> Product_Sizes { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
