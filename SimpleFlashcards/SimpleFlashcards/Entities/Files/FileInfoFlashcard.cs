﻿using SimpleFlashcards.Entities.Flashcards;
using SimpleFlashcards.ValueObjects.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFlashcards.Entities.Files
{
    public class FileInfoFlashcard : IFileInfo
    {
        public Guid Id { get; set; }
        public string ContentType { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string OriginalName { get; set; }
        public FileType Type { get; set; }
        public Guid? FlashcardId { get; set; }
        public Flashcard Flashcard { get; set; }
    }
}
