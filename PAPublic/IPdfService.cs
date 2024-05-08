namespace PAPublic
{
    public interface IPdfService
    {
        List<Assignment> GetAssimgents();
        Assignment Save(Assignment assignment);
        Assignment Upload(Assignment assignment);
        void Delete(Guid id);
    }
}
