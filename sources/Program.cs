// See https://aka.ms/new-console-template for more information
using darkness.Tools;

NameGenerator Generator = new NameGenerator();
string name = Generator.GenerateNameRandomLength(3,4);
Console.WriteLine(name);