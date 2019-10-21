namespace DesignPatternsFabrica
{
    internal class FerraryBodyFactory : BodyFactory
    {
        public FerraryBodyFactory()
        {
            TypeGenerator = () => new Body {Size = (10, 89)};
        }
    }
}