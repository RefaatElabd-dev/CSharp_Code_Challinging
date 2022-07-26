namespace Generics.Helpers
{
    public class Stack<T>
    {
        int position;
        T[] data = new T[100];
        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];

        //indexer
        public T this[int index] => data[index];
    }

    public class Examples
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    //struct
    public struct Nullable<T>
    {
        public T Value { get; }
    }

    // multiple parameters:
    class Dictionary<TKey, TValue> {}


    //Generic type names and method names can be overloaded as long as the number of type parameters is different.
    public class A { }
    public class A<T> { }
    public class A<T1, T2> { }

}
