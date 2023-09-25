namespace BlueGlasses.SimpleLibrary.Utility
{
    public static class Printer
    {
        public static void Print(string str, string? format = null)
        {
            if (format == null) format = "PRINTER";
            Console.WriteLine($"{format}: {str}");
        }

        public static void Print(int i, string? format = null) 
        {
            if (format == null) format = "PRINTER";
            Console.WriteLine($"{format}: {i}");
        }
    }
}
