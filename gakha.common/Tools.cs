﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace gakha.common
{
    public static class Tools
    {
        private static IConverter _conv;
        public static IConverter Converter { get { return _conv; } }
        private static ICache _cache;
        public static ICache Cache { get { return _cache; } }


        public void Initialize(IConverter converter, ICache cache)
        {
            _conv = converter;
            _cache = cache;
        }
        public static string FromWylie(string wylie) 
        {
            return _cache.Get(wylie, _conv.FromWylie);
        }  
        public static string ToWylie(string tibetan) 
        {
            return _cache.Get(tibetan, _conv.ToWylie);
        }
    }
}
