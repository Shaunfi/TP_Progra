namespace Backend.Entidades
{
    public class TablasAuxiliares
    {
        private int valor;
        private string display;

        public TablasAuxiliares(int valor, string display)
        {
            this.valor = valor;
            this.display = display;
        }
        public TablasAuxiliares()
        {
           valor = 0;
           display = String.Empty;
        }

        public int Valor { get => valor; set => valor = value; }
        public string Display { get => display; set => display = value; }
    }
}
