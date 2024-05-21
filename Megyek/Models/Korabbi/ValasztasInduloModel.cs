using Megyek_API.Models;

namespace Megyek.Models.Korabbi
{
    public class ValasztasInduloModel
    {
        public string indulo_neve { get; set; }
        public string megye { get; set; }
        public string partja { get; set; }
        public string orszagos_lista { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
        public bool nyert { get; set; }
    }
}
