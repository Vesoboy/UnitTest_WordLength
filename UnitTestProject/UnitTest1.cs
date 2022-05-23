using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// <summary>
		/// Начало программы, задаем путь файла и длину слова
		/// </summary>
        /// <param way="way">Путь файла.</param>
        /// <param long_line="long_line">Максимальная длина слова.</param>
        public void TestMethod1()
        {
            string way = "C:\\Users\\Ivan\\Desktop\\UnitTestProject\\test.txt";
            int long_line = 8;
            var test = new CountStr_Abc(way);
            Assert.AreEqual(test.CountAbc(), long_line);
        }

    }
}
