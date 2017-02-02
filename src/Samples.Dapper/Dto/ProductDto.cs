﻿using System;

namespace Samples.Dapper.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float? Price { get; set; }

        public DateTime Created { get; set; }
    }
}
