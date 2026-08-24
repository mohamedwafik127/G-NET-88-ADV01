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

        #region Question_05

        //5: Write a generic method FindMax<T> that finds maximum value

        //    public static T FindMax<T>(T[] array) where T : IComparable<T>
        //    {
        //        T max = array[0];

        //        foreach (T index in array)
        //        {
        //            if (index.CompareTo(max) > 0)
        //            {
        //                max = index;
        //            }
        //        }

        //        return max;
        //    }

        #endregion

        #region Question_06

        //6: What is a generic interface? Write IRepository<T>. 

        //A generic interface is an interface that allows you to define an interface with a placeholder for the data type it will operate on. This allows you to create an interface that can work with any data type and not being limited to a specific type.

        #endregion

        #region Question_07

        //7: What is the 'struct' constraint? Write an example.

        //The 'struct' constraint is a constraint that can be applied to a generic type parameter to specify that the type must be a value type.

        //public static void PrintValue<T>(T value) where T : struct
        //{
        //    Console.WriteLine(value);
        //}

        #endregion

        #region Question_08

        //8: What is the 'class' constraint? Write an example.

        //The 'class' constraint is a constraint that can be applied to a generic type parameter to specify that the type must be a reference type.

        //public static void PrintReference<T>(T value) where T : class
        //{
        //    Console.WriteLine(value);
        //}

        #endregion

        #region Question_09

        //9: What is the 'new()' constraint? Write an example.

        //The 'new()' constraint is a constraint that can be applied to a generic type parameter to specify that the type must have a public parameterless constructor.

        //public static T CreateObject<T>() where T : new()
        //{
        //    return new T();
        //}

        #endregion

        #region Question_10

        //10:  What is the interface constraint? Write an example.

        //An interface constraint specifies that the generic type must implement a particular interface.

        //public static void PrintName<T>(T obj) where T : IName
        //{
        //    Console.WriteLine(obj.Name);
        //}

        //interface IName
        //{
        //    string Name { get; }
        //}

        //class Person : IName
        //{
        //    public string Name { get; set; }
        //}

        #endregion

        #region Question_11

        //11: What is the base class constraint? Write an example.

        //A base class constraint specifies that the generic type must inherit from a particular base class.

        //public static void ShowInfo<T>(T obj) where T : Animal
        //{
        //    obj.Speak();
        //}

        //class Animal
        //{
        //    public void Speak()
        //    {
        //        Console.WriteLine("Animal speaks");
        //    }
        //}

        //class Dog : Animal
        //{
        //}

        #endregion

    }
}






