﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> values;



        public Box()
        {
            this.values = new List<T>();

        }

        public void Add(T value)
        {
            this.values.Add(value);
        }
        public T Remove()
        {
            var last = this.values.Last();
            this.values.RemoveAt(this.values.Count - 1);
            return last;

        }
        public int Count => this.values.Count;
        
    }
}
