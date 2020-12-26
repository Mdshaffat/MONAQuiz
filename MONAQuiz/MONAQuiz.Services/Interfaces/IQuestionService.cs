
using MONAQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MONAQuiz.Services.Interfaces
{
    public interface IQuestionService
    {
        Task AddQuestion(Question question);
    }
}
