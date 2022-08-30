using System;

namespace Core
{
    public interface IGameCore
    {
        public interface IEngine { };
        public interface IDamageEngine { };
        public interface IMovementEngine {};
        public interface IFactory {};
    }
}
