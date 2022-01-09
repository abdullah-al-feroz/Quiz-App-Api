
using System.Collections.Generic;

namespace QuizAppApi.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string QuizQuestion { get; set; }

        public List<QuestionOption> QuestionOption { get; set; }
    }
}
