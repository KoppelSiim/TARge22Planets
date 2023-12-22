//using Planets.;
using Esaared.Models; // references Models folder
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esaared.Services
{
    internal static class eSaaredServices
    {

        private static List<Saared> saared = new() // references models folder i think
        {
            new()
            {
                Name = "Pakri",
                // Todo fix png reference
                // Todo fix all references
                // Todo, move project to Saared project branch
                //SaarImage = spakri.png,
                Description = "See on saar"

            }
        };

    }
}
