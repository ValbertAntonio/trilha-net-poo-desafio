namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia ()
        {

        }
        
        public Nokia (string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Nokia...\n");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}