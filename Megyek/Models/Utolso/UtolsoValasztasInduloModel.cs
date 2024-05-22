using Megyek_API.Models;

namespace Megyek.Models.Utolso
{
    public class UtolsoValasztasInduloModel
    {
        public string indulo_neve { get; set; }
        public string orszagoslistaja { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
        public bool nyert { get; set; }
    }
}
