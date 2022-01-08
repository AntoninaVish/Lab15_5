using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_5
{
    /*
       метод void setStart(int x) - устанавливает начальное значение
       метод int getNext() - возвращает следующее число ряда
       метод void reset() - выполняет сброс к начальному значению
       
    */

    interface ISeries
    {
        void setStart(int x); // принимает аргумент Х и ничего не возвращает
        int getNext(); //должен возвращать следующее число
        void reset(); //делает сброс с начальным значением
    }

    class ArithProgression : ISeries 
    {
        int step;// это шаг
        int startValue;
        int currentValue;
        public int getNext() //метод
        {
            currentValue+=step; // текущее значение (числу) увеличиваем на шаг
            return currentValue; //возвращаем текущее значение (число)
        }
        public void reset()
        {
            currentValue=startValue;// устанавливаем currentValue в startValue
        }

        public void setStart(int x)
        {
            startValue=x;
            currentValue = startValue; //текущее значение равно стартовому значению
        }
        public void setStep(int s) // метод
        {
            step = s; // заносим S
        }
        
    }
    class GeomProgression: ISeries
    {
        int step;// это шаг
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue *= step; // текущее значение (число) умножаем на шаг
            return currentValue;  //возвращаем текущее значение (число)
        }
        public void reset()
        {
            currentValue = startValue;// устанавливаем currentValue в startValue
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;// текущее значение равно стартовому значению
        }
        public void setStep(int s) // метод
        {
            step = s; // заносим S
        }

    }
}
