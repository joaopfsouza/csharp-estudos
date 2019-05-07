namespace ExemploSemInterface.Domain

{
    class Vehicle
    {
        public string Modelo { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string modelo)
        {
            Modelo = modelo;
        }
    }
}
