using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car :IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
