using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet002MauiBlazorApp.Models
{
    public class TodoModel
    {
        public string Description { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
