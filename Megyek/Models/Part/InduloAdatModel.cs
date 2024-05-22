using Megyek_API.Models;

namespace Megyek.Models.Part
{
    public class InduloAdatModel
    {
        public string indulo_neve { get; set; }
        public string valasztasi_terulet { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
        public string orszagos_listaja { get; set; }
        public int? utoljara_nyert { get; set; }
        public double nyeresi_eselye { get; set; }
    }
}
