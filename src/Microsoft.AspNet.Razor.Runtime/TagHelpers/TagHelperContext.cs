// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Razor.Runtime.TagHelpers
{
    /// <summary>
    /// Contains information related to the execution of <see cref="ITagHelper"/>s.
    /// </summary>
    public class TagHelperContext
    {
        /// <summary>
        /// Instantiates a new <see cref="TagHelperContext"/>.
        /// </summary>
        /// <param name="allAttributes">Every attribute associated with the current HTML element.</param>
        /// <param name="getChildContentAsync">A delegate used to execute and retrieve the rendered child content 
        /// asynchronously.</param>
        public TagHelperContext([NotNull] IDictionary<string, object> allAttributes,
                                [NotNull] Func<Task<string>> getChildContentAsync)
        {
            AllAttributes = allAttributes;
            GetChildContentAsync = getChildContentAsync;
        }

        /// <summary>
        /// Every attribute associated with the current HTML element.
        /// </summary>
        public IDictionary<string, object> AllAttributes { get; }

        /// <summary>
        /// A delegate used to execute and retrieve the rendered child content asynchronously.
        /// </summary>
        /// <remarks>
        /// Child content is only executed once. Successive calls to this delegate return a cached result.
        /// </remarks>
        public Func<Task<string>> GetChildContentAsync { get; }
    }
}