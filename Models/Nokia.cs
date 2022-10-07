namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if(Modelo == "Nokia"){

               if(Memoria > 512){
                Console.WriteLine($"{nomeApp} Instalado com Sucesso");
               }
               else Console.WriteLine("memoria insufficiente");
            }
            else Console.WriteLine("Modelo Errado");
        }
    }
}