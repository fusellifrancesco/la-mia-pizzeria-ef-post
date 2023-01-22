using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore_01.Models {
    public class Pizza {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        
        [Column(TypeName = "varchar(300)")]
        public string Img { get; set; }

        public Pizza() { 
        }

        public Pizza(int id, string name, string description, string img) {
            Id = id;
            Name = name;
            Description = description;
            Img = img;
        }
    }

}


