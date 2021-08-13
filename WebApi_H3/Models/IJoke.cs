using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_H3.Models
{
    // This interface represent IJoke!
    public interface IJoke
    {
        string Category { get; set; }
        string Question { get; set; }
        string Answer { get; set; }
    }
}
