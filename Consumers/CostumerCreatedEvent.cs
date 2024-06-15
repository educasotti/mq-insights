using System;

namespace MassTransitTutorial.Consumers
{
    public interface CustomerCreatedEvent
    {
        string CustomerId { get; }
        string Name { get; }
        DateTime BirthDate { get; }
        string Type { get; }
        DateTime CreatedAt { get; }
    }
}
