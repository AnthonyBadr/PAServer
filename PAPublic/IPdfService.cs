namespace PAPublic
{
    public interface IPdfService
    {
        List<Assignment> GetAssimgents(Guid id);
        Assignment Save(Assignment assignment, Guid courseid);
        Assignment Upload(Guid assigmentId, byte[] pdf);
        void Delete(Guid id);
        void DeleteAssigment(Guid id);
        Assignment Update(Assignment assignment);
    }
}
