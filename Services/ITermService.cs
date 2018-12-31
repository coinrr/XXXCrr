using System.Collections.Generic;
using System.Threading.Tasks;
using Crr.EntityModels;

namespace Crr.Services
{
    public interface ITermService
    {
        Term GetById(string linkName);
        IEnumerable<Term> GetAll();

        Task Create(Term term);
        Task Delete(string linkName);

        Task UpdateTermName(string linkName, string newName);
        Task UpdateTermLinkName(string linkName, string newLinkName);
        Task UpdateTermDescription(string linkName, string newDescription);
        Task UpdateTermImageUrl(string linkName, string newImageUrl);

    }
}