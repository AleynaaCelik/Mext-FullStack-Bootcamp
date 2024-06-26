﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFullStack.Domain.Dtos
{
    public sealed class ProductAddDto
    {

        //sealed olarak tanımladığımızda, bu sınıfın başka bir sınıf tarafından türetilmesi mümkün olmaz.
        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
    }
}
