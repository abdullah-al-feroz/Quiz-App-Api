using Microsoft.AspNetCore.Mvc;
using QuizAppApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppApi.Repositories
{
    public interface IQuestion
    {
        public Task<ActionResult<List<Question>>> GetById(int id);
        //public Task<List<Question>> GetQuestionWithOptionById(int id);
    }
}
