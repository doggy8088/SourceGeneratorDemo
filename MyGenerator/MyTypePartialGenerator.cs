﻿using Microsoft.CodeAnalysis;
using System;

namespace MyGenerator
{
    [Generator]
    public class MyTypePartialGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            throw new NotImplementedException();
        }
    }
}
