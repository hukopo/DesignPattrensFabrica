namespace DesignPatternsFabrica
{
    internal class FerraryFactory : CarFactory
    {
        public FerraryFactory() : base(new FerraryBodyFactory(), new FerraryEngineFactory(),
            new FerraryInteriorFactory())
        {
        }
    }
}