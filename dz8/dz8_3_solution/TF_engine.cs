using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dz8_3_solution
{
    public class TF_engine
    {
        private string filename;
        private List<Voprosy> list; // создаем колекцию

        // ///////////////////////////////// хочу написать индексное свойство /////
        // Индексное свойство через которое я могу обращаться к колекции и возвращать по индексу вопрос
        public Voprosy this[int index2]
        { get { return list[index2]; } }

        // хочу получать количество элементов в колекции
        public int Count
        {
            get { return list.Count; }
        }
        // ///////////////////////////////// хочу написать индексное свойство /////


        /////////////////созданим конструктор класс
        public TF_engine(string filename_cach) // передадим некий чтото
        {
            this.filename = filename_cach; // сохраним в переменную объясвленую до 
            // обратимся к нашей колекции и создадим новый экземпляр
            list = new List<Voprosy>();
        }

        public string FileName
        {
            set => filename = value; // для save as
        }
        public void Add1(string text2, bool truefalse2) // создаем метод добавить 
        {
            list.Add(new Voprosy(text2, truefalse2)); // передаем вопрос и ответ на него
        }

        public void Remove1(int index) // создаем метод удалить 
        {
            if (index >= 0 && index < list.Count) list.RemoveAt(index);
            // RemoveAt этот метод удалит элемент по индексу в нашем случае индекс пременная

        }
        ////////////////////////// ранее мы писали методы сюреализации и десюриализации // перенесу их сюда
        ///

        public void Load() // значения пусты так как буду получать фаил
        {
            // в typeof передаем нашу колекцию
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Voprosy>));
            using (var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read)) // filename чувтвителен к регистру
            {
                list = (List<Voprosy>)xmlSerializer.Deserialize(fileStream);
            }
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Voprosy>));
            using (var fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, list);
            }
        }
    }

    
}

