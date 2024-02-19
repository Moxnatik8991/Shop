﻿using Shop.Abstractions;

namespace Shop.Domain.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DataCreate { get; set; }
        public DateTime DataUpdate { get; set; }
    }
}
