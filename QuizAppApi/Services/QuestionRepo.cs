using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizAppApi.Data;
using QuizAppApi.Model;
using QuizAppApi.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppApi.Services
{
    public class QuestionRepo : IQuestion
    {
        private readonly DataContext _context;
        public QuestionRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<List<Question>>> GetById(int id)
        {
            //var question = await _context.Questions.FindAsync(id);
            var question = await _context.Questions
                .Include(a => a.QuestionOption)
                .Where(c => c.Id == id)
                .ToListAsync();
            return question;
        }

      
    }
}
