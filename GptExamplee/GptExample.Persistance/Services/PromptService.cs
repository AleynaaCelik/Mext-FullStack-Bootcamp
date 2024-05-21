using GptExample.Application.Dtos;
using GptExample.Application.Services;
using GptExample.Domain.Entities;
using GptExample.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GptExample.Persistance.Services
{
    public class PromptService : IPromptService
    {
        private readonly GPTExampleDBContext _context;

        public PromptService(GPTExampleDBContext context)
        {
            _context = context;
        }
        public void Add(AddPromptDto addPromptDto)
        {
            _context.prompts.Add(new GptPrompt
            {
                Id=Guid.NewGuid(),
                 PromptText = addPromptDto.PromptText,
                 CreatedBy=addPromptDto.CreatedBy,
            });
            _context.SaveChanges();
        }

        public List<string> GetAll(string userId)
        {
            return _context.Prompts
           .Where(x => x.CreatedBy == userId)
           .Select(x => new GetPromptDto
           {
               PromptText = x.PromptText,
               ResponseText = x.ResponseText,
               CreatedDate = x.CreatedDate
           }).ToList();
        }
    }
}
