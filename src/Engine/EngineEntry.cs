using Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class EngineEntry : IEngine
    {
        public delegate void GameAction();
        public static ConcurrentQueue<GameAction> GetQueue = new ConcurrentQueue<GameAction>();  
        public void Add()
        {
        }
        public void DeQueueAndResolve()
        {           
        }
        public void UpdateGameDisplay()
        {            
        }
        public void ClearGameEngine()
        {            
        }
    }
}