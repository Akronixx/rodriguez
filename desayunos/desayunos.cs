using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desayunos
{
    internal class desayunos
    {

        
        
            public String Nombre { get; set; }
            public Double Precio { get; set; }
            public String Dias { get; set; }

            public override string ToString()
            {
                return $"Desayuno {Nombre}, servido los {Dias} a S/{Precio}.";
            }
            public string[] ListaDias()
            {
                return Dias.Split(';');
            
        }
}
