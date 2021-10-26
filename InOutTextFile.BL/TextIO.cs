using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutTextFile.BL
{
    public class TextIO
    {
        /// <summary>
        /// Метод  сохраняет  текст в  файл  
        /// </summary>
        /// <param name="path">путь  к файлу</param>
        /// <param name="content">содержание файла</param>
        /// <returns></returns>
        public static string WriteTextToTXT(string path, string content)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(content);
                }
                return "Запись выполнена";
            }
            catch (Exception e)
            {
                return "Все плохо " + e.Message;
            }
        }

        /// <summary>
        /// Метод читает  текст  из файла
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns>контент или сообщение  об ошибки</returns>
        public  static string ReadTextInTXT (string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                  return   sr.ReadToEnd();
                }
                            }
            catch (Exception e)
            {
                return "Все плохо " + e.Message;
            }
        }
    }
}
