using System;

namespace DesignPatternsFabrica
{
    internal abstract class Factory<T> where T : IFactoryProduct
    {
        protected Func<T> TypeGenerator;

        public T Create()
        {
            return TypeGenerator();
        }
    }
}