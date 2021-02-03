using System;
using System.Collections.Generic;
using System.Text;

namespace Innoloft.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
