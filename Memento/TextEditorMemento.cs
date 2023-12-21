using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class TextEditorMemento : Memento
    {
        private string _text;
        private DateTime _date;
        public TextEditorMemento(string text)
        {
            if (text == null) { throw new ArgumentNullException(nameof(text), "передан пустой текст!"); }
            _text = text;
            _date = DateTime.Now;
        }
        public string GetState()
        {
            return _text;
        }
        public DateTime GetDate()
        {
            return _date;
        }
    }
}