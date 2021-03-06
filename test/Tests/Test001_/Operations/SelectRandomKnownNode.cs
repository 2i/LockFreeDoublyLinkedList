﻿#region license
// Copyright 2016 Christoph Müller
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Tests.Test001_.Operations
{
	internal class SelectRandomKnownNode : VoidOperation
    {
	    public override object RunOnLinkedList(LinkedListExecutionState state)
        {
            return run(state);
        }

	    public override object RunOnLfdll(LfdllExecutionState state)
        {
            return run(state);
        }

	    public override string ToString()
        {
            return base.ToString() + ", seed: " + seed;
        }

	    public SelectRandomKnownNode(
            ObjectIdGenerator idGenerator, int seed)
            : base(idGenerator)
        {
            this.seed = seed;
        }

	    #region private
	    private readonly int seed;

	    private object run<T>(IExecutionState<T> state)
        {
            state.CurrentIndex = new Random(seed)
                .Next(state.KnownNodesCollection.Count);
            return null;
        }
	    #endregion
    }
}
