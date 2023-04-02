using System.ComponentModel.DataAnnotations;

public class SharesiesInstrument
{
    [Key] public int Id { get; set; }
    public string InstrumentType { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public int RiskRating { get; set; }
    public string ExchangeCountry { get; set; }
    public string SharesiesId { get; set; }
    public string UrlSlug { get; set; }
}