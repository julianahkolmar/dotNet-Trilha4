using System;

namespace TodoApi;

public class WeatherForecast
{
    public long Id { get; set; }
    public string? fullName { get; set; }
    public string? email { get; set; }
    public string? emailConfirmation { get; set; }
    public string? cpf { get; set; }
    public string? cellphone { get; set; }
    public DateTime dayOfBirth { get; set; }
    public bool emailSms { get; set; }
    public bool whatsapp { get; set; }
    public string? country { get; set; }
    public string? city { get; set; }

    internal IEnumerable<WeatherForecast> GetAll()
    {
        throw new NotImplementedException();
    }

    public string? postalCode { get; set; }
    public string? address { get; set; }
    public int number { get; set; }

    internal object Save(WeatherForecast? value)
    {
        throw new NotImplementedException();
    }
}
