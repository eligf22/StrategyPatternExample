using System;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializationContext serializationContext;
            //Method of serialization selected is XML
            serializationContext = new SerializationContext(new XML());
            serializationContext.Serialize();

            //Method of serialization selected is JSON
            serializationContext = new SerializationContext(new JSON());
            serializationContext.Serialize();
        }

    }
    class SerializationContext
    {
        private StrategyOfSerialization _strategyOfSerialization;

        public SerializationContext(StrategyOfSerialization strategyOfSerialization)
        {
            _strategyOfSerialization = strategyOfSerialization;
        }

        public void Serialize()
        {
            _strategyOfSerialization.Serialize();
        }

    }

    abstract class StrategyOfSerialization
    {
        public abstract void Serialize();
    }

    class XML : StrategyOfSerialization
    {
        public override void Serialize()
        {
            Console.WriteLine("Method of serialization is:" + GetType().Name);
        }
    }
    class JSON : StrategyOfSerialization
    {
        public override void Serialize()
        {
            Console.WriteLine("Method of serialization is:" + GetType().Name);
        }
    }

}
