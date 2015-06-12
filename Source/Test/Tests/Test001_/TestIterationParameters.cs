﻿//Copyright 2014 Christoph Müller

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//   http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Tests.Test001_
{
    class TestIterationParameters
    {
        public List<ExecutionSequenceParameters> OperationSequences
        { get; set; }

        public int InitialListLength { get; set; }
        public int InitializationSeed { get; set; }
        public int ExecutionSeed { get; set; }
    }

    class ExecutionSequenceParameters
    {
        public List<IOperationResultComparer> Operations { get; set; }
        public int StartIndex { get; set; }
    }
}