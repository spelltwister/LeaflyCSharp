using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Leafly.Types;

namespace Leafly.Web.Tester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var leaflyApiProxy = new Leafly.Web.Api("9ae3b3efb051cc415840c92fd20ed7bd", "0d90ccdd");
           
            var searchResult = leaflyApiProxy.Strains.Search("blue", "rating", null, 0, 20).Result;
            if (searchResult == null)
            {
                throw new ArgumentException();
            }
        }
    }
}
