namespace BlueGlasses.SimpleLibrary.Utility
{
    public static class Calculator
    {
        public static int Tambah (int a, int b)
        {
            return a + b;
        }

        public static int Kali(int a, int b) 
        {
            return a * b;
        }

        public static int Kurang(int a, int b) 
        {
            return a - b;
        }

        public static int TambahSatu(int a)
        {
            return Tambah(a, 1);
        }

        public static int PangkatDua(int a)
        {
            return Kali(a, a);
        }
    }
}