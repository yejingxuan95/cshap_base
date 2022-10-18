using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Spectrum spectrum = new Spectrum();
            foreach (var item in spectrum)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

    class Spectrum : IEnumerable
    {
        string[] Colors = { "violet", "blue" };
        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(Colors);
        }
    }
    class ColorEnumerator : IEnumerator
    {
        string[] colors;
        int position = -1;
        public ColorEnumerator(string[] theColors)
        {
            colors = new string[theColors.Length];
            for (int i = 0; i < theColors.Length; i++)
            {
                colors[i] = theColors[i];
            }
        }
        public object Current
        {
            get {
                if (position == -1)
                {
                    throw new InvalidOperationException();
                }
                if (position >= colors.Length)
                {
                    throw new InvalidOperationException();
                }
                return colors[position];
            }
        }

        public bool MoveNext()
        {
            if (position < colors.Length-1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
