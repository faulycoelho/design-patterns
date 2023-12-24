namespace Builder.Builders
{
    public class SuvCarBuilder : ICarBuilder
    {
        private CarConcrete car = new CarConcrete();

        public void SetModel()
        {
            car.Model = "SUV";
        }

        public void SetColor()
        {
            car.Color = "Black";
        }

        public void SetHorsepower()
        {
            car.Horsepower = 200;
        }

        public void SetSunroof()
        {
            car.Sunroof = true;
        }

        public void SetFourWheelDrive()
        {
            car.FourWheelDrive = true;
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
