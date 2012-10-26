using Microsoft.Practices.ObjectBuilder2;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.ObjectBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenerator.Infrastructure.Extensions
{
    public class DecoratorBuildStategies : IBuilderStrategy
    {
        private readonly Dictionary<Type, List<Type>> _typeStacks;

        public DecoratorBuildStategies(Dictionary<Type, List<Type>> _typeStacks)
        {
            // TODO: Complete member initialization
            this._typeStacks = _typeStacks;

        }

        public void PostBuildUp(IBuilderContext context)
        {

        }

        public void PostTearDown(IBuilderContext context)
        {

        }

        public void PreBuildUp(IBuilderContext context)
        {
            var key = context.OriginalBuildKey;

            if (!(key.Type.IsInterface & _typeStacks.ContainsKey(key.Type)))
            {
                return;
            }

            if (null != context.GetOverriddenResolver(key.Type))
            {
                return;
            }

            Stack<Type> stack = new Stack<Type>(_typeStacks[key.Type]);

            object value = null;

            stack.ForEach(t => {
                value = context.NewBuildUp(new NamedTypeBuildKey(t, key.Name));
                var overrides = new DependencyOverride(key.Type, value);

                context.AddResolverOverrides(overrides);
            });

            context.Existing = value;
            context.BuildComplete = true;
        }

        public void PreTearDown(IBuilderContext context)
        {

        }
    }
}
