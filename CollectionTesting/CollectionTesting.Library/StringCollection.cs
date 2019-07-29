using System;
using System.Collections.Generic;

namespace CollectionTesting.Library
{
    public class StringCollection
    {
        private readonly List<string> list = new List<string>();
        //readonly only stops from reassigning the values doesn't prevent from changing the state of the object like with add or remove
        public void Add(string s)
        {
            list.Add(s);
                
        }

        public void Remove(string s)
        {
            list.Remove(s);
        }
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
}