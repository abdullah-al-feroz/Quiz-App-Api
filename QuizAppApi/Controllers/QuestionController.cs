using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAppApi.Model;
using QuizAppApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestion _question;

        public QuestionController(IQuestion question)
        {
            _question = question;
        }

        [HttpGet]
        public async Task<ActionResult<List<Question>>> GetByID(int id)
        {
            return await _question.GetById(id);
        }
    }
}
