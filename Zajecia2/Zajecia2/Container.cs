namespace Zajecia2
{
    public abstract class Container
    {
        public string SerialNumber { get; }
        public double LoadWeight { get; protected set; }
        public double Height { get; }
        public double OwnWeight { get; }
        public double Depth { get; }
        public double MaxLoadCapacity { get; }

        protected Container(string serialNumber, double height, double ownWeight, double depth, double maxLoadCapacity)
        {
            SerialNumber = serialNumber;
            Height = height;
            OwnWeight = ownWeight;
            Depth = depth;
            MaxLoadCapacity = maxLoadCapacity;
        }

        public abstract void Load(double weight);
        public void Unload() => LoadWeight = 0;
    }

}