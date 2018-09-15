using System;
using System.Collections.Generic;
using System.Text;

namespace Orientation
{
    class Department
    {
        public string _name { get; private set; }
        public string _type { get; private set; }
        public string _supervisor { get; private set; }
        public int _employeeCount { get; private set; }
        public bool _profitable { get; private set; }

        public Department(string name, string type, string supervisor, int employeeCount, bool profitable)
        {
            _name = name;
            _type = type;
            _supervisor = supervisor;
            _employeeCount = employeeCount;
            _profitable = profitable;
        }
    }
}
