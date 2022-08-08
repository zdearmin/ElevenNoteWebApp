using ElevenNoteWebApp.Shared.Models.Note;

namespace ElevenNoteWebApp.Server.Services.Notes
{
    public interface INoteService
    {
        Task<bool> CreateNoteAsync(NoteCreate model);
        Task<IEnumerable<NoteListItem>> GetAllNotesAsync();
        Task<NoteDetail> GetNoteByIdAsync(int noteId);
        Task<bool> UpdateNoteAsync(NoteEdit model);
        Task<bool> DeleteNoteAsync(int noteId);
        void SetUserId(string userId);
    }
}
