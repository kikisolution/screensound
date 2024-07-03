using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.API.Responde
{
    public record ArtistaResponse(int Id, string Nome, string Bio, string? FotoPerfil);
}