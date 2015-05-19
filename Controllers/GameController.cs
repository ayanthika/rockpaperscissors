using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Web;
using Microsoft.AspNet.Identity;
using RockPaperScissorWebApplication.Models;


namespace RockPaperScissorWebApplication.Controllers
{
    public class GameController : Controller
    {
       
        public IActionResult Index()
        {
            UserChoiceModel userChoiceModel = new UserChoiceModel();
           
            
                return View();

         }
         
         [HttpPost]
         public IActionResult Play(UserChoiceModel userChoiceModel)
         {
             string userChoice = userChoiceModel.UserChoice;
             string computerChoice = GetComputerChoice();
             string result = DetermineWinner(userChoice, computerChoice);
             
             if (result == "Win")
             {
                 userChoiceModel.Wins++;
             }
             else if (result == "Loss")
             {
                 userChoiceModel.Losses++;
             }
             else   
             {
                 userChoiceModel.Ties++;
             }
             
             userChoiceModel.Result = result;
             userChoiceModel.ComputerResult = computerChoice;
             
             return Json(userChoiceModel);
             
         }
         
         private string DetermineWinner(string userChoice, string computerChoice)
         {
             string result;
             if (userChoice == computerChoice)
             {
                result = "Tied"; 
             }
            else if((userChoice == "rock" && computerChoice == "scissors") || (userChoice == "scissors" && computerChoice == "paper") || (userChoice == "paper" && computerChoice == "rock"))
             {
                 result = "Win";
             }
             else
             {
                 result = "Loss";
             }
             return result;
         }
         
         private string GetComputerChoice()
         {
             Random rng;
             rng = new Random();
             int choice = rng.Next(1,3);
             string computerResult;
             if (choice == 1)
             {
                 computerResult = "rock";
             }
             else if (choice == 2)
             {
                 computerResult = "paper";
             }
             else   
             {
                 computerResult = "paper";
             }
             return computerResult;
         }
    }
}




