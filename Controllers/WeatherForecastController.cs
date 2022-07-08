using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace TodoApi.Controllers;
[Produces("application/json")]
[ApiController]
[Route("api/Todo")]
public class WeatherForecastController : ControllerBase
{   WeatherForecast _todoForescast = new WeatherForecast();
    [Route("~/api/GetAllTodos")]
    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
        {
            return _todoForescast.GetAll();
        }
    [Route("~/api/AddTodo")]
    [HttpPost]
    public ActionResult<WeatherForecast> Post([FromBody] WeatherForecast value)
        {
             Console.WriteLine(value?.Id);
             Console.WriteLine(value?.fullName);
             Console.WriteLine(value?.email);
             Console.WriteLine(value?.emailConfirmation);
             Console.WriteLine(value?.cpf);
             Console.WriteLine(value?.dayOfBirth);
             Console.WriteLine(value?.emailSms);
             Console.WriteLine(value?.whatsapp);
             Console.WriteLine(value?.country);
             Console.WriteLine(value?.postalCode);
             Console.WriteLine(value?.address);
             Console.WriteLine(value?.number);
    var item = _todoForescast.Save(value);
    if(item != null)
        return (ActionResult<WeatherForecast>)item;
    return BadRequest();
        }
}




