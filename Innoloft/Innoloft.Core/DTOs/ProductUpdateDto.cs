﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Innoloft.Core.DTOs
{
    public class ProductUpdateDto
    {
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public int ProductTypeId { get; set; }
        public int UserId { get; set; }
    }
}
