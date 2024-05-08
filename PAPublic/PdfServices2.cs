using System;
using System.Collections.Generic;
using PADatabase;

namespace PAPublic
{
    public class PdfServices2 : IPdfService
    {
        private readonly ApplicationDbContext _context;

        public PdfServices2(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Guid id)
        {
            var assignment = _context.Assignments.Find(id);
            if (assignment != null)
            {
                _context.Assignments.Remove(assignment);
                _context.SaveChanges();
            }
        }

        public List<Assignment> GetAssimgents()
        {
            return _context.Assignments.ToList();
        }

        public Assignment Save(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            _context.SaveChanges();
            return assignment;

        }

        public Assignment Upload(Assignment assignment)
        {
         _context.Assignments.SingleOrDefault(x=>x.Id == assignment.Id);
            _context.SaveChanges();
            return _context.Assignments.SingleOrDefault(x => x.Id == assignment.Id);
        }
    }
}
