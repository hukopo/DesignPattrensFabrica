using System.Drawing;

namespace DesignPatternsFabrica
{
    internal class BMWInteriorFactory : InteriorFactory
    {
        public BMWInteriorFactory()
        {
            TypeGenerator = () => new Interior {Color = Color.Aqua};
        }
    }
}