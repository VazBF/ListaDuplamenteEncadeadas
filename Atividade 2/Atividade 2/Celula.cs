namespace Atividade_2
{
    public class Celula
    {
        Celula proxima;
        Celula anterior;
        Object elemento;
        public Celula(Object element)
        {
            elemento = element;
            proxima = null;
            anterior = null;
        }
        public Celula(Celula proxima, object elemento)
        {
            this.proxima = proxima;
            this.anterior = null;
            this.elemento = elemento;
        }
        public void setProxima(Celula prox)
        {
            proxima = prox;
        }
        public void setAnterior(Celula ant)
        {
            anterior = ant;
        }
        public Celula getProxima()
        {
            return proxima;
        }
        public Celula getAnterior()
        {
            return anterior;
        }
        public Object getElemento()
        {
            return elemento;
        }
    }
}