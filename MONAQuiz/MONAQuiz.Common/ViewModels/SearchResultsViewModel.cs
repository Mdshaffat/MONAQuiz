using MONAQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MONAQuiz.Common.ViewModels
{
    public class SearchResultsViewModel
    {
        public List<Quiz> Quizzes { get; set; }

        public string SearchTerm { get; set; }
    }
}
