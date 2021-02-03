using System;
using System.Collections.Generic;
using System.Text;

namespace Innoloft.Core.Helpers
{
    public class PagingParams
    {
        private int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        public int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        public int ProductTypeId { get; set; }
    }
}
