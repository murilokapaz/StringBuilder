using System;
using System.Collections.Generic;
using System.Text;

namespace DLLStringBuild.Entities {
    class Post {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }
        public Post(DateTime date, string title, string content, int likes) {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment) {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);//para escrever e pular uma linha
            sb.Append($"{Likes} likes - {Date.ToLongDateString()} ");//mesma linha
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments) {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
