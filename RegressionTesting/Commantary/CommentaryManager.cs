using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Commantary
{
    public class CommentaryManager
    {
        private ICommentaryRepository repo_;
        public CommentaryManager(ICommentaryRepository repo) 
        {
            repo_ = repo;
        }

        public List<string> GetUserComments(string login)
        {
            var data = repo_.GetAllCommentaries();
            if(data.ContainsKey(login))
            {
                return data[login];
            }

            return new List<string>();
        }

        public void AddComment(string login, string comment)
        {
            repo_.SaveComment(login, comment);
        }
    }
}
