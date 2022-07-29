namespace DigitalersLib.Contans
{
    //La diferencia entre el readonly y el const se encuentra en que el readonly se puede instanciar y el const no
    public class Consultas
    {
        //Definimos un const y un readonly
        public const string consulta1 = "Select * from Clientes";
        public readonly string consulta2 = "Select * from Peliculas";
    }
    
    public class consta : Consultas
    {

        public consta()
        {
            //Para poder acceder a una const tiene que en la misma clase o heredada
            var consultaConst = consulta1;
        }
    }
}
