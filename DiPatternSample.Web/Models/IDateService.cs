using System;

namespace DiPatternSample.Web
{
    public interface IDateService
    {
        public DateTime GetDateTime { get;}
    }

    public interface ISingletonDateService : IDateService {}

    public interface IScopedDateService : IDateService {}

    public interface ITransientDateService : IDateService {}
}