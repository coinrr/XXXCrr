using System.Collections.Generic;
using System.Threading.Tasks;
using Crr.EntityModels;

namespace Crr.Services
{
    public interface ITermService
    {
        Term GetById(int termId);
        IEnumerable<Term> GetAll();

        Task Create(Term term);
        Task Delete(int termId);

        Task UpdateTermName(int termId, string newName);
        Task UpdateTermLinkName(int termId, string newLinkName);
        Task UpdateTermDescription(int termId, string newDescription);
        Task UpdateTermImageUrl(int termId, string newImageUrl);

    }
}