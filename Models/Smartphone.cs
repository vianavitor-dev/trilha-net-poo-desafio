namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Celular que está ligando para o celular atual
        private Smartphone _chamando;
        private Smartphone Chamando { 
            get => _chamando;

            set
            {
                _chamando = value;
            } 
     
        }

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

        public void Ligar(Smartphone smartphone)
        {   
            if (smartphone == null)
            {
                throw new ArgumentNullException($"{nameof(smartphone)} é nulo");
            }

            smartphone.Chamando = new Nokia(numero: "+55 11 10001001", imei: "1111111", modelo: "Modelo 1", memoria: 64);
            Console.WriteLine("Ligando para " + smartphone.Numero + "...");
        }

        public void ReceberLigacao()
        {   
            Console.WriteLine("Recebendo ligação...");

            if (Chamando == null)
            {
                Console.WriteLine("-> Não há ninguem ligando agora");
                return;
            } 

            Console.WriteLine($"-> Em ligação com {Chamando.Numero}");
            Chamando = null;
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}