using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluateRs.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string NombreCompleto { get; set; }

        public string TipoAdjunto { get; set; }
    }
}
