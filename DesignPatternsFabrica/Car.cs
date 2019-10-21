namespace DesignPatternsFabrica
{
    internal class Car : IFactoryProduct
    {
        private Body _body;
        private Engine _engine;
        private Interior _interior;

        public Car(Body body, Engine engine, Interior interior)
        {
            _body = body;
            _engine = engine;
            _interior = interior;
        }
    }
}