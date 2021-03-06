﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JMMTaskApi.DTOs
{
    /// <summary>
    /// Data Transfer Object class to send Product Related Details in Response
    /// </summary>
    public partial class ProductDTO
    {
        public ProductDTO()
        {

        }
        public int PId { get; set; }
        public string PCode { get; set; }
        public string PName { get; set; }
        public int PPrice { get; set; }
        public int PStock { get; set; }
    }
}
