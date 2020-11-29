﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _004_DoubleLinkedLists
{
    class Node
    {
        public Node(int val)
        {
            Value = val;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
}