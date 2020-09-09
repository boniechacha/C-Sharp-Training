using System;

namespace SoftNetTraining
{
    public class Repository<T>
    {
        private T[] storage;

        public Repository(int size)
        {
            storage = new T[100];
        }

        public void save(int id, T entity)
        {
            ValidateId(id);
            storage[id] = entity;
        }

        public void delete(int id)
        {
            ValidateId(id);
            storage[id] = default(T);
        }

        public T get(int id)
        {
            ValidateId(id);
            return storage[id];
        }

        public T[] getAll()
        {
            int size = getSize();
            if (size == 0)
            {
                return Array.Empty<T>();
            }
            else
            {
                T[] content = new T[size];
                int index = 0;
                foreach (var entity in storage)
                {
                    if (entity != null)
                        content[index] = entity;
                }
        
                return content;
            }
        }
        
        public int getSize()
        {
            int count = 0;
            foreach (var entity in storage)
            {
                if (entity != null)
                    count++;
            }
        
            return count;
        }
        
        
        private void ValidateId(in int id)
        {
            if (id < 0) throw new IndexOutOfRangeException("Id should be greater or equal to zero");
            if (id >= storage.Length)
                throw new IndexOutOfRangeException("Id should be between 0 and " + (storage.Length - 1));
        }
    }
}