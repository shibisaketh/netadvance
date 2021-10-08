using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyOrganisationLibrary.Model
{
    public class Department
    {
        public string Name { get; }

        public long CostCenter { get; }

        public Department(string n, long costCenter)
        {
            Name = n;
            CostCenter = costCenter;
        }
    }
}
