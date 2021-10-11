using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace canciones_web_api.Models
{
    public class Cancion
    {
        //El nombre de la canción, el autor principal, la letra, y el enlace de youtube
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "error al ingresar el {0}")]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "error al ingresar el {0}")]
        public string Autor { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "error al ingresar el {0}")]
        public string Letras { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="error al ingresar el {0}")]
        [Url]
        [StringLength(100,MinimumLength =10,ErrorMessage ="la longitud de {0} debe estar entre {2} y {1}")]

        public string Link { get; set; } 

    }
}
