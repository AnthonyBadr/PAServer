using Microsoft.EntityFrameworkCore;
using PADatabase;
using PADatabase.Models;

namespace PAPublic
{
    public class PdfService
    {
        private readonly ApplicationDbContext _context;

        public PdfService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UploadAsync(PdfFile file)
        {
            _context.PdfFiles.Add(file);
            await _context.SaveChangesAsync();
        }

        public async Task<PdfFile> DownloadAsync(Guid id)
        {
            return await _context.PdfFiles.FindAsync(id);
        }

        public async Task<List<PdfFile>> GetAllFilesAsync()
        {
            return await _context.PdfFiles.ToListAsync();
        }

    }
}
