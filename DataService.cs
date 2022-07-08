using TodoApi;
namespace TudoApi
{
    public class DataService
    {
        public List<WeatherForecast> Data { get; set; } = new List<WeatherForecast>();
        public void Add()
        {
            Data.Add(new WeatherForecast()
            {
                Id = 1234,
                fullName = "Gabriela Fagundes",
                email = "gabrielafagundes@gmail.com",
                emailConfirmation = "gabrielafagundes@gmail.com",
                cpf = "65478652612",
                cellphone = "51994846363",
                dayOfBirth = DateTime.FromOADate(19 - 12 - 2002),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "94529042",
                address = "Av. Osvaldo Aranha",
                number = 120
            });
            Data.Add(new WeatherForecast()
            {
                Id = 7432,
                fullName = "Agnes Vargas",
                email = "agnesdevargas13@gmail.com",
                emailConfirmation = "agnesdevargas13@gmail.com",
                cpf = "12309834522",
                cellphone = "51998563795",
                dayOfBirth = DateTime.FromOADate(13 - 04 - 2004),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "94828640",
                address = "Rua Saldanha da Gama",
                number = 123
            });
            Data.Add(new WeatherForecast()
            {
                Id = 5643,
                fullName = "Jeferson Kolmar",
                email = "jefersonkolmar12@gmail.com",
                emailConfirmation = "jefersonkolmar12@gmail.com",
                cpf = "98765423411",
                cellphone = "51984267205",
                dayOfBirth = DateTime.FromOADate(19 - 12 - 2002),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "94828600",
                address = "Rua Integração",
                number = 120
            });
            Data.Add(new WeatherForecast()
            {
                Id = 3446,
                fullName = "Tania Ferreira",
                email = "tania.ferreira@gmail.com",
                emailConfirmation = "tania.ferreira@gmail.com",
                cpf = "97678523465",
                cellphone = "51987439278",
                dayOfBirth = DateTime.FromOADate(04 - 08 - 2003),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "94828630",
                address = "Rua dos Maias",
                number = 1335
            });
            Data.Add(new WeatherForecast()
            {
                Id = 6124,
                fullName = "Susana Araujo",
                email = "susanadesouza10@gmail.com",
                emailConfirmation = "susanadesouza10@gmail.com",
                cpf = "09812356700",
                cellphone = "51985453278",
                dayOfBirth = DateTime.FromOADate(25 - 05 - 1974),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Alvorada",
                postalCode = "94828670",
                address = "Rua Integração",
                number = 49
            });
            Data.Add(new WeatherForecast()
            {
                Id = 5,
                fullName = "Rose Silva",
                email = "rosesilva01@gmail.com",
                emailConfirmation = "rosesilva01@gmail.com",
                cpf = "64398765932",
                cellphone = "51912309865",
                dayOfBirth = DateTime.FromOADate(29 - 07 - 2003),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Alvorada",
                postalCode = "94828540",
                address = "Rua Colibris",
                number = 85
            });
        }
    }
}