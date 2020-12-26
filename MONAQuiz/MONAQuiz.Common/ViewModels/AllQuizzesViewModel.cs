using MONAQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MONAQuiz.Common.ViewModels
{
    public class AllQuizzesViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string QuizLogoUrl { get; set; }

        public List<Question> QuizQuestions { get; set; }
    }
}
