using Megyek_API.Models;

namespace Megyek.Models.Korabbi
{
    public class ValasztasInduloModel
    {
        public string indulo_neve { get; set; }
        public string valasztokerulet { get; set; }
        public string orszagoslista { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
        public bool nyert { get; set; }
    }
}
