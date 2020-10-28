using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Concrete
{
    public class Movie:EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        
        public string ThumbNail { get; set; }
        public int CategoryId { get; set; }
        //public int CommentId { get; set; }
        public int Time { get; set; }
        public string Scenarist { get; set; }
        public string Production { get; set; }
        public Category Category { get; set; }
        //public Comment Comment { get; set; }
        public ICollection<Comment> Comments { get; set; }

       

    }
}
