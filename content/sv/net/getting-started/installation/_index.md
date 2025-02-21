---
title: Installation
type: docs
weight: 30
url: /sv/net/getting-started/installation/
---

## **Installera Aspose.CAD för .NET via NuGet**

NuGet är det enklaste sättet att ladda ner och installera Aspose API:er för .NET. Öppna Microsoft Visual Studio och NuGet-paketförvaltaren. Sök efter "aspose" för att hitta den önskade Aspose API:en. Klicka på "Installera", den valda API:en kommer att laddas ner och refereras i ditt projekt.

![todo:image_alt_text](/_assets/install/installation_1.png)

## **Referens till Aspose.CAD från ett .NET-projekt**

Följ dessa steg (förutsatt att du använder Microsoft Visual Studio):

1. I **Lösningsutforskaren** , expandera projektknoten som du vill lägga till en referens till.
1. Högerklicka på **Referenser**-noden för projektet och välj **Lägg till referens** från snabbmenyn.
1. I dialogrutan **Lägg till referens** letar du upp placeringen av DLL-filen.
1. Välj *Aspose.CAD* DLL-filen och klicka på **OK**-knappen.
1. Referensen *Aspose.CAD* kommer att visas under **Referenser**-noden i ditt projekt.

![todo:image_alt_text](/_assets/install/installation_2.png)

### **Installera eller uppdatera Aspose.CAD med hjälp av paketförvaltarkonsolen**

Du kan följa stegen nedan för att referera till [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) med hjälp av paketförvaltarkonsolen:

1. Öppna din lösning/projekt i Visual Studio.
1. Välj Verktyg -> Paketförvaltare för bibliotek -> Paketförvaltarkonsol från menyn för att öppna paketförvaltarkonsolen.

![todo:image_alt_text](/_assets/install/installation_3.png)

Skriv kommandot “**Install-Package Aspose.CAD**” och tryck på enter för att installera den senaste fullständiga versionen i din applikation. Alternativt kan du lägga till suffixet "**-prerelease**" till kommandot för att ange att den senaste versionen inklusive hotfixar också ska installeras.

![todo:image_alt_text](/_assets/install/installation_4.png)

Du kommer att se att meddelandet "Laddar ner Aspose.CAD..." visas längst ner till vänster i fönstret, vilket indikerar att nedladdningen pågår. 

![todo:image_alt_text](/_assets/install/installation_5.png)

När nedladdningen är klar kommer du att se följande bekräftelsemeddelanden. Om du inte är bekant med [Aspose EULA](https://about.aspose.com/legal/eula) kan det vara en bra idé att läsa licensen som refereras i URL:en.

![todo:image_alt_text](/_assets/install/installation_6.png)

Du bör nu upptäcka att Aspose.CAD har lagts till och refererats i din applikation.

![todo:image_alt_text](/_assets/install/installation_7.png)

I paketförvaltarkonsolen kan du också använda kommandot “**Update-Package Aspose.CAD**” och trycka på enter för att kontrollera om det finns några uppdateringar för Aspose.CAD-paketet och installera dem om de finns. Du kan också lägga till suffixet "-prerelease" för att uppdatera den senaste versionen.

## **Överväganden när du kör på en delad servermiljö**

Alla Aspose .NET-komponenter rekommenderas att köras med Full Trust-behörighetsinställningar. Detta beror på att Aspose .NET-komponenter ibland behöver få tillgång till registerinställningar och filer som finns på andra platser än den virtuella katalogen, t.ex. för att läsa typsnitt osv. Dessutom är Aspose.NET-komponenterna baserade på kärnklasser i .NET-systemet, varav vissa också kräver Full Trust-behörighet för att köra i vissa fall.

Internetleverantörer som hostar flera applikationer från olika företag tillämpar oftast Medium Trust-säkerhetsnivåer. I fallet med .NET 2.0 kan en sådan säkerhetsnivå ställa in följande begränsningar som kan påverka Aspose.CAD:s förmåga att fungera korrekt.

- **RegistryPermission** är inte tillgänglig. Detta innebär att du inte kan få tillgång till registret, vilket krävs för att uppräkna installerade typsnitt när du renderar dokument.
- **FileIOPermission** är begränsad. Detta innebär att du endast kan få tillgång till filer i din applikations virtuella kataloghierarki. Detta innebär potentiellt att typsnitt inte kan läsas under exporten.

Av de skäl som anges ovan rekommenderas det att Aspose.CAD körs med Full Trust-behörigheter. Du kan upptäcka att vissa funktioner i biblioteket fungerar när du utför olika uppgifter i Medium Trust medan vissa inte gör det (rendering till exempel) vilket kan bero på anrop till GDI+- bildbehandling.

## **Systemkrav**

### **Operativsystem**

Aspose.CAD för .NET stöder alla 32-bitars eller 64-bitars operativsystem där .NET- eller Mono-ramverket är installerat, inklusive men inte begränsat till:

- Microsoft Windows-skrivbord (XP, Vista, 7, 8, 10) och serveroperativsystem (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS och andra)
- Mac OS X

### **Ramverk**

Aspose.CAD för .NET stöder:

- .NET Framework-versioner från 2.0 till 4.5 inklusive Client Profile-versioner
- .NET Core
- Mono 2.6.7 eller senare

### **Utvecklingsmiljöer**

Du kan använda Aspose.CAD för .NET för att utveckla applikationer i vilken utvecklingsmiljö som helst som riktar sig mot .NET-plattformen, men följande miljöer stöds uttryckligen:

- Microsoft Visual Studio 2010 eller högre
- MonoDevelop 2.4 och senare
