namespace DesignPatternsFabrica
{
    internal class BMWEngineFactory : EngineFactory
    {
        public BMWEngineFactory()
        {
            TypeGenerator = () => new Engine {EngineSpeed = 4000};
        }
    }
}