using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp=0;
            int op=0;
            float a,b;
            do
            {
                Console.WriteLine("Digite:");
                Console.WriteLine("1-Soma 2-Subtracao 3-Multiplicacao 4-Divisao");
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        Console.WriteLine("Insira o primeiro digito:");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o segundo digito:");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine(somar(a, b));
                    break;
                    case 2:
                        Console.WriteLine("Insira o primeiro digito:");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o segundo digito:");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine(sub(a, b));
                    break;
                    case 3:
                        Console.WriteLine("Insira o primeiro digito:");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o segundo digito:");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine(mult(a, b));
                    break;
                    case 4:
                        Console.WriteLine("Insira o primeiro digito:");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o segundo digito:");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine(div(a, b));
                    break;
                }

                Console.WriteLine("0-Sair  1-Continuar");
                resp = int.Parse(Console.ReadLine());
            }while(resp==1);
        }

        private static float somar(float a, float b)
        {
            float c;
            c = a+b;
            return c;
        }
        private static float sub(float a, float b)
        {
            float c;
            c = a-b;
            return c;
        }
        private static float div(float a, float b)
        {
            float c;
            c = a/b;
            return c;
        }
        private static float mult(float a, float b)
        {
            float c;
            c = a*b;
            return c;
        }
    }
}
