using System;
using Creational.Prototype.Enums;
using Creational.Prototype.Interfaces;

namespace Creational.Prototype.Prototypes
{
    internal class GreetingEmail : IGreetingEmail
    {
        public string Body;

        public GreetingEmail(EmailLanguage language)
        {
            // Some long initialization logic here:
            Body = language.ToString();
        }

        // Create a shallow copy
        public object Clone()
        {
            return MemberwiseClone() as GreetingEmail ?? throw new Exception("Some Valid Exception");
        }
    }
}