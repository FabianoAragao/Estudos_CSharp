using System;
using System.Text;
using System.Collections.Generic;

namespace PostsEComments.Entidades
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string TextoDoPost{ get; set; }
        public int Likes { get; set; }
        public List<Comment> ComentariosDoPost { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string textoDoPost, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            TextoDoPost = textoDoPost;
            Likes = likes;
        }

        public void AddComentario(Comment textoComentario)
        {
            ComentariosDoPost.Add(textoComentario);
        }

        public void RemoveComentario(Comment textoComentario)
        {
            ComentariosDoPost.Remove(textoComentario);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Titulo);
            sb.Append(this.Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(this.TextoDoPost);
            sb.AppendLine("Comentarios: ");

            foreach (Comment c in this.ComentariosDoPost)
            {
                sb.AppendLine(c.Texto);
            }

            return sb.ToString();
        }
    }
}
