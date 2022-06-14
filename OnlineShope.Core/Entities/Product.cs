﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShope.Core.Entities
{
    public class Product
    {
        //[Key]
        public int Id { get; set; }
       // [MaxLength(100), Required]
        public string ProductName { get; set; }
        public long Price { get; set; }
        public long? PriceWithComma { get; set; }

        public byte[] Thubmnail { get; set; }
        public string ThumbnailFileName { get; set; }
        public long ThumbnailFileSize { get; set; }
        public string ThumbnailFileExtension { get; set; }
    }
}
