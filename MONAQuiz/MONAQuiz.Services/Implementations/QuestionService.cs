using MonaQuiz.Data;
using MONAQuiz.Models;
using MONAQuiz.Services.Interfaces;
using System.Threading.Tasks;

namespace Quizaldo.Services.Implementations
{
    public class QuestionService : DataService, IQuestionService
    {
        public QuestionService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task AddQuestion(Question question)
        {
            if (question.CorrectAnswer == question.FirstOption || question.CorrectAnswer == question.SecondOption ||
                question.CorrectAnswer == question.ThirdOption || question.CorrectAnswer == question.FourthOption)
            {
                await this.context.Questions.AddAsync(question);
            }
            else
            {
                return;
            }

            await this.context.SaveChangesAsync();
        }
    }
}
