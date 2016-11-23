using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace måske_syg_liste.Model
{
    public class klasseinfo
    {

        //props til brug af liste
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobil { get; set; }
        public string Email { get; set; }
        public string GitHubNavn { get; set; }

        // vi overrider den normale ToString meotde for at få vores egen:
        public override string ToString()
        {
            return FirstName + " " + 
                LastName + " " + 
                Mobil + " " + 
                Email + " " + 
                GitHubNavn;
                }

    }
}
