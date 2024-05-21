using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GptExample.Application.Dtos
{
    public class GetPromptDto
    {
        public string PromptText { get; set; }
        public string ResponseText { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
