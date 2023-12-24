using Builder.Builders;

namespace Builder
{
    public class CarDirector
    {
        private ICarBuilder builder;

        public CarDirector(ICarBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.SetModel();
            builder.SetColor();
            builder.SetHorsepower();
            builder.SetSunroof();
            builder.SetFourWheelDrive();
            builder.SetSpoiler();
        }
    }
}
