using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDiagTool.Core.Models
{
    /// <summary>
    /// Výčet(Enum) reprezentující stav síťového portu po operaci skenování nebo sondování.
    /// Udává, zda je port otevřený, zavřený, filtrovaný nebo zda během procesu skenování 
    /// došlo k chybě. Reprezentuje výsledek jednoho testovaného portu.
    /// 
    /// Unknown: Výchozí nebo neurčený stav.
    /// Open: Port je otevřený a přijímá připojení.
    /// Closed: Port neodpověděl, ale na daném portu nic neposlouchá.
    /// Timeout: Port neodpověděl v očekávaném časovém limitu.
    /// Filtered: Port je zablokován firewallem, nebo je jinak nedostupný, není možné určit, zda je otevřený nebo zavřený.
    /// Error: Došlo k chybě - špatný hostname, socket exeption, nečekaná vyjímka atd.
    /// </summary>
    public enum PortStatus
    {
        Unknown = 0,
        Open = 1,
        Closed = 2,
        Timeout = 3,
        Filtered = 4,
        Error = 5
    }
}
