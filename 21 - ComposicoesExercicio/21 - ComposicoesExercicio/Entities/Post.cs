
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___ComposicoesExercicio.Entities {
    class Post {
        public DateTime Moment {  get; set; }
        public string Title {  get; set; }
        public string Contet { get; set; }
        public int Likes {  get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string contet, int likes) {
            Moment = moment;
            Title = title;
            Contet = contet;
            Likes = likes;
        }
        public void AddComment(Comment c) {
            Comments.Add(c);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Tile: ");
            sb.AppendLine(Title);
            sb.Append("Content: ");
            sb.AppendLine(Contet);
            sb.AppendLine("Comments:");
            foreach(Comment c in Comments) {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
