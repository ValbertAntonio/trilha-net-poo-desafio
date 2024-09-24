namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone ()
        {

        }
        
        public Iphone (string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Iphone...\n");
        }
    }
}