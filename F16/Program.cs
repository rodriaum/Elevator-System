using System;

namespace F16
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentFloor = 0;
            bool hasFinished = false;

            while (!hasFinished)
            {
                Console.WriteLine("Deseja ir para algum andar? Insira o andar entre 0 e 20 ou insira 'sair':");
                string requiredFloor = Console.ReadLine();

                if (requiredFloor.Equals("sair"))
                {
                    hasFinished = true;
                    Console.WriteLine("Você saiu do elevador.");
                }
                else
                {
                    int floor = Convert.ToInt32(requiredFloor);

                    if (currentFloor == floor)
                    {
                        Console.WriteLine("Você já está no andar pretendido.");
                    }
                    else
                    {
                        if (floor > 20 || floor < 0)
                        {
                            Console.WriteLine("O andar pretendido não existe. Tente 0 até 20");
                        }
                        else
                        {
                            Console.WriteLine((currentFloor > floor ? "A descer para o andar " : "A subir para o andar ") + floor);

                            currentFloor = floor;

                            Console.WriteLine("Você chegou ao andar do destino. (" + currentFloor + ")");
                        }
                    }
                }
            }
        }
    }
}
