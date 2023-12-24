namespace Builder.Builders
{
    public class SedanCarBuilder : ICarBuilder
    {
        private CarConcrete car = new CarConcrete();

        public void SetModel()
        {
            car.Model = "Sedan";
        }

        public void SetColor()
        {
            car.Color = "Blue";
        }

        public void SetHorsepower()
        {
            car.Horsepower = 150;
        }

        public void SetSunroof()
        {
            car.Sunroof = true;
        }

        public void SetFourWheelDrive()
        {
            car.FourWheelDrive = false;
        }

        public void SetSpoiler()
        {
            car.Spoiler = false;
        }

        public CarConcrete Build()
        {
            return car;
        }
    }
}
