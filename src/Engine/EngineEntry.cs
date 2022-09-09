using Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class EngineEntry
    {
        public delegate void GameAction();
        public static ConcurrentQueue<GameAction> GameQueue= new ConcurrentQueue<GameAction>();

        public EngineEntry()
        {
        }

        public void Queue(GameAction gameAction)
        {
            GameQueue.Enqueue(gameAction);
        }

        public void DeQueueAndInvoke()
        {
            GameQueue.TryDequeue(out GameAction result);
            result.Invoke();
        }
        
        public void Clear()
        {            
        }
    }
}