using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

﻿using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests
{
    public record GeneroRequest(string Nome, string Descricao);
}