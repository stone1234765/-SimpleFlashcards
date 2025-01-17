﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFlashcards.Entities.Topics
{
    public class SubTopic
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Topic Topic { get; set; }
        public Guid TopicId { get; set; }
    }
}
