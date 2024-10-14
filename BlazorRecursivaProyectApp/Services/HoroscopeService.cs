public class HoroscopeService
{
    public HoroscopeResponse HoroscopeData { get; set; }

    public class HoroscopeResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string horoscope { get; set; }
        public string icon { get; set; }
        public string sign { get; set; }
        public string email { get; set; }
    }
}
