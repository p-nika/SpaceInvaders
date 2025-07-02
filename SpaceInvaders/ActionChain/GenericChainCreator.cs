using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain
{
    internal class GenericChainCreator<T1, T2> where T1 : IChainHandler
    {
        private T1 _currentHandler;
        private T1 _lastHandler;
        private static GenericChainCreator<T1, T2> _instance;
        private GenericChainCreator()
        {

        }

        public static GenericChainCreator<T1, T2> GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GenericChainCreator<T1, T2>();
            }
            return _instance;
        }

        private static T1 GetHandlerObject(T2 handler)
        {
            Type t = Type.GetType($"{typeof(T1).Namespace}.{handler}")!;
            return (T1)Activator.CreateInstance(t)!;
        }

        public GenericChainCreator<T1, T2> CreateHandler(T2 handler)
        {
            _currentHandler = GetHandlerObject(handler);
            _lastHandler = _currentHandler;
            return this;
        }

        public GenericChainCreator<T1, T2> WithHandler(T2 handler)
        {
            T1 newHandler = GetHandlerObject(handler);
            _lastHandler.SetHandler(newHandler);
            _lastHandler = newHandler;
            return this;
        }

        public T1 GetResult()
        {
            return _currentHandler;
        }

    }
}
