using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._0
{
    class Queue<T>
    {
        private class QueueNode<T> {
            internal T data;
            internal QueueNode<T> next;

            public QueueNode(T data) {
                this.data = data;
            }
        }

        private QueueNode<T> first;
        private QueueNode<T> last;

        public void add(T item) {
            QueueNode<T> node = new QueueNode<T>(item);

            if (first != null)
                first.next = node;
            else
                first = node;

            last = node;
        }

        public T remove() {
            if (first == null)
                throw new NullReferenceException();

            T item = first.data;
            first = first.next;
            if (first == null)
                last = null;

            return item;
        }

        public T peek() {
            if (first != null)
                return first.data;

            throw new NullReferenceException();
        }

        public bool isEmpty() {
            return first == null;
        }
    }
}
