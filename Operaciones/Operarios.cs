namespace DigitalersLib.Operaciones
{
    public class Operarios
    {
        protected decimal[] sueldos { get; set; }

        public Operarios()
        {
            sueldos = new decimal[3];
            var sueldoIni = 4300.66m;
            for (int i = 0; i < sueldos.Length; i++)
            {
                if (i > 0)
                {
                    sueldos[i] = sueldoIni * 0.2m + sueldos[i - 1];
                }
                else
                {
                    sueldos[i] = sueldoIni * 0.2m + sueldoIni;
                }
            }
        }
    }
}