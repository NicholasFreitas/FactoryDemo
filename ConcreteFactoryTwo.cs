namespace FactoryDemo
{
    class ConcreteFactoryTwo : IFactory
    {
        public IProduct Create()
        {
            return new ProductTwo();
        }
    }
}
