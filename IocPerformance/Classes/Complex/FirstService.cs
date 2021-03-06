﻿using System.ComponentModel.Composition;
using MEF2Attr = System.Composition;

namespace IocPerformance.Classes.Complex
{
    [IfInjector.ImplementedBy(typeof(FirstService))]
    public interface IFirstService
    {
    }

    [Cauldron.Activator.Component(typeof(IFirstService), Cauldron.Activator.FactoryCreationPolicy.Singleton)]
    [Export(typeof(IFirstService)), PartCreationPolicy(CreationPolicy.Shared)]
    [MEF2Attr.Export(typeof(IFirstService))]
    [IfInjector.Singleton]
    public class FirstService : IFirstService
    {
        [Stiletto.Inject]
        public FirstService()
        {
        }
    }
}
