using System;
using Creational.Prototype.Enums;
using Creational.Prototype.Managers;
using Creational.Prototype.Prototypes;

namespace Creational.Prototype
{
    internal class Program
    {
        private static void Main()
        {
            var emailManager = new GreetingEmailManager();

            // Initialize standard emails
            emailManager[EmailLanguage.English] = new GreetingEmail(EmailLanguage.English);
            emailManager[EmailLanguage.German] = new GreetingEmail(EmailLanguage.German);
            emailManager[EmailLanguage.French] = new GreetingEmail(EmailLanguage.French);

            // Send an email based on the user's language
            SendGreetingEmail(EmailLanguage.German, ref emailManager);
        }

        private static void SendGreetingEmail(EmailLanguage language, ref GreetingEmailManager manager)
        {
            var email = manager[language].Clone() as GreetingEmail;
            if (email != null)
                Console.WriteLine(email.Body);
        }
    }
}