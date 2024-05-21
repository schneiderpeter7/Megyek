namespace Megyek_API.Models
{
    public class UtolsoValasztasInduloModel
    {
        public string indulo_neve { get; set; }
        public string megye { get; set; }
        public string valasztasi_terulet { get; set; }
        public string partja { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
        public bool _2_3_felett_nyert { get; set; }
        public bool nyert { get; set; }
    }
}
