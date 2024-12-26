using Tyuiu.RogovAYu.Sprint7.Project.V5.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.RogovAYu.Sprint7.Project.V5.Test
{
    [TestClass]
    public sealed class Test1
    {
        DataService ds = new();
        [TestMethod]
        public void LoadTest()
        {
            string[,] matrix = { { "1","Fanta","20","100","fanta"},
                                { "2","Sprite","20","100","sprite"},
                                 { "3","Pepsi","30","110","pepsi"},
                                  { "4","Coca-Cola","40","130","cola"} };
            foreach (string key in matrix) { Console.Write(key); }
            Console.WriteLine();
            foreach (string key in ds.Load(Path.Combine("C:", "rez0n11", "Files", "test.csv"))) { Console.Write(key); }
            CollectionAssert.AreEqual(matrix, ds.Load(Path.Combine("C:", "rez0n11", "Files", "test.csv")));
        }
    }
}
