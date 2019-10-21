namespace DesignPatternsFabrica
{
    internal class FerraryEngineFactory : EngineFactory
    {
        public FerraryEngineFactory()
        {
            TypeGenerator = () => new Engine {EngineSpeed = 94000};
        }
    }
}