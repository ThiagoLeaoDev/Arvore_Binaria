using System;

namespace TP_Arvore_Binaria
{
    class ArvoreBinaria
    {
        public ArvoreBinaria()
        {
            info = 0;
            sae = sad = null;
        }
        public void Insere(int n, ref ArvoreBinaria RAIZ, ref ArvoreBinaria aux)
        {
            this.info = n;
            if (RAIZ == null)
                RAIZ = this;

            else
            {
                aux = RAIZ;
                do
                {
                    if (n <= aux.info)
                    {
                        if(aux.sae == null)
                        {
                            aux.sae = this;
                        }
                        else
                        {
                            aux = aux.sae;
                        } 
                    }

                    else
                    {
                        if (aux.sad == null)
                        {
                            aux.sad = this;
                        }
                        else
                        {
                            aux = aux.sad;
                        }
                    }
                } while (aux != this);

            }
        }
        private int info;
        ArvoreBinaria sae;
        ArvoreBinaria sad;
        public void Consulta(int n, ref ArvoreBinaria RAIZ, ref ArvoreBinaria aux)
        {
            this.info = n;
            aux = RAIZ;
            int finder = 0;

            while (finder == 0)
            {
                if (n < aux.info)
                {
                    if (aux.sae == null)
                    {
                        Console.WriteLine("Número não encontrado");
                        Console.ReadKey();
                        finder = 1;
                    }
                    else
                    {
                        aux = aux.sae;
                    }
                }
                
                if (n > aux.info)
                {
                    if (aux.sad == null)
                    {
                        Console.WriteLine("Número não encontrado");
                        Console.ReadKey();
                        finder = 1;
                    }
                    else
                    {
                        aux = aux.sad;
                    }
                }

                if (n == aux.info)
                {
                    Console.WriteLine("Número encontrado");
                    Console.ReadKey();
                    finder = 1;
                }
            } 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria RAIZ = null;
            ArvoreBinaria ab, aux;
            int n, escolha;

            do
            {
                Console.Clear();
                Console.WriteLine(" Menu Principal");
                Console.WriteLine("(1) - Insere um elemento na Árvore Binária");
                Console.WriteLine("(2) - Consulta um elemento da Árvore Binária");
                Console.WriteLine("(3) - Para SAIR");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1: // Insere um elemento na Arvore Binaria
                        Console.Clear();
                        ab = new ArvoreBinaria();
                        aux = new ArvoreBinaria();
                        Console.Write("Entre com um numero : ");
                        n = int.Parse(Console.ReadLine());
                        ab.Insere(n, ref RAIZ, ref aux);
                        break;

                    case 2: // Consulta um elemento na Arvore Binaria
                        Console.Clear();
                        ab = new ArvoreBinaria();
                        aux = new ArvoreBinaria();
                        Console.Write("Entre com o numero que deseja consultar: ");
                        n = int.Parse(Console.ReadLine());
                        ab.Consulta(n, ref RAIZ, ref aux);
                        break;

                        //case 2:
                        //    Console.Clear();
                        //    ld = new ListaDupla();
                        //    aux = new ListaDupla();

                        //    Console.Write("Entre com um numero para ser consultado: ");
                        //    n = int.Parse(Console.ReadLine());

                        //    ld = START.Consulta(n);
                        //    START.Remove(ref ld, ref aux, ref START, ref END);

                        //    break;

                }
            } while (escolha != 3);
        }
    }
}
