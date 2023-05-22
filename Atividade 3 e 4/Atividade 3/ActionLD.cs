namespace Atividade_3
{
    public static class ActionLD
    {
        //Método que concatena duas listas
        public static ListaDupla Concatenar(ListaDupla l1, ListaDupla l2)
        {
            ListaDupla l12 = new ListaDupla();
            for (int i = 0; i < l1.lenght(); i++)
            {
                l12.addEnd(l1.GetCelula(i).getElemento());
            }
            for (int i = 0; i < l2.lenght(); i++)
            {
                l12.addEnd(l2.GetCelula(i).getElemento());
            }
            return l12;
        }
        //Intercalar duas lista ordenadas ATENÇÃO SUPOEM VALORES INTEIROS DE CONTEUDO.
        public static ListaDupla ConcatenarOrd(ListaDupla l1, ListaDupla l2)
        {
            ListaDupla l12 = new ListaDupla();
            int j = 0;
            int k = 0;
            int A;
            int B;
            int qtdA = l1.lenght();
            int qtdB = l2.lenght();
            for (int i = 0; i < (l1.lenght() + l2.lenght()); i++)
            {
                if (qtdA != 0 || qtdB != 0)
                {
                    if (qtdA != 0 && qtdB != 0)
                    {
                        A = (int)l1.GetCelula(k).getElemento();
                        B = (int)l2.GetCelula(j).getElemento();
                        if (A >= B)
                        {
                            l12.addEnd(B);
                            j++;
                            qtdB--;
                        }
                        else
                        {
                            l12.addEnd(A);
                            k++;
                            qtdA--;
                        }
                    }
                    else if (qtdA == 0 && qtdB != 0)
                    {
                        B = (int)l2.GetCelula(j).getElemento();
                        l12.addEnd(B);

                    }
                    else if (qtdB == 0 && qtdA != 0)
                    {
                        A = (int)l1.GetCelula(k).getElemento();
                        l12.addEnd(A);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return l12;
        }
    }
}