using Megyek_API.Models;

namespace Megyek.Models.Kovetkezo
{
    public class KiFogNyerniInduloModel
    {
        public string indulo_neve { get; set; }
        public string orszagoslista { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
    }
}
