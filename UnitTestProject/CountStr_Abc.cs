using System.IO;
using UnitTestProject;
namespace UnitTestProject
{
    /// <summary>
	/// Класс, который выводит максимальное кол-во букв в слове.
	/// </summary>
    internal class CountStr_Abc
    {
        string way;
        /// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param way="way">Путь файла.</param>
        public CountStr_Abc(string way)
        {
            this.way = way;
        }
        /// <summary>
		/// Метод для вывода максимального числа букв в слове.
		/// </summary>
        /// <param max_str="max_str">Переменная для максимального кол-ва букв в слове.</param>
		/// <returns>Возвращает имя пользователя.</returns>
        public int CountAbc()
        {
            int max_str = 0;
            string[] abc = Line("").Split(',', '.', '!', ':', ':', ' ', '?', '-');

            for (int i = 0; i < abc.Length; i++)
            {
                if (abc[i].Length > max_str)
                {
                    max_str = abc[i].Length;
                }
            }
            return max_str;
        }
        /// <summary>
        /// Метод для записи всего содержимого из .txt файла.
        /// </summary>
        /// <param textLine="text_Line">Переменная для хранения содержимого из .txt файла.</param>
        /// <returns>Возвращает содержимое .txt файла.</returns>
        public string Line(string textLine)
        {
            using (StreamReader text_testLine = new StreamReader(way))
            {
                while (true)
                {
                    string tempLine = text_testLine.ReadLine();
                    if (tempLine == null) break;
                    textLine += tempLine;
                }
            }
            return textLine;
        }
    }
}
