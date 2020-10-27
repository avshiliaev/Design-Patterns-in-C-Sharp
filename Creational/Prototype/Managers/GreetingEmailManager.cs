using System.Collections.Generic;
using Creational.Prototype.Enums;
using Creational.Prototype.Interfaces;

namespace Creational.Prototype.Managers
{
    internal class GreetingEmailManager
    {
        private readonly Dictionary<EmailLanguage, IGreetingEmail> _emails =
            new Dictionary<EmailLanguage, IGreetingEmail>();

        // Indexer
        public IGreetingEmail this[EmailLanguage key]
        {
            get => _emails[key];
            set => _emails.Add(key, value);
        }
    }
}