using System;
namespace Twitter.Core.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
