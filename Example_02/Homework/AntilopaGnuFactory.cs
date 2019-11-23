namespace Example_02.Homework
{
    public class AntilopaGnuFactory : ICarFactory
    {
        public Car Create()
        {
            return new Car
            {
                Producer = "Лорен-Дитрих",
                Model = "Антилопа-гну",
                EngineModel = "FiatEngine123",
                IsCabriolet = true,
                DoorCount = 4
            };
        }
    }
}