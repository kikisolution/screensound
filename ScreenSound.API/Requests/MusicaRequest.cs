using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.API.Requests
{
    public record MusicaRequest([Required] string nome, [Required] int ArtistaId,int anoLancamento,ICollection<GeneroRequest> Generos=null);

}