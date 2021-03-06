using Carrot.Messages;

namespace Carrot.Fallback
{
    internal class NoFallbackStrategy : IFallbackStrategy
    {
        internal static readonly IFallbackStrategy Instance = new NoFallbackStrategy();

        private NoFallbackStrategy() { }

        public void Apply(IOutboundChannel channel, ConsumedMessageBase message) { }
    }
}