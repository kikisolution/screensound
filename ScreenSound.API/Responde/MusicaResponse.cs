using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.API.Responde
{
    public record MusicaResponse(int Id, string Nome, int ArtistaId, string NomeArtista);
}