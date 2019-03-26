using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class NoteViewModel
    {
        public string Title { get; set; }

        public DateTime PublishTime { get; set; }

        public string Body { get; set; }
    }
}
