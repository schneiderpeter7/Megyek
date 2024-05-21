using Megyek_API.Models;

namespace Megyek.Models.Kovetkezo
{
    public class KiFogNyerniInduloModel
    {
        public string indulo_neve { get; set; }
        public string valasztasi_terulet { get; set; }
        public string partja { get; set; }
        public double nyeresi_eselye { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
        public bool _2_3_felett_nyert { get; set; }
    }
}
