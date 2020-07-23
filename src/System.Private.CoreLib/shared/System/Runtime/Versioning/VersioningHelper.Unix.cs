// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Runtime.Versioning
{
    public static partial class VersioningHelper
    {
        private static int GetCurrentProcessId() => Interop.Sys.GetPid();
    }
}