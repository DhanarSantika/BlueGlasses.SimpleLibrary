// See https://aka.ms/new-console-template for more information
using BlueGlasses.SimpleLibrary.Utility;

var a = Calculator.Tambah(1, 2);
var b = Calculator.Kali(a, 3);
var c = Calculator.Kurang(b, 1);
var d = Calculator.PangkatDua(c);

Printer.Print(d);
