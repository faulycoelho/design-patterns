namespace Builder.Builders
{
    public class SportsCarBuilder : ICarBuilder
    {
        private CarConcrete car = new CarConcrete();

        public void SetModel()
        {
            car.Model = "Sports Car";
        }

        public void SetColor()
        {
            car.Color = "Red";
        }

        public void SetHorsepower()
        {
            car.Horsepower = 300;
        }

        public void SetSunroof()
        {
            car.Sunroof = false;
        }

        public void SetFourWheelDrive()
        {
            car.FourWheelDrive = false;
        }

        public void SetSpoiler()
        {
            car.Spoiler = true;
        }

        public CarConcrete Build()
        {
            return car;
        }
    }

}
