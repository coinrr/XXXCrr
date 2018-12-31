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

        public async Task Delete(string linkName)
        {
            var term = GetById(linkName);
            
            _context.Remove(term);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Term> GetAll()
        {
            return _context.Terms;
        }

        public Term GetById(string linkName)
        {
            return _context.Terms
                .Where(w => w.LinkName == linkName)
                .FirstOrDefault();

        }

        public async Task UpdateTermDescription(string linkName, string newDescription)
        {
            var term = GetById(linkName);
            term.Description = newDescription;

            _context.Update(term);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTermImageUrl(string linkName, string newImageUrl)
        {
            var term = GetById(linkName);
            term.ImageUrl = newImageUrl;

            _context.Update(term);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTermLinkName(string linkName, string newLinkName)
        {
            var term = GetById(linkName);
            term.LinkName = newLinkName;

            _context.Update(term);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTermName(string linkName, string newName)
        {
            var term = GetById(linkName);
            term.Name = newName;

            _context.Update(term);
            await _context.SaveChangesAsync();
        }
    }
}