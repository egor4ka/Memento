using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Store
    {
        private List<Memento> _mementos;
        public Store()
        {
            _mementos = new List<Memento>();
        }
        public void Add(Memento memento)
        {
            if (memento == null) { throw new ArgumentNullException(nameof(memento), "Отправлено пустое значение!"); }
            _mementos.Add(memento);
        }
        public Memento Previous()
        {
            if (_mementos.Count > 0)
            {
                return _mementos[_mementos.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("Список пуст!");
            }
        }
        public Memento GetByDate(DateTime date)
        {
            Memento? memento = _mementos.FirstOrDefault(m => m.GetDate() == date);
            if (memento != null)
            {
                return memento;
            }
            else
            {
                throw new InvalidOperationException($"Не найдено состояние для даты {date}!");
            }
        }
    }
}