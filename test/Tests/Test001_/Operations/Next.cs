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
using LockFreeDoublyLinkedLists;

namespace Test.Tests.Test001_.Operations
{
    internal class Next : VoidOperation
    {
        public override object RunOnLinkedList(
            LinkedListExecutionState state)
        {
            LinkedListNode<LinkedListItem> current = state.Current;
            if (current == null || current == state.List.Last)
            {
                current = state.List.Last;
            }
            else
            {
                do
                {
                    current = current.Next;
                } while (current != null && current.Value.Deleted);
            }
            state.Current = current;
            return null;
        }

        public override object RunOnLfdll(
            LfdllExecutionState state)
        {
            ILockFreeDoublyLinkedListNode<ListItemData> current = state.Current;
            if (current == null || current == state.List.Tail)
            {
                current = state.List.Tail;
            }
            else
            {
                current = current.Next;
            }
            state.Current = current;
            return null;
        }

        public Next(ObjectIdGenerator idGenerator) : base(idGenerator)
        {
        }
    }
}
