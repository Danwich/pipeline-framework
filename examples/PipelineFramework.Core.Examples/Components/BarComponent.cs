﻿using PipelineFramework.Abstractions;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace PipelineFramework.Core.Examples.Components
{
    [ExcludeFromCodeCoverage]
    public class BarComponent : AsyncPipelineComponentBase<ExamplePipelinePayload>
    {
        public override async Task<ExamplePipelinePayload> ExecuteAsync(ExamplePipelinePayload payload, CancellationToken cancellationToken)
        {
            payload.Result = await Task.Run(() =>
                {
                    //call some external api and get null result back
                    return new Random().Next(100);
                },
                cancellationToken);
            
            payload.Messages.Add($"Component {Name} called external api and returned result {payload.Result}");

            return payload;
        }
    }

    [ExcludeFromCodeCoverage]
    public class BarComponentNonAsync : PipelineComponentBase<ExamplePipelinePayload>
    {
        public override ExamplePipelinePayload Execute(ExamplePipelinePayload payload, CancellationToken cancellationToken)
        {
            payload.Result = new Random().Next(100);

            payload.Messages.Add($"Component {Name} called external api and returned result {payload.Result}");

            return payload;
        }
    }
}
