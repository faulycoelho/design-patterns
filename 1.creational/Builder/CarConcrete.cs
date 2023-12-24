namespace Builder
{
    public class CarConcrete
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public bool Sunroof { get; set; }
        public bool FourWheelDrive { get; set; }
        public bool Spoiler { get; set; }

        public override string ToString()
        {
            return $"Car [Model: {Model}, Color: {Color}, Horsepower: {Horsepower}, Sunroof: {Sunroof}, FourWheelDrive: {FourWheelDrive}, Spoiler: {Spoiler}]";
        }
    }
}
