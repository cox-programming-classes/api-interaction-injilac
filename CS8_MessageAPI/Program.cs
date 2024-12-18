global using ErrorAction = System.Action<CS8_MessageAPI.Models.ErrorRecord>;
using CS8_MessageAPI.Models;
using CS8_MessageAPI.Services;
//This is Postman Analog
var apiService = new ApiService();

var loginSuccess = true;

await apiService.Login("injila.chowdhury@winsor.edu", "Fnaznur112007!",
    err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    });
    
if(!loginSuccess)
    return;
    
    var myFreeBlocks= await apiService.SendAsync<FreeBlockCollection>(
        HttpMethod.Get,
        "api/schedule/free-blocks/for/RGoE6ww361Y9",
        err =>
        {
            Console.WriteLine(err);
        }
        )