﻿namespace Shop.Abstractions
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DataCreate { get; set; }
        public DateTime DataUpdate { get; set; }
    }
}