using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class MultipleUsers
    {
        public Dictionary<string,BankAccInfo> accounts = new Dictionary<string,BankAccInfo>();

        public void DoCommand(IRequirement irequire)
        {
            irequire.Do();
        }
    }
}
