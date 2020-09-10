using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class MetrosMilimetros
    {
        public void Conversao()
        {
            double metros;
            double milimetro; 
            Console.Write("Informe os metros: ");
            metros = Convert.ToDouble(Console.ReadLine());
            milimetro = metros * 1000;
            Console.WriteLine("Milimetros: " + milimetro + "\n");

            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
