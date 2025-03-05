using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        // Unit of work design patterni kullanacağız

        IBookRepository Book { get; }
        Task SaveAsync();
        
    }
}
