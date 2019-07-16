
namespace DataStructuresLibrary
{
    public class LinkedList<T> : IEnumerable
    {
        ListNode<T> Head;
        ListNode<T> Tail;

        int count = 0;

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= count)
                {
                    throw new System.IndexOutOfRangeException();
                }

                var node = Head;
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;                    
                }
                return node.Data;
            }
        }

        public void AddHead(T data)
        {
            if (count == 0)
            {
                Head = new ListNode<T>(data);
                Tail = Head;
                count = 1;
            }
            else
            {
                var node = new ListNode<T>(data);
                node.Next = Head;
                Head = node;
                count++;
            }
        }

        public void AddTail(T data)
        {
            if(count == 0)
            {
                Head = new ListNode<T>(data);
                Tail = Head;
                count = 1;
            }
            else
            {
                var node = new ListNode<T>(data);
                Tail.Next = node;
                Tail = node;
                count++;
            }
        }


        public IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }

        private class LinkedListEnumerator : IEnumerator
        {
            LinkedList<T> l;
            public LinkedListEnumerator(LinkedList<T> l)
            {
                this.l = l;
            }

            int index = -1;
            public void Reset()
            {
                index = -1;
            }

            public bool MoveNext()
            {
                return ++index < l.count;
            }

            public object Current
            {
                get
                {
                    return l[index];                     
                }
            }

        }
    }
}
