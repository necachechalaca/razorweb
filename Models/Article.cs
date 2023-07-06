using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp
{
    [Table("Dulieu")]
    public class Article 
    {
        [Key]
        public int Id{ get;set;}
        [StringLength(250)]
        [Required]
        [Column(TypeName ="nvarchar")]

        public string Title{ get;set;}
        [DataType( DataType.Date)]
        [Required]

        public DateTime Created{ get;set;}
        [Column(TypeName ="ntext")]
        public int Content{ get;set;}
    }
}