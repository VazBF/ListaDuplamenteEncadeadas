namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDupla l1 = new ListaDupla();
            l1.addEnd(1);
            l1.addEnd(3);
            l1.addEnd(5);
            l1.addEnd(7);
            l1.addEnd(9);

            ListaDupla l2 = new ListaDupla();
            l2.addBeginning(10);
            l2.addBeginning(8);
            l2.addBeginning(6);
            l2.addBeginning(4);
            l2.addBeginning(2);

            Console.WriteLine("--------------------LISTA 1--------------------");
            imprimir(l1);
            Console.WriteLine("\n\n--------------------LISTA 2--------------------");
            imprimir(l2);
            Console.WriteLine("\n\n--------------------LISTA 1 e 2 Concatenadas--------------------");
            ListaDupla l12 = ActionLD.Concatenar(l1, l2);
            imprimir(l12);
            Console.WriteLine("\n\n--------------------LISTA 1 e 2 Concatenadas e Ordenadas--------------------");
            ListaDupla lCO = ActionLD.ConcatenarOrd(l1, l2);
            imprimir(lCO);
        }
        public static void imprimir(ListaDupla l)
        {
            for (int i = 0; i < l.lenght(); i++)
            {
                Console.WriteLine(l.GetCelula(i).getElemento());
            }
        }

    }
}