﻿using System;

namespace SampleCodeBase.JustMockExamples
{
    internal class FooInternalStatic
    {
        internal static void DoIt()
        {
            throw new NotImplementedException();
        }

        private static int EchoPrivate(int arg1)
        {
            throw new NotImplementedException();
        }

        public static int Echo(int arg1)
        {
            return EchoPrivate(arg1);
        }
    }
}