using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public Color()
        {
            Cars = new List<Car>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorId { get; set; }
        public string Name { get; set; }

        public virtual List<Car> Cars{ get; set; }
    }
}
