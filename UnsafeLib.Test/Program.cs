namespace UnsafeLib.Test;

class Program
{
    public struct A
    {
        public int v1;
        public string v2;
    }

    public struct B
    {
        public int v1;
        public string v2;

        public override string ToString()
        {
            return $"[B], v1: {v1}, v2: {v2}";
        }
    }

    static void Main()
    {
        var a = new A()
        {
            v1 = 1,
            v2 = "str2",
        };

        var b = UnsafeLib.Unsafe.ForceConvert<A, B>(a);
        Console.WriteLine(b);
    }
}