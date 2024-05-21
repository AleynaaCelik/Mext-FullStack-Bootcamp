using GptExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GptExample.Domain.Entities
{
    public class GptPrompt : EntityBase<Guid>
    {
        public string PromptText { get; set; }
        public string ResponseText { get; set; }

    }
}
