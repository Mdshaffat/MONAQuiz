using MONAQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MONAQuiz.Common.ViewModels
{
    public class UserResultViewModel
    {

        public ApplicationUser User { get; set; }

        public Quiz Quiz { get; set; }

        public int UsersCorrectAnswers { get; set; }

        public int UsersWrongAnswers { get; set; }

        public int PointsEarned { get; set; }
    }
}
