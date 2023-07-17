using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace webapp
{
    public class AppUser :  IdentityUser 
    {
        [Column(TypeName ="nvarchar")]
        [StringLength(350)]
        public string Home{get;set;}
    }
}
