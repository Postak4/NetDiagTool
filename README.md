# NetDiagTool

---

## 🇨🇿 Česká verze

### 📌 Popis projektu

NetDiagTool je konzolová aplikace v .NET zaměřená na diagnostiku sítě. Hlavním cílem je skenování TCP portů, detekce služeb a rozšiřitelnost o další síťové nástroje (DNS, ping, traceroute).

---

### 🎯 Hlavní cíle projektu

* TCP port scanning
* Skenování:

  * jednoho hosta
  * více hostů
  * rozsahu IP adres
* Detekce služeb
* Asynchronní zpracování s omezením paralelismu
* Architektura připravená pro budoucí WPF UI
* Přehledná vrstvená struktura solution

---

### 🏗️ Architektura projektu

```
NetDiagTool
├── NetDiagTool.Console
├── NetDiagTool.Core
└── NetDiagTool.Infrastructure
```

**Vysvětlení:**

* **Console** → vstupní bod aplikace (CLI)
* **Core** → modely, rozhraní, business logika
* **Infrastructure** → TCP komunikace, detekce, parsing

---

### 🛠️ Použité technologie

* C#
* .NET 9
* Visual Studio 2022
* async/await
* připravená DI / layered architecture

---

### 🚧 Stav projektu

Projekt je aktuálně ve vývoji. Základní struktura solution a doménové modely jsou připraveny.

---

### 🔮 Plánované funkce

* TCP skenování
* Fast / Full scan profil
* Detekce služeb
* Parsování rozsahu hostů
* Export výsledků
* DNS / ping / traceroute

---

### ▶️ Spuštění

Projekt je zatím ve fázi vývoje. CLI rozhraní bude doplněno s první funkční verzí skeneru.

---

### ⚠️ Poznámka

Tento nástroj je určen pouze pro autorizovanou diagnostiku a analýzu sítí.

---

---

## 🇬🇧 English version

### 📌 Project description

NetDiagTool is a .NET console-based network diagnostics tool focused on TCP port scanning, service detection, and future extensibility (DNS, ping, traceroute).

---

### 🎯 Project goals

* TCP port scanning
* Scanning:

  * single host
  * multiple hosts
  * IP ranges
* Service detection
* Asynchronous processing with concurrency limits
* Architecture prepared for future WPF UI
* Clean layered solution structure

---

### 🏗️ Project architecture

```
NetDiagTool
├── NetDiagTool.Console
├── NetDiagTool.Core
└── NetDiagTool.Infrastructure
```

**Explanation:**

* **Console** → application entry point (CLI)
* **Core** → models, interfaces, business logic
* **Infrastructure** → TCP probing, detection, parsing

---

### 🛠️ Technologies used

* C#
* .NET 9
* Visual Studio 2022
* async/await
* dependency-ready layered architecture

---

### 🚧 Project status

The project is currently under active development. Initial domain models and solution structure are prepared.

---

### 🔮 Planned features

* TCP scanning
* Fast / Full scan profiles
* Service detection
* Host range parsing
* Export results
* DNS / ping / traceroute

---

### ▶️ Run

The project is currently in development. CLI usage will be added with the first functional scanner version.

---

### ⚠️ Disclaimer

This tool is intended for authorized diagnostics and internal network analysis only.
