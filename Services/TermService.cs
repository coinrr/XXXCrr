using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crr.Data;
using Crr.EntityModels;

namespace Crr.Services
{
    public class TermService : ITermService
    {
        private readonly ApplicationDbContext _context;
        public TermService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(Term term)
        {
            _context.Add(term);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int termId)
        {
            var term = GetById(termId);
            
            _context.Remove(term);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Term> GetAll()
        {
            return _context.Terms;
        }

        public Term GetById(int termId)
        {
            return _context.Terms
                .Where(w => w.Id == termId)
                .FirstOrDefault();

        }

        public async Task UpdateTermDescription(int termId, string newDescription)
        {
            var term = GetById(termId);
            term.Description = newDescription;

            _context.Update(term);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTermImageUrl(int termId, string newImageUrl)
        {
            var term = GetById(termId);
            term.ImageUrl = newImageUrl;

            _context.Update(term);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTermLinkName(int termId, string newLinkName)
        {
            var term = GetById(termId);
            term.LinkName = newLinkName;

            _context.Update(term);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTermName(int termId, string newName)
        {
            var term = GetById(termId);
            term.Name = newName;

            _context.Update(term);
            await _context.SaveChangesAsync();
        }
    }
}