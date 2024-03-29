﻿using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Concrete
{
    public class Book:EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public string ThumbNail { get; set; }
        public int CategoryId { get; set; }
        public int Page { get; set; }
        public string Writer { get; set; }
        public string Production { get; set; }
        public Category Category { get; set; }
        public ICollection<BookComment> BookComments { get; set; }

        public bool Activities { get; set; }
        public DateTime Date { get; set; }
        public bool IsClassical { get; set; }
        public string Summary { get; set; }

    }
}
