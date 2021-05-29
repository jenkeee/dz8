using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace dz8_3_solution
{

    /// <summary>
    /// вопрос
    /// </summary>
    public class Voprosy
    {
        /// <summary>
    /// текст вопроса
    /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// ответ на вопрос исттина/ложь
        /// </summary>
        /// 
       public bool TrueFalse { get; set; }


        public Voprosy() { } // обязательно создаем класс без параметров для .Deserialize
        public Voprosy(string text1, bool trueFalse1) 
        {
            Text = text1;
            TrueFalse = trueFalse1;

        }
    }
}
