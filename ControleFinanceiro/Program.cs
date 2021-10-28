using System;

namespace ControleFinanceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            float saldoant = 0;
            float saldo = 0;
            string[] desc = new string[50];
            string[] tipo = new string[50];  //p=>pagamento e r=>recebimento
            float[] valor = new float[50];
            int opc;
            int i = 0;
            do
            {
                opc = menu();
                switch (opc)
                {
                    case 1:
                        pagamento(ref saldo,tipo, desc, valor, ref i);
                        break;
                    case 2:
                        recebimento(ref saldo, ref tipo, ref desc, ref valor, ref i);
                        break;
                    case 3:
                        saldoI(ref saldoant, ref saldo);
                        break;
                    case 4:
                        extrato(tipo, valor, desc, i,saldo);
                        break;
                }
            } while (opc != 0);

            static int menu()
            {
                Console.Clear();
                Console.WriteLine("Console Financeiro\n");
                Console.WriteLine("1 - Pagamento");
                Console.WriteLine("2 - Recebimento");
                Console.WriteLine("3 - Cadastrar Saldo inicial");
                Console.WriteLine("4 - Extrato");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                int r = int.Parse(Console.ReadLine());
                return r;
            }

            static void pagamento(ref float saldo, string[] tipo, string[] desc, float[] valor, ref int i)
            {
                Console.WriteLine($"Saldo atual: {saldo}");
                tipo[i] = "Pagamento";
                Console.WriteLine("Digite o nome do deseija pagar: ");
                desc[i] = Console.ReadLine();
                Console.WriteLine("Digite o valor a ser pago: ");
                valor[i] = float.Parse(Console.ReadLine());
                saldo -= valor[i];
                i++;
                Console.WriteLine($"O saldo remanescente: {saldo}");
                Console.ReadKey();
            }

            static void recebimento(ref float saldo, ref string[] tipo, ref string[] desc, ref float[] valor, ref int i)
            {

                tipo[i] = "Recebimento";
                Console.WriteLine("Digite o nome do que vai receber: ");
                desc[i] = Console.ReadLine();
                Console.WriteLine("Digite o valor a receber: ");
                valor[i] = float.Parse(Console.ReadLine());
                saldo += valor[i];
                i++;
                Console.WriteLine($"Seu saldo atual é de: {saldo}");
                Console.ReadKey();
            }

            static void saldoI(ref float saldoant,ref float saldo)
            {
                Console.WriteLine("Digite o saldo a cadastrar: ");
                saldoant = float.Parse(Console.ReadLine());
                saldo = saldoant;
            }

            static void extrato(string[] tipo, float [] valor, string [] desc, int i, float saldo)
            {
                Console.WriteLine("Extrato");
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine($"Operação {desc[j]} -- do tipo {tipo[j]} -- no valor de {valor[j]}");
                }
                Console.WriteLine(saldo);
                Console.ReadKey();
            }
        }   
            
    }
}
