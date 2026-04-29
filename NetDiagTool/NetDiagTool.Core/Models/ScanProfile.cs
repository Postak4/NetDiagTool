using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDiagTool.Core.Models
{
    /// <summary>
    /// ScanProfile reprezentuje dvě základní úrovně skenování portů: Fast a Full. Fast profil se zaměřuje
    /// na rychlé zjištění otevřených portů od 1 do 10000, zatímco Full skenování zahrnuje všechny porty od 1 do 65535. 
    /// </summary>
    public enum ScanProfile
    {
        Fast = 1,
        Full = 2
    }
}
