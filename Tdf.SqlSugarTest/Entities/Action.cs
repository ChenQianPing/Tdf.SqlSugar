using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdf.SqlSugarTest.Entities
{
    public class Action
    {
        public Guid ActionId { get; set; }
        public string ActionName { get; set; }
        public int ActionValue { get; set; }
    }
}
