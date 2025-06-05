using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgreso2.Models
{
    public class Chiste {

        //Parecido al JSON que se recibe de la API
        /*{
         "type": "general",
         "setup": "Why do crabs never give to charity?",
         "punchline": "Because they’re shellfish.",
         "id": 346
         }*/
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
        public int id { get; set; }
    }
}
