namespace MyComp.infrastructer
{
    public class AppConfig
    {
        public TinyMCE TinyMCE = new TinyMCE();
        public Company Company = new Company();
    }

    public class TinyMCE
    {
        public string? APIKey { get; set; }
    }

    public class Company
    {
        public string? CompanyName { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyPhoneShort { get; set; }
        public string? CompanyEmail { get; set; }
    }
}
