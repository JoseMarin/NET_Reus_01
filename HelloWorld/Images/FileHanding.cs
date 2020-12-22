using System;
using System.Collections.Generic;
using System.Text;

namespace Images

{
    class FileHanding
    {
        private const String APELLIDO = "Marín";
        public void Saludar(String a) {
            Console.WriteLine("Hola {0} {1}", a, APELLIDO);
        }
    }
}
