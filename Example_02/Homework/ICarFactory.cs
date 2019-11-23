namespace Example_02.Homework
{
    public interface ICarFactory
    {
        Car Create();
    }

    public class ReindeerHarnessCarFactory : ICarFactory
    {
        public Car Create()
        {
            return new Car
            {
                Producer = "Санта Клаус",
                Model = "Собачья упряжка",
                EngineModel = "Лапки",
                IsCabriolet = true,
                DoorCount = 0
            };
        }
    }
}