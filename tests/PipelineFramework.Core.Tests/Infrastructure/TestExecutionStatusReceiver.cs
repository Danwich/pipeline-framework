﻿using PipelineFramework.Abstractions;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace PipelineFramework.Core.Tests.Infrastructure
{
    [ExcludeFromCodeCoverage]
    public class TestExecutionStatusReceiver : IAsyncPipelineComponentExecutionStatusReceiver, IPipelineComponentExecutionStatusReceiver
    {
        public Task ReceiveExecutionStartingAsync(PipelineComponentExecutionStartedInfo executionInfo)
        {
            throw new System.NotImplementedException();
        }

        public Task ReceiveExecutionCompletedAsync(PipelineComponentExecutionCompletedInfo executionInfo)
        {
            throw new System.NotImplementedException();
        }

        public void ReceiveExecutionStarting(PipelineComponentExecutionStartedInfo executionInfo)
        {
            throw new System.NotImplementedException();
        }

        public void ReceiveExecutionCompleted(PipelineComponentExecutionCompletedInfo executionInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}