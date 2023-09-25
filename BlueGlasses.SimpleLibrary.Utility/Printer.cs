namespace BlueGlasses.SimpleLibrary.Utility
{
    public static class Printer
    {
        public static void Print(string str)
        {
            Console.WriteLine($"PRINTER: {str}");
        }

        public static void Print(int i) 
        {
            Console.WriteLine($"PRINTER: {i}");
        }
    }
}
