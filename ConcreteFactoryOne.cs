namespace FactoryDemo
{
    class ConcreteFactoryOne : IFactory
    {
        public IProduct Create()
        {
            return new ProductOne();
        }
    }
}
