using System;
using System.Collections.Generic;

namespace Stack_CSharp
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You cannot add a null object.");

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There are no objects in the stack yet.");

            int index = _list.Count - 1;

            object toReturn = _list[index];

            _list.RemoveAt(index);

            return (toReturn);
        }

        public void Clear()
        {
            _list.Clear();
        }
    }

}
