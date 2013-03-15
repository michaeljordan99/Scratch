using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scratch.Repositories
{
    public interface IRepository
    {
        List<string> GetMessages();
    }
}
