﻿using Helpful.CircuitBreaker.Events;

namespace Helpful.CircuitBreaker
{
    internal static class EventFactoryValidator
    {
        internal static bool Validate(this IEventFactory eventFactory)
        {
            return eventFactory.GetClosedEvent() != null
                   && eventFactory.GetOpenedEvent() != null
                   && eventFactory.GetRegisterBreakerEvent() != null
                   && eventFactory.GetTolleratedOpenEvent() != null
                   && eventFactory.GetTriedToCloseEvent() != null
                   && eventFactory.GetUnregisterBreakerEvent() != null;
        }

    }
}