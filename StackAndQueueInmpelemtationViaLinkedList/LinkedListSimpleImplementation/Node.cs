﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListSimpleImplementation
{
    public class Node <T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        
        public Node<T> Next { get; set; }
    }
}
