using System.Drawing;

namespace DesignPatternsFabrica
{
    internal class FerraryInteriorFactory : InteriorFactory
    {
        public FerraryInteriorFactory()
        {
            TypeGenerator = () => new Interior {Color = Color.Red};
        }
    }
}