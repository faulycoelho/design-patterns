namespace Builder.Builders
{
    public interface ICarBuilder
    {
        void SetModel();
        void SetColor();
        void SetHorsepower();
        void SetSunroof();
        void SetFourWheelDrive();
        void SetSpoiler();
        CarConcrete Build();
    }
}
