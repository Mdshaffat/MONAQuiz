using System;
using System.Collections.Generic;
using System.Text;

namespace MONAQuiz.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Question> QuizQuestions { get; set; } = new List<Question>();

        public string QuizLogoUrl { get; set; }
    }
}
