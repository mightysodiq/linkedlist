﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customlinkedlist
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node <T> Next  {get; internal set;}
        public Node (T data)
        {
            this.Data = data;
        }
    }
}
