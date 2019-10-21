namespace DesignPatternsFabrica
{
    internal class Body : IFactoryProduct
    {
        public (int, int) Size { get; set; }
    }
}