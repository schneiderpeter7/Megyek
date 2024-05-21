namespace Megyek_API.Models
{
    public class PartAdataiModel
    {
        public string neve { get; set; }
        public int ossze_induloja { get; set; }
        public List<InduloEredmenyModel> indulasi_evek { get; set; }
        public List<InduloAdatModel> adatok { get; set; }
    }
}
