using System;

namespace Robo2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------VARIAVEIS DE USO DO PROGRAMA
            string[] mapa = new string[2];
            string comandorobo1, comandorobo2, robo2Dire, robo1Dire;
            int robo1x, robo1y, robo2x, robo2y;
            String[] separarXYZ;
            //-----------------------------------------PEGANDO OS DADOS DO MAPA
            Console.WriteLine("Informe as coordenadas do mapa: Ex(4 4)");
            mapa = Console.ReadLine().ToLower().Split();
            //-----------------------------------------PEGANDO DADOS DO ROBO 1
            Console.WriteLine("Informe a coordenada do robo 1: Ex(2 2 L)");
            separarXYZ = Console.ReadLine().Split();
            robo1x = Convert.ToInt32((String)separarXYZ[0]);
            robo1y = Convert.ToInt32((String)separarXYZ[1]);
            robo1Dire = (String)separarXYZ [2];
            Console.WriteLine("Informe o Comando do Robo: Ex(MMEDDM)");
            comandorobo1 = Console.ReadLine().ToLower();
            //-----------------------------------------PEGANDO DADOS DO ROBO 2
            Console.WriteLine("Informe a coordenada do robo 2: Ex(2 2 L)");
            separarXYZ = Console.ReadLine().Split();
            robo2x = Convert.ToInt32((String)separarXYZ[0]);
            robo2y = Convert.ToInt32((String)separarXYZ[1]);
            robo2Dire = (String)separarXYZ[2];
            Console.WriteLine("Informe o Comando do Robo: Ex(MMEDDM)");
            comandorobo2 = Console.ReadLine().ToLower();
            //-----------------------------------------SEGUINDO OS COMANDOS DO ROBO 1
            for (int i = 0; i < comandorobo1.Length; i++)
            {
                if (comandorobo1[i] == 'd')
                {
                    if (robo1Dire == "s") robo1Dire = "o";
                    else if (robo1Dire == "n") robo1Dire = "l";
                    else if (robo1Dire == "l") robo1Dire = "s";
                    else if (robo1Dire == "o") robo1Dire = "n";
                }
                else if (comandorobo1[i] == 'e')
                {
                    if (robo1Dire == "s") robo1Dire = "l";
                    else if (robo1Dire == "n") robo1Dire = "o";
                    else if (robo1Dire == "l") robo1Dire = "n";
                    else if (robo1Dire == "o") robo1Dire = "s";
                }
                else if (comandorobo1[i] == 'm')
                {
                    if (robo1Dire == "s") robo1y--;
                    else if (robo1Dire == "n") robo1y++;
                    else if (robo1Dire == "l") robo1x++;
                    else if (robo1Dire == "o") robo1x--;
                }
            }
            //-----------------------------------------SEGUINDO OS COMANDOS DO ROBO 2
            for (int i = 0; i < comandorobo2.Length; i++)
            {
                if (comandorobo2[i] == 'd')
                {
                    if (robo2Dire == "s") robo2Dire = "o";
                    else if (robo2Dire == "n") robo2Dire = "l";
                    else if (robo2Dire == "l") robo2Dire = "s";
                    else if (robo2Dire == "o") robo2Dire = "n";
                }
                else if (comandorobo2[i] == 'e')
                {
                    if (robo2Dire == "s") robo2Dire = "l";
                    else if (robo2Dire == "n") robo2Dire = "o";
                    else if (robo2Dire == "l") robo2Dire = "n";
                    else if (robo2Dire == "o") robo2Dire = "s";
                }
                else if (comandorobo2[i] == 'm')
                {
                    if (robo2Dire == "s") robo2y--;
                    else if (robo2Dire == "n") robo2y++;
                    else if (robo2Dire == "l") robo2x++;
                    else if (robo2Dire == "o") robo2x--;
                }
            }
            //-----------------------------------------SAIDA DE DADOS DO SISTEMA
            Console.WriteLine($"{robo1x} {robo1y} {robo1Dire}");
            Console.WriteLine($"{robo2x} {robo2y} {robo2Dire}");
        }
    }
}