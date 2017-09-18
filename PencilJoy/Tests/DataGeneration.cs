using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PencilJoy.Pages;

namespace PencilJoy.Tests
{
    class DataGeneration
    {
       
        public Random random { get; set; }

        //generate int decimal from 1 to size
        public int RandomDecimal(int size)
        {
            return random.Next(1, size);
        }
        //generate int from 1 to size
        /*
        public  int RandomInt2(int size)
        {
            Random random = new Random();
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                //Генерируем число от 0 до 9, заполняем им разряд.
                result = (int)((result * 10) + (random.NextDouble() * 9));

                //Целое число не может начинаться с 0, если его разрядность больше 1
                if (size > 1 && result == 0)
                    result++;
            }
            return result;
        }
         */
        public  string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;

            for (int i = 0; i < size; i++)
            {
                //Генерируем число являющееся латинским символом в юникоде
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                //Конструируем строку со случайно сгенерированными символами
                builder.Append(ch);
            }
            return builder.ToString();
        }

    }
}
