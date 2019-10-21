namespace DesignPatternsFabrica
{
    internal class BMWBodyFactory : BodyFactory
    {
        public BMWBodyFactory()
        {
            TypeGenerator = () => new Body {Size = (40, 89)};
        }
    }
}