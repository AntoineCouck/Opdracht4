using System;
using System.Collections.Generic;
using static Oef1.Form1;

namespace Oef1
{
    internal class Rij<T>
    {
        private List<T> rij = new List<T>();
        private List<T> rijCopy = new List<T>();
        private static int counter;
        public event Tonen tonen;

     

        public void InDeRij(T element)
        {
            rij.Add(element);
            WhenShow(element);


        }

        public void UitDeRij()
        {
            
            WhenShow(rij[0]);

            rij.Remove(rij[0]);

          

        }

        public void Toon()
        {
            counter++;
            WhenShow(rij[counter - 1]);
            
        }

        public void RijLeegMaken()
        {
            rij.Clear();
        }
        public override string ToString()
        {
            string lijst = "";

            foreach (T t in rij)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public bool CheckIfEmpty()
        {
            if (rij.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<T> lijstCopy()
        {
            rijCopy = rij.GetRange(0, rij.Count);

            return rijCopy;

        }

        public void  ZetAchteraan()
        {
            if (rij.Count <= 0)
            {
                throw new Exception();
            }

            T element = rij[counter - 1];
            rij.RemoveAt(counter - 1);
            rij.Add(element);
            counter--;

            WhenShow(element);
        }


        public void WhenShow(object rij)
        {


            if (tonen != null)
            {
                tonen(rij);

            }

        }

    }
}
