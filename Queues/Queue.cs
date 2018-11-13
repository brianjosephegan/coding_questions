﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    /// <summary>
    /// Class to implement a queue.
    /// </summary>
    public class Queue<T>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Queue()
        {
            count = 0;
            items = new T[2];
        }

        /// <summary>
        /// Peeks the item in the front of the queue.
        /// </summary>
        /// <returns>The item at the front of the queue.</returns>
        public T Peek()
        {
            if (count <= 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return items[0];
        }

        /// <summary>
        /// Adds the specified item to the back of the queue.
        /// </summary>
        /// <param name="item">Item to add.</param>
        public void Add(T item)
        {
            if (count >= items.Length)
            {
                T[] newItems = new T[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }

            items[count++] = item;
        }

        /// <summary>
        /// Removes the item at the front of the queue.
        /// </summary>
        /// <returns>The item at the front of the queue.</returns>
        public T Remove()
        {
            if (count <= 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                items[i - 1] = items[i];
            }
            count--;
            return item;
        }

        /// <summary>
        /// Number of items in the queue.
        /// </summary>
        private int count;

        /// <summary>
        /// Array to store items in the queue.
        /// </summary>
        private T[] items;
    }
}
