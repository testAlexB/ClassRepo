using Commantary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RegressionTesting
{
    [TestClass]
    public class TCommentaryManager
    {

        [TestMethod]
        public void TestGetUserComments()
        {
            var manager = new CommentaryManager(new CommentaryRepo());

            manager.AddComment("Петр", "Я сегодня устал");
            manager.AddComment("Петр", "Я вчера устал");
            manager.AddComment("Петр", "Я в принципе устал");
            manager.AddComment("Юлия", "А я никогда не устаю");

            List<string> userComments = manager.GetUserComments("Петр");
            List<string> expected = new List<string>() { "Я сегодня устал",
                                                         "Я вчера устал",
                                                         "Я в принципе устал"};
            CollectionAssert.AreEqual(expected, userComments);
        }
    }
}
