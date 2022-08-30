using System;

namespace Interfaces
{
    public interface IEngine
    {
        void Add();
        void DeQueueAndResolve();
        void UpdateGameDisplay();
        void ClearGameEngine();        
    }
}
