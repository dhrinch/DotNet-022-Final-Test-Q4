namespace DotNet_022_Final_Test_Q4
{
    using System;
    using System.Collections.Generic;

    public class GenericClassWithConstraint<T> where T : struct
    {
        private List<T> GenericCollection;

        public GenericClassWithConstraint()
        {
            GenericCollection = new List<T>();
        }

        public void AddItemToList(T item)
        {
            GenericCollection.Add(item);
        }

        public T GetItemByIdx(int index)
        {
            if (index < 0 || index >= GenericCollection.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return GenericCollection[index];
        }

        public List<T> GetSortedDescending()
        {
            List<T> sortedList = new List<T>(GenericCollection);
            sortedList.Sort();
            sortedList.Reverse();
            return sortedList;
        }
    }
}
