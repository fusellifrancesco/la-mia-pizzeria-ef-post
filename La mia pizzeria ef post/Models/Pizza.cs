﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore_01.Models {
    public class Pizza {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [StringLength(100, ErrorMessage = "Il campo nome non può contenere più di 100 caratteri")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        
        [Column(TypeName = "varchar(300)")]
        [StringLength(300, ErrorMessage = "Il campo immagine non può contenere più di 300 caratteri")]
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


