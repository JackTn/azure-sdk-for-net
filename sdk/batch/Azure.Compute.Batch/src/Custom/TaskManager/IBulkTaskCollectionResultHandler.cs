﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// you can use to specify under what conditions an operation to
    /// add multiple tasks to a job should retry, terminate or be considered successful.
    /// </summary>
    /// <remarks>You do not need to specify this behavior explicitly; if you do not, a default behavior
    /// is used.  This behavior uses the <see cref="DefaultTaskCollectionResultHandler"/>
    /// criteria.</remarks>
    public interface IBulkTaskCollectionResultHandler
    {
        /// <summary>
        /// Handles the result of a single AddTask operation.
        /// </summary>
        /// <param name="addTaskResult"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>AddTaskResultStatus status</returns>
        public CreateTaskResultStatus BulkCreateTaskCollectionResultHandler(CreateTaskResult addTaskResult, CancellationToken cancellationToken);
    }
}
