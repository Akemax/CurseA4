using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpSystem
{
    [Serializable]
    public enum RuleWork
    {
        No,
        Signifi,
        Unsignify
    }

    [Serializable]
    public enum Rightly
    {
        Unknown = 1,
        Yes,
        No
    }

    [Serializable]
    public enum VarType
    {
        Deducted,
        Queried,
        DeductionQueried
    }
}
