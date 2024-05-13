using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarPalabrasyCalculos
{
    public class StringOperations
    {
        // Método para contar la cantidad de caracteres en una cadena
        public int CountCharacters(string input)
        {
            // Verificar si la cadena está vacía
            if (string.IsNullOrEmpty(input))
                return 0;

            // Devolver la longitud de la cadena
            return input.Length;
        }
    }
}
