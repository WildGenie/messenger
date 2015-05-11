﻿using Messenger.Lib.Infrastructure;
using Microsoft.Practices.Unity;

namespace Messenger.Lib.Services.JsBindings
{
    class JsBindingFactory : IJsBindingFactory
    {
        public JsBindingFactory(IUnityContainer container)
        {
            Ensure.Argument.IsNotNull(container, "container");
            this.container = container;
        }

        private readonly IUnityContainer container;

        public T Resolve<T>() where T : IJsBinding
        {
            return this.container.Resolve<T>();
        }
    }
}