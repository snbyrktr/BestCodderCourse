using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCodder.Common
{
    internal interface IResult
    {
        bool IsSucces { get; set; }
        string Message { get; set; }
    }
}
