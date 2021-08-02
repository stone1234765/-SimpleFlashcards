﻿using SimpleFlashcards.Entities.Flashcards;
using SimpleFlashcards.Entities.Words;
using SimpleFlashcards.ValueObjects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFlashcards.Entities.Files
{
    public class FileInfoWordPronunciation : IFileInfo
    {
        public Guid Id { get; set; }
        public string ContentType { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string OriginalName { get; set; }
        public FileType Type { get; set; }
        public Guid? WordId { get; set; }
        public Word Word { get; set; }
    }
}
