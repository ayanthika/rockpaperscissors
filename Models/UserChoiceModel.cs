using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorWebApplication.Models
{
    public class UserChoiceModel
    {
        public string UserChoice
        {
            get;
            set;
        }

        public string Result
        {
            get;
            set;
        }

        public int Wins
        {
            get;
            set;
        }

        public int Losses
        {
            get;
            set;
        }

        public int Ties
        {
            get;
            set;
        }

        public string ComputerResult
        {
            get;
            set;
        }
    }
}