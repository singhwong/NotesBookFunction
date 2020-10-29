using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NotesBookFunction.Services
{
    public interface INotesBookService<T> where T:class
    {
        Task<IEnumerable<T>> GetAllNotes(DocumentClient client);
        Task AddNote(T item);
        Task UpdateNote(T item);
        Task DeleteNote(T item);
    }
}
