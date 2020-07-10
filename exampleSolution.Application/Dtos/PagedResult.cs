using System;
using System.Collections.Generic;
using System.Text;

namespace exampleSolution.Application.Dtos
{
    public class PagedResult<T>
    {
        public List<T> items { set; get; }
        public int TotalRecord { set; get; }
    }
}
