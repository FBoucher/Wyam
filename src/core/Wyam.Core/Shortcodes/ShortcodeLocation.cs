﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wyam.Common.Shortcodes;
using Wyam.Core.Util;

namespace Wyam.Core.Shortcodes
{
    internal class ShortcodeLocation
    {
        public ShortcodeLocation(int firstIndex, string name, KeyValuePair<string, string>[] arguments)
        {
            FirstIndex = firstIndex;
            Name = name;
            Arguments = arguments;
        }

        public void Finish(int lastIndex)
        {
            LastIndex = lastIndex;
        }

        public int FirstIndex { get; }
        public string Name { get; }
        public KeyValuePair<string, string>[] Arguments { get; }

        public string Content { get; set; } = string.Empty;

        public int LastIndex { get; private set; }
    }
}
