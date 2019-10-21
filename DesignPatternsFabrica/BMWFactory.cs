namespace DesignPatternsFabrica
{
    internal class BMWFactory : CarFactory
    {
        public BMWFactory() : base(new BMWBodyFactory(), new BMWEngineFactory(), new BMWInteriorFactory())
        {
        }
    }
}