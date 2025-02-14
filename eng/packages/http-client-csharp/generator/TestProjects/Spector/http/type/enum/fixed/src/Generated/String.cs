// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using _Type._Enum.Fixed.Models;

namespace _Type._Enum.Fixed
{
    public partial class String
    {
        protected String() => throw null;

        public HttpPipeline Pipeline => throw null;

        public virtual Response GetKnownValue(RequestContext context) => throw null;

        public virtual Task<Response> GetKnownValueAsync(RequestContext context) => throw null;

        public virtual Response<DaysOfWeekEnum> GetKnownValue(CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response<DaysOfWeekEnum>> GetKnownValueAsync(CancellationToken cancellationToken = default) => throw null;

        public virtual Response PutKnownValue(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> PutKnownValueAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response PutKnownValue(DaysOfWeekEnum body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> PutKnownValueAsync(DaysOfWeekEnum body, CancellationToken cancellationToken = default) => throw null;

        public virtual Response PutUnknownValue(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> PutUnknownValueAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response PutUnknownValue(DaysOfWeekEnum body, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> PutUnknownValueAsync(DaysOfWeekEnum body, CancellationToken cancellationToken = default) => throw null;
    }
}
