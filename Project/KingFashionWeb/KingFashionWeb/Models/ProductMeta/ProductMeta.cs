﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KingFashionWeb.Models.ProductMeta
{
    public class ProductMeta
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Key { get; set; }
        public string Content { get; set; }
        //public Product Product { get; set; }
    }
}
