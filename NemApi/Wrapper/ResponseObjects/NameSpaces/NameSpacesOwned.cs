﻿using System.Collections.Generic;

// ReSharper disable once CheckNamespace

namespace NemApi
{
    public class NameSpace
    {
        public string Fqn { get; set; }
        public string Owner { get; set; }
        public long Height { get; set; }
    }

    public class NameSpaceList
    {
        public List<NameSpace> Data { get; set; }
    }
}