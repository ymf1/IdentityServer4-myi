﻿// Copyright (c) Duende Software. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.OidcClient.Browser;

namespace IdentityModel.OidcClient.Tests
{
    public class TestBrowser : IBrowser
    {
        private readonly Func<BrowserOptions, Task<BrowserResult>> _browserResultFactory;

        public TestBrowser(Func<BrowserOptions, Task<BrowserResult>> browserResultFactory)
        {
            _browserResultFactory = browserResultFactory;
        }

        public Task<BrowserResult> InvokeAsync(BrowserOptions options, CancellationToken cancellationToken) => 
            _browserResultFactory(options);
    }
}
