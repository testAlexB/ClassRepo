namespace Commantary
{
    public interface ICommentaryRepository
    {

        void SaveComment(string login, string text);
    }
}
