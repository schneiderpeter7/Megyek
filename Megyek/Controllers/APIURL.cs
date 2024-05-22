namespace Megyek.Controllers
{
    public class APIURL
    {
        private readonly string _url = "https://3afae5be-a069-4cdd-962f-9d8feb338a68.mock.pstmn.io/Megyek";

        public string GetKorabbi(string ev)
        {
            return $"{_url}/Korabbi?ev={ev}";
        }
        public string GetKovetkezo(string megye)
        {
            return $"{_url}/Kovetkezo?megye={megye}";
        }
        public string GetPart(string part)
        {
            return $"{_url}/Part?part={part}";
        }
        public string GetUtolso(string megye) {
            return $"{_url}/Kovetkezo?megye={megye}";
        }
    }
}
