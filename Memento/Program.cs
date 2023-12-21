using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditorMemento textEditor = new TextEditorMemento("Hello World!");
            TextEditorMemento textEditor2 = new TextEditorMemento("Hello Moon");

            TextEditor editor = new TextEditor(textEditor);
            TextEditor editor2 = new TextEditor(textEditor2);

            Memento editorMemento = editor.CreateMemento();
            Memento editorMemento1 = editor2.CreateMemento();
            Store store = new Store();
            store.Add(editorMemento);
            Memento previousMemento = store.Previous();
            store.Add(editorMemento1);
            TextEditor restoredEditor = new TextEditor(previousMemento);
            Console.WriteLine(restoredEditor.GetState());

            Console.ReadLine();
        }
    }
}
