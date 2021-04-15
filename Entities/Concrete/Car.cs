using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
    }
}
