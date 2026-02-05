using System;

namespace LinqLab.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //Change the selection training
        public DateTime InsertDate { get; set; }
    }
}
