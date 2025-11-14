namespace DesafioPOO.Models
{
    public sealed class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {   
            Console.WriteLine($"Nokia: Instalando {nomeApp}...");
        }
    }
}