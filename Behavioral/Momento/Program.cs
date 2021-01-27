using Behavioral.Momento.Caretakers;
using Behavioral.Momento.Originators;

namespace Behavioral.Momento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Client code.
            var textEditor = new TextEditor("Empty Document");
            var historyStack = new HistoryStack(textEditor);

            historyStack.Backup();
            textEditor.InputText("foo");

            historyStack.Backup();
            textEditor.InputText("bar");

            historyStack.Backup();
            textEditor.InputText("baz");

            historyStack.ShowHistory();

            // Now, let's rollback!
            historyStack.Undo();
            // Once more!
            historyStack.Undo();
        }
    }
}