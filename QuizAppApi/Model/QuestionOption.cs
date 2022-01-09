namespace QuizAppApi.Model
{
    public class QuestionOption
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool isAnswer { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

    }
}
