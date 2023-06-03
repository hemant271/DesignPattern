namespace Manifestations.Creational
{
    internal class EconmicCar1 : ICar
    {
        public int getTopSpeed()
        {
            return 60;
        }
    }

    internal class EconmicCar2 : ICar
    {
        public int getTopSpeed()
        {
            return 100;
        }
    }

    internal class LuxeryCar1 : ICar
    {
        public int getTopSpeed()
        {
            return 200;
        }
    }

    internal class LuxeryCar2 : ICar
    {
        public int getTopSpeed()
        {
            return 250;
        }
    }
}