using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Core
{
	public class Product
	{
		/*public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Price {  get; set; }
        [Required]
        public string Category { get; set; }

        public string? Image {  get; set; } = string.Empty;
        */
		public int Id { get; set; }
		[Required]
		[MaxLength(50)]
		public string ProductName { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string Color { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
	

	
	}
}
