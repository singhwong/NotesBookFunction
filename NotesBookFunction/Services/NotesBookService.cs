using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using NotesBookFunction.Models;
using NotesBookFunction.UriString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesBookFunction.Services
{
    public class NotesBookService : INotesBookService<Notes>
    {
        public Task AddNote(Notes item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteNote(Notes item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Notes>> GetAllNotes(DocumentClient client)
        {
            var list = new List<Notes>();
            Uri collectionUri = UriFactory.CreateDocumentCollectionUri(BaseName.DarabaseName, BaseName.ContainerName);
            IDocumentQuery<Notes> query = client.CreateDocumentQuery<Notes>(collectionUri)
                .AsDocumentQuery();
            while (query.HasMoreResults)
            {
                foreach (var note in await query.ExecuteNextAsync())
                {
                    list.Add(note);
                }
            }
            return list;
        }

        public Task UpdateNote(Notes item)
        {
            throw new NotImplementedException();
        }
    }
}
