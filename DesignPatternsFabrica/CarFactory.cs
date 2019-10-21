namespace DesignPatternsFabrica
{
    internal abstract class CarFactory : Factory<Car>
    {
        public CarFactory(BodyFactory bodyFactory, EngineFactory engineFactory, InteriorFactory interiorFactory)
        {
            BodyFactory = bodyFactory;
            EngineFactory = engineFactory;
            InteriorFactory = interiorFactory;
            TypeGenerator = () =>
            {
                var body = BodyFactory.Create();
                var engine = EngineFactory.Create();
                var interior = InteriorFactory.Create();
                return new Car(body, engine, interior);
            };
        }

        protected BodyFactory BodyFactory { get; set; }
        protected EngineFactory EngineFactory { get; set; }
        protected InteriorFactory InteriorFactory { get; set; }
    }
}