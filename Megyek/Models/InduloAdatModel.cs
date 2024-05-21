namespace Megyek_API.Models
{
    public class InduloAdatModel
    {
        public string indulo_neve { get; set; }
        public string választási_terület { get; set; }
        public SzavazatModel szavazatot_kapott { get; set; }
        public string országos_listája { get; set; }
        public int? utoljára_nyert { get; set; }
        public double nyerési_esélye { get; set; }
    }
}
