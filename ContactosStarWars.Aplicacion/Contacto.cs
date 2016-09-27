using System.Collections.Generic;

namespace ContactosStarWars.Aplicacion
{
    public class Contacto
    {
        public string edited { get; set; }
        public string name { get; set; }
        public string created { get; set; }
        public string gender { get; set; }
        public string skin_color { get; set; }
        public string hair_color { get; set; }
        public string height { get; set; }
        public string eye_color { get; set; }
        public string mass { get; set; }
        public int homeworld { get; set; }
        public string birth_year { get; set; }
        public string image { get; set; }
        public int id { get; set; }
        public List<int> vehicles { get; set; }
        public List<int> starships { get; set; }
        public List<int> films { get; set; }
    }
}