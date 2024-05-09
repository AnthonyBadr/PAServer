using PADatabase;
using PADatabase.Models;

namespace PAPublic
{
    public class SubmitFileService : ISubmittedFile
    {

        private readonly ApplicationDbContext _context;

        public SubmitFileService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(Guid id)
        {
            _context.AssigmentStudent.SingleOrDefault(x => x.Id == id).PdfData = null;
            _context.SaveChanges();
        }

        public List<AssigmentStudent> GetAssimgents(string id)
        {
            return _context.AssigmentStudent.Where(c => c.UserId == id).ToList();
        }

        public AssigmentStudent Save(AssigmentStudent assignment, string uid,Guid aid)
        {
            assignment.UserId = uid;
            assignment.AssignmentId = aid;
            _context.AssigmentStudent.Add(assignment);
            _context.SaveChanges();
            return assignment;
        }

        public AssigmentStudent Upload(Guid assigmentId, byte[] pdf)
        {
            _context.AssigmentStudent.SingleOrDefault(x => x.Id == assigmentId).PdfData = pdf;
            _context.SaveChanges();
            return _context.AssigmentStudent.SingleOrDefault(x => x.Id == assigmentId);
        }
    }
}
