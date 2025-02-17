---
title: Hogyan futtassuk a példákat
type: docs
weight: 70
url: /hu/net/showcases/how-to-run-the-examples/
---

## **Szoftverkövetelmények**

Kérjük, győződjön meg arról, hogy teljesíti a következő követelményeket, mielőtt letöltené és futtatná a példákat.

1. Visual Studio 2010 vagy újabb
1. NuGet csomagkezelő telepítve a Visual Studio-ban. Győződjön meg arról, hogy a legújabb NuGet API verzió telepítve van a Visual Studio-ban. A NuGet csomagkezelő telepítéséről további részletekért kérjük, ellenőrizze a következő oldalt: https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Menjen a Tools->Options->NuGet Package Manager->Package Sources részhez, és győződjön meg arról, hogy a **nuget.org** opció be van jelölve.
1. A példa projekt a NuGet Automatikus Csomaghelyreállítás funkciót használja, ezért aktív internetkapcsolatra van szüksége. Ha azokon a gépeken, ahol a példákat végrehajtják, nincs aktív internetkapcsolat, kérjük, ellenőrizze a [Telepítés](/hu/cad/net/installation/) linket, hogy hozzáadja a hivatkozást az Aspose.CAD.dll fájlra a példa projektben.

## **Letöltés a GitHub-ról**

Az Aspose.CAD minden példája .NET-hez megtalálható a [GitHub-on](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Klónozhatja a tárolót a kedvenc GitHub kliensével, vagy letöltheti a ZIP fájlt [innen](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Csomagolja ki a ZIP fájl tartalmát bármely mappába a számítógépén. Minden példa a **Examples** mappában található.
- Van egy Visual Studio megoldásfájl C#-hoz.
- A projektek Visual Studio 2013-ban készültek, de a megoldásfájlok kompatibilisek a Visual Studio 2010 SP1 és újabb verziójával.
- Nyissa meg a megoldásfájlt a Visual Studio-ban, és építse fel a projektet.
- Az első futtatáskor a függőségek automatikusan letöltődnek a NuGet-en keresztül.
- A **Data** mappa a **Examples** gyökérmappájában tartalmazza azokat a bemeneti fájlokat, amelyeket a CSharp példák használnak. Kötelező letölteni a **Data** mappát a példaprojekt mellett.
- Nyissa meg a RunExamples.cs fájlt, innen hívhatók meg az összes példa.
- Távolítsa el a példák elé helyezett megjegyzéseket, amelyeket szeretne futtatni a projekten belül.

Kérjük, bátran keressen minket a Fórumain, ha bármilyen problémája van a példák beállításával vagy futtatásával kapcsolatban.

## **Hozzájárulás**

Ha szeretné hozzáadni vagy javítani egy példát, ösztönözzük, hogy járuljon hozzá a projekthez. Az összes példa és bemutató projekt ezen a tárolón nyílt forráskódú, és szabadon felhasználható a saját alkalmazásaiban.

A hozzájáruláshoz fork-olhatja a tárolót, szerkesztheti a forrást, és létrehozhat egy pull request-et. Átnézzük a változtatásokat, és ha hasznosnak találjuk, belefoglaljuk a tárolóba.
