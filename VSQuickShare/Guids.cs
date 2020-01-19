// Guids.cs
// MUST match guids.h
using System;

namespace bhojarajsahu88.VSQuickShare
{
    static class GuidList
    {
        public const string guidVSQuickSharePkgString = "ba2612d7-1432-47e7-b302-825c659cd31a";
        public const string guidVSQuickShareCmdSetString = "158cbbb5-4a47-4eba-ac1b-bebbbde5b079";

        public static readonly Guid guidVSQuickShareCmdSet = new Guid(guidVSQuickShareCmdSetString);
    };
}