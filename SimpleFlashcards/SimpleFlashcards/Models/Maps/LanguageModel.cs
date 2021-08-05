﻿using SimpleFlashcards.Entities.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFlashcards.Models.Maps
{
    public class LanguageModel
    {
        public LanguageModel()
        {

        }
        public LanguageModel(Language country)
        {
            Id = country.Id;
            Name = country.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
