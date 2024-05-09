using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PADatabase.Models;
namespace PAPublic
{
    public interface ISubmittedFile
    {

        List<AssigmentStudent> GetAssimgents(string id);
        AssigmentStudent Save(AssigmentStudent assignment, string uid,Guid aid);
        AssigmentStudent Upload(Guid assigmentId, byte[] pdf);
        void Delete(Guid id);
    }
}
