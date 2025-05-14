using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ICommentsData
    {
        Task<List<Comment>> GetComments();
        Task InsertComment(Comment comment);
    }
}