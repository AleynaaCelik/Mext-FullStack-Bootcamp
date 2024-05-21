using GptExample.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GptExample.Application.Services
{
    public interface IPromptService
    {
        void Add(AddPromptDto addPromptDto);
        List<string> GetAll(string userId);

    }
}
