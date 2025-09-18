using Commantary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RegressionTesting
{
    [TestClass]
    public class TCommentaryManager
    {

        [TestMethod]
        public void TestGetUserCommentsExists()
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

        [TestMethod]
        public void TestGetUserCommentsNotExists()
        {
            var manager = new CommentaryManager(new CommentaryRepo());

            manager.AddComment("Петр", "Я сегодня устал");
            manager.AddComment("Петр", "Я вчера устал");
            manager.AddComment("Петр", "Я в принципе устал");
            manager.AddComment("Юлия", "А я никогда не устаю");

            List<string> userComments = manager.GetUserComments("Левый пользователь");
            Assert.IsTrue(userComments.Count == 0);
        }

        [TestMethod]
        public void TestSearchUserCommentsByTemplate()
        {
            var manager = new CommentaryManager(new CommentaryRepo());

            manager.AddComment("Петр", "Я сегодня устал");
            manager.AddComment("Петр", "Я вчера устал");
            manager.AddComment("Петр", "Я в принципе устал");
            manager.AddComment("Юлия", "А я никогда не устаю");

            List<string> actualComments = manager.SearchUserCommentsByTemplate("Петр", "ер");

            List<string> expected = new List<string> { "Я вчера устал" };
            CollectionAssert.AreEqual(expected, actualComments);
        }

        [TestMethod]
        public void TestSearchUserCommentsByTemplateEmptyResult()
        {
            var manager = new CommentaryManager(new CommentaryRepo());

            manager.AddComment("Петр", "Я сегодня устал");
            manager.AddComment("Петр", "Я вчера устал");
            manager.AddComment("Петр", "Я в принципе устал");
            manager.AddComment("Юлия", "А я никогда не устаю");

            List<string> actualComments = manager.SearchUserCommentsByTemplate("Петр", "Привет");

            List<string> expected = new List<string>();
            CollectionAssert.AreEqual(expected, actualComments);
        }

        [TestMethod]
        public void TestSearchOtherUserCommentsByTemplate()
        {
            var manager = new CommentaryManager(new CommentaryRepo());

            manager.AddComment("Петр", "Я сегодня устал");
            manager.AddComment("Петр", "Я вчера устал");
            manager.AddComment("Петр", "Я в принципе устал");
            manager.AddComment("Юлия", "А я никогда не устаю");

            List<string> actualComments = manager.SearchUserCommentsByTemplate("Юлия", "уст");

            List<string> expected = new List<string>() { "А я никогда не устаю" };
            CollectionAssert.AreEqual(expected, actualComments);
        }


    }
}
