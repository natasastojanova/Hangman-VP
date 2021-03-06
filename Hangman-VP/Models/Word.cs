﻿namespace Hangman.Models
{
    public class Word
    {
        public string Name { get; set; }
        public string Hint { get; set; }
        public Difficulty Difficulty { get; set; }
        public Language Language { get; set; }
        public Category Category { get; set; }

        public Word(string name, string hint, Difficulty difficulty, Language language, Category category)
        {
            Name = name;
            Hint = hint;
            Difficulty = difficulty;
            Language = language;
            Category = category;
        }
    }
}
