using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.API.Requests
{
    public record ArtistaRequest(string nome,string bio, string fotoPerfil);
}