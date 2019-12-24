using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_2
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    class AttributeClass : Attribute
    {
        public AttributeClass() {}
        public AttributeClass(string description)
        {
            Description = description;
        }
        public string Description { get; set; }
    }
}
