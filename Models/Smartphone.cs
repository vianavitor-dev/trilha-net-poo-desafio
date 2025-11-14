namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private string _modelo;
        private string Modelo
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("Modelo do smartphone não pode ser vazio!");
                }

                _modelo = value;
            }
        }

        private string _imei;
        private string Imei
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("IMEI do smartphone não pode ser vazio!");
                }

                _imei = value;
            }
        }

        private int _memoria;
        private int Memoria
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Espaço de memoria invalido!");
                }

                _memoria = value;
            }
        }

        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}