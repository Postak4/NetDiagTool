
Název projektu:
        
# NetDiagTool

Krátký popis:
    NetDiagTool is a .NET console-based network diagnostics tool focused on TCP port scanning, service detection, and future extensibility for DNS, ping, and traceroute.

Hlavní cíle projektu:
    TCP port scanning
    scanning single host / multiple hosts / IP range
    service detection
    async processing with concurrency limits
    architecture prepared for future WPF UI
    Architektura solution


    NetDiagTool
    ├── NetDiagTool.Console
    ├── NetDiagTool.Core
    └── NetDiagTool.Infrastructure

Vysvětlení projektu:
    Console = entry point / CLI
    Core = models, interfaces, business logic
    Infrastructure = TCP probing, detection, parsing

Použité technologie:
    C#
    .NET 9
    Visual Studio 2022
    async/await
    dependency-ready layered structure

Stav projektu:

    Project is currently under active development. Initial domain models and solution structure are prepared.

Plánované funkce:
    TCP scan
    Fast / Full profile
    Service detection
    Host range parsing
    Export results
    DNS / ping / traceroute
    Spuštění

Stručně:

    Work in progress. CLI usage will be added as the first functional scanner version is completed.

Poznámka k použití:

    This tool is intended for authorized diagnostics and internal network analysis only.
