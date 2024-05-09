
using PADatabase;

namespace PAPublic
{
    public class PdfService2 : IPdfService
    {

        private readonly ApplicationDbContext _context;

        public PdfService2(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(Guid id)
        {
            _context.Assignments.SingleOrDefault(x => x.Id == id).PdfData = null;
            _context.SaveChanges();
        }

        public List<Assignment> GetAssimgents(Guid courseId)
        {
           return _context.Assignments.Where(c=>c.CourseId== courseId).ToList();
        }

        public Assignment Save(Assignment assignment,Guid courseid)
        {
            assignment.CourseId = courseid;
             _context.Assignments.Add(assignment);
            _context.SaveChanges();
            return assignment;

        }

        public Assignment Upload(Guid assigmentId, byte[] pdf)
        {
            _context.Assignments.SingleOrDefault(x => x.Id == assigmentId).PdfData = pdf;
            _context.SaveChanges();
            return _context.Assignments.SingleOrDefault(x => x.Id == assigmentId);

            
        }

        public Assignment Update(Assignment assignment)
        {
            var existingAssignment = _context.Assignments.Find(assignment.Id);
            if (existingAssignment != null)
            {
                existingAssignment.Title = assignment.Title;
                existingAssignment.Description = assignment.Description;
                existingAssignment.DueDate = assignment.DueDate;
                // Update other properties as needed
                _context.SaveChanges();
                return existingAssignment;
            }
            return null; // Or handle accordingly if assignment not found
        
        }

        public void DeleteAssigment(Guid id)
        {
            var assignmentToDelete = _context.Assignments.FirstOrDefault(x => x.Id == id);
            if (assignmentToDelete != null)
            {
                _context.Assignments.Remove(assignmentToDelete);
                _context.SaveChanges();
            }
            // Handle if assignment with the provided ID does not exist
        }
    }


}
