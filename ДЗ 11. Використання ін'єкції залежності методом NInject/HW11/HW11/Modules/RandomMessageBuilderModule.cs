using HW11.Interfaces;
using HW11.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Modules
{
    public class RandomMessageBuilderModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRandomMessageBuilder>().To<RandomMessageBuilder>();
            this.Bind<IDateTimeGenerator>().To<DateTimeGenerator>();
            this.Bind<IGreetingsGenerator>().To<GreetingsGenerator>();
            this.Bind<INamesGenerator>().To<NamesGenerator>();
        }
    }
}
