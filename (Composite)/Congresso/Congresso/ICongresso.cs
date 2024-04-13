using System.Collections.Generic;
using System.Xml.Schema;

namespace Congresso
{
    internal interface ICongresso
    {
        long TotalParticipantes();
        long TotalAssentos();
    }
}