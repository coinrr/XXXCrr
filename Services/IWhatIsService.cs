using System.Collections.Generic;
using System.Threading.Tasks;
using Crr.EntityModels;

namespace Crr.Services
{
    public interface IWhatIsService
    {
        WhatIsTerm GetById(int termId);
        IEnumerable<WhatIsTerm> GetAll();

        Task Create(WhatIsTerm term);
        Task Delete(int termId);

        Task UpdateTermName(int termId, string newName);
        Task UpdateTermLinkName(int termId, string newLinkName);
        Task UpdateTermDescription(int termId, string newDescription);
        Task UpdateTermImageUrl(int termId, string newImageUrl);

    }
}