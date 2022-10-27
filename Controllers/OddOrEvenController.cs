// Richard Johnson
// 10-26-22
// This web API will take a number the user enters in the URL and will print text saying whether or not the number is odd or even to the screen

// Peer Review: N. HARRISON WILKINS : THE PROGRSM RUN AS EXPECTED. THE CPDE LOOKS NICE AND DOES FEATURE DATA VALIDATION,  OVERALL GREAT WORK!!!

using Microsoft.AspNetCore.Mvc;

namespace JohnsonROddOrEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route("Odd/{userInput}")]

    public string OddOrEven(string userInput)
    {
        int num = 0;
        bool isNum;
        string message = "";
        isNum = Int32.TryParse(userInput, out num);
            if(num % 2 == 0 && isNum == true)
            {
                //If the number has a remainder of two, it is an even number
                message = $"{num} is an even number.";
            }
            else if(num % 2 != 0 && isNum == true)
            {
                message = $"{num} is an odd number.";
            }
            else
            {
                message = $"{userInput} is invalid.";
            }
        return message;
    }
}
