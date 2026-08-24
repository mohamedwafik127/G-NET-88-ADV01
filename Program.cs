public class Program
{
    public static void Main(string[] args)
    {

        #region Question_01

        //1: What is a generic class? Why use generics?
        //generic classes are classes that allow you to define a class with a placeholder for the data type it will operate on. This allows you to create a class that can work with any data type and not being limited to a specific type.

        #endregion

        #region Question_02

        //Q2: Write a generic class Container<T> with Add and Get methods.

        //public class Container<T>
        //{
        //    private List<T> items = new List<T>();
        //    public void Add(T item)
        //    {
        //        items.Add(item);
        //    }
        //    public T Get(int index)
        //    {
        //        if (index < 0 || index >= items.Count)
        //        {
        //            Console.WriteLine("Index is out of range.");
        //            return default;
        //        }
        //        return items[index];
        //    }
        //}

        #endregion

        #region Question_03

        //3:What are multiple type parameters? Write Pair<TKey, TValue>.

        //Multiple type parameters allow you to define a class or method that can work with multiple data types.

        #endregion

        #region Question_04

        //4: What is a generic method? Write Swap<T> method.

        //A generic method is a method that allows you to define a method with a placeholder for the data type it will operate on. This allows you to create a method that can work with any data type and not being limited to a specific type.

        #endregion

    }
}

