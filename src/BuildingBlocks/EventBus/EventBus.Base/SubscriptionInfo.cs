using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base
{
    public class SubscriptionInfo
    {
        public Type HandleType { get; }

        public SubscriptionInfo(Type handleType)
        {
            HandleType = handleType ?? throw new ArgumentNullException(nameof(handleType));
        }

        public static SubscriptionInfo Typed(Type handleType)
        {
            return new SubscriptionInfo(handleType);
        }

    }
}
