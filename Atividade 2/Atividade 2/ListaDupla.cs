namespace Atividade_2
{
    public class ListaDupla
    {
        Celula first;
        Celula last;
        Celula head;
        int qtdElement = 0;
        public void addBeginning(Object element)
        {
            if (qtdElement == 0)
            {
                Celula nova = new Celula(element);
                first = nova;
                last = nova;
                head.setAnterior(nova);
                head.setProxima(nova);
                nova.setAnterior(head);
                nova.setProxima(head);
                qtdElement++;
            }
            else
            {
                Celula nova = new Celula(first, element);
                first.setAnterior(nova);
                first = nova;
                nova.setAnterior(head);
                head.setAnterior(nova);
                qtdElement++;
            }
        }
        public void addEnd(Object element)
        {
            if (qtdElement == 0)
            {
                addBeginning(element);
            }
            else
            {
                Celula nova = new Celula(element);
                last.setProxima(nova);
                head.setProxima(nova);
                nova.setAnterior(last);
                nova.setProxima(head);
                last = nova;
                qtdElement++;
            }
        }
        public int lenght()
        {
            return qtdElement;
        }
        public Celula GetCelula(int pos)
        {
            if (pos >= 0 && pos <= qtdElement)
            {
                Celula aux = first;
                for (int i = 0; i < pos; i++)
                {
                    aux = aux.getProxima();
                }
                return aux;
            }
            else
            {
                return null;
            }
        }
        public void popBeginning()
        {
            if (qtdElement == 0)
            {
                Console.WriteLine("Celula vazia");
            }
            else
            {
                first = first.getProxima();
                head.setAnterior(first);
                first.setAnterior(head);
                qtdElement--;
            }
        }
        public void popEnd()
        {
            if (qtdElement == 0)
            {
                Console.WriteLine("Celula vazia");
            }
            else
            {
                last = last.getAnterior();
                head.setProxima(last);
                last.setProxima(head);
                qtdElement--;
            }
        }
    }
}