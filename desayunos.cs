using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desayunos
{
    public class creard
    {
            string[] Desayuno1 = new string[0];
            int posicion = 0;
  
            public void crear()
            {
                    string Respuesta;
                    Console.Write("Ingresa el nombre del desayuno : ");
                    Respuesta = Console.ReadLine();
                    Array.Resize(ref Desayuno1, Desayuno1.Length + 1);
                    Desayuno1[posicion] = Respuesta;
                    posicion=posicion+1;
                    Console.WriteLine("A agregado un desayuno ");
            }
    }
}
