﻿namespace Crystal.Models
{
    public partial class BibliogrLanguage
    {
        public int Id { get; set; }
        public int BibliogrId { get; set; }
        public int LanguageId { get; set; }
        public string Authors { get; set; }
        public string Source { get; set; }
        public string Title { get; set; }

        public BibliogrInvariant Bibliogr { get; set; }

        public override string ToString()
        {
            var referenceTag = $"<a href='/References/{BibliogrId}.pdf'>pdf</a>";
            return $"{BibliogrId}. {Authors} {Title} {Source} [{referenceTag}]";
        }
    }
}