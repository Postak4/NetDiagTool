using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDiagTool.Core.Models
{
    /// <summary>
    /// Reprezentuje nastavení pro skenování cílových hostů a portů a obsahuje informace o tom, jakým způsobem
    /// bude scan probíhat. Tato třída slouží jako kontejner pro všechny parametry, které ovlivňují chování skenování.
    /// Drží kompletní nastavení jednoho běhu skenování, včetně seznamu hostů, rozsahu portů, timeoutů a dalších parametrů,
    /// které mohou být použity.
    /// </summary>
    public class ScanOptions
    {
        // Uložení cílových adres pro scanování - jedna, rozsah později i seznam konkrétních hostů
        public List<string> Hosts { get; set; } = new();
        // Režim scanu - Fast, full
        public ScanProfile Profile { get; set; } = ScanProfile.Fast;
        // Je dobré mít explicitní nastavení portů - někdy podle Profilu a někdy konkrétní rozsah
        public int StartPort { get; set; } = 1; 
        public int EndPort { get; set; } = 10000;
        // Timeout pro jednotlivý pokus o spojení 
        public int TimeoutMs { get; set; } = 800;
        // Kolik hostů může běžet paralelně - např.: scan 20 adres, ale najednou jich může zpracovávat jen 10
        public int MaxParrallelHosts { get; set; } = 10;
        // Kolik portových testů může běžet současně - dobré pro výkon a stabilitu
        public int MaxParrallelPorts { get; set; } = 200;
        // Samostatný limit pro service detection
        public int MaxParrallelServiceDetections { get; set; } = 50;
        // Zapíná / vypíná detekci služby - někdy stačí vědět, že port je otevřený, bez nutnosti zjišťovat, co na něm běží
        public bool EnableSeviceDetection { get; set; } = true;
    }
}
