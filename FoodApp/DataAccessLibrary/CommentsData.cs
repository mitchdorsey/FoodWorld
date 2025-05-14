using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class CommentsData : ICommentsData
    {
        private ISqlDataAccess _db;
        public CommentsData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<Comment>> GetComments()
        {
            string sql = "Select Top (10) * From dbo.Comment";

            return _db.LoadData<Comment, dynamic>(sql, new { });
        }
        public Task InsertComment(Comment comment)
        {
            string sql = @"Insert Into dbo.Comment (Title, Note)
                            Values(@Title, @Note);";

            return _db.SaveData(sql, comment);
        }
    }
}
