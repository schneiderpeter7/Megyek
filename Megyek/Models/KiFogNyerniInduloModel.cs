namespace Megyek_API.Models
{
    public class KiFogNyerniInduloModel
    {
        public string indulo_neve { get; set; }
        public string választási_terulet { get; set; }
        public string pártja { get; set; }
        public double nyerési_esélye { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
        public bool _2_3_felett_nyert { get; set; }
    }
}
