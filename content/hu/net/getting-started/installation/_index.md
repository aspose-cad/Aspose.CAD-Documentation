---
title: Telepítés
type: docs
weight: 30
url: /hu/net/getting-started/installation/
---

## **Aspose.CAD telepítése .NET alatt NuGet segítségével**

A NuGet a legegyszerűbb módja az Aspose API-k letöltésének és telepítésének .NET alatt. Nyissa meg a Microsoft Visual Studio-t és a NuGet csomagkezelőt. Keresse meg az "aspose" kifejezést az áhított Aspose API megtalálásához. Kattintson az "Install" gombra, a kiválasztott API letöltődik és hivatkozik a projektjében.

![todo:image_alt_text](/_assets/install/installation_1.png)

## **Aspose.CAD hivatkozása .NET projektből**

Kérjük, kövesse az alábbi lépéseket (feltételezve, hogy Microsoft Visual Studio-t használ):

1. A **Solution Explorer**-ben bontsa ki azt a projektcsomópontot, amelyhez hivatkozást szeretne hozzáadni.
1. Kattintson a jobb egérgombbal a projekt **References** csomópontjára, és válassza az **Add Reference** lehetőséget a gyorsmenüből.
1. Az **Add Reference** párbeszédpanelen keressen a DLL fájl helyére.
1. Válassza ki az *Aspose.CAD* DLL fájlt, majd kattintson az **OK** gombra.
1. Az *Aspose.CAD* hivatkozás megjelenik a projekt **References** csomópontja alatt.

![todo:image_alt_text](/_assets/install/installation_2.png)

### **Aspose.CAD telepítése vagy frissítése a Csomagkezelő Konzolon keresztül**

Az alábbi lépéseket követheti a [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) hivatkozásához a csomagkezelő konzolon keresztül:

1. Nyissa meg a megoldását/projektjét a Visual Studio-ban.
1. Válassza a Menü -> Eszközök -> Könyvtárcsomag-kezelő -> Csomagkezelő Konzol lehetőséget a csomagkezelő konzol megnyitásához.

![todo:image_alt_text](/_assets/install/installation_3.png)

Írja be a parancsot: “**Install-Package Aspose.CAD**” és nyomja meg az Enter billentyűt a legfrissebb teljes verzió telepítéséhez az alkalmazásába. Alternatív módon hozzáadhatja a "**-prerelease**" utótagot a parancshoz, hogy megadja, hogy a legfrissebb hiba javítást is telepíteni kell.

![todo:image_alt_text](/_assets/install/installation_4.png)

Látni fogja, hogy a "Downloading Aspose.CAD..." üzenet megjelenik az ablak bal alsó részén, jelezve, hogy a letöltés folyamatban van.

![todo:image_alt_text](/_assets/install/installation_5.png)

A letöltés után az alábbi megerősítő üzeneteket fogja látni. Ha nem ismeri az [Aspose EULA](https://about.aspose.com/legal/eula) feltételeit, akkor érdemes elolvasnia az URL-ben hivatkozott licencet.

![todo:image_alt_text](/_assets/install/installation_6.png)

Most már azt fogja tapasztalni, hogy az Aspose.CAD sikeresen hozzá lett adva és hivatkozva lett az alkalmazásában.

![todo:image_alt_text](/_assets/install/installation_7.png)

A csomagkezelő konzolban a "frissítések megkereséséhez" használhatja a “**Update-Package Aspose.CAD**” parancsot, és nyomja meg az Enter billentyűt a frissítések ellenőrzéséhez és azok telepítéséhez, ha jelen vannak. A legfrissebb verzió frissítéséhez "-prerelease" utótagot is hozzáadhat.

## **Fontos szempontok megosztott szerver környezetben való futtatáskor**

Minden Aspose .NET összetevőt teljes megbízású engedélyezési szinttel ajánlott futtatni. Ennek az az oka, hogy az Aspose .NET összetevők néha hozzáférést igényelnek a rendszerleíró adatbázis beállításaihoz és a fájlokhoz, amelyek nem virtuális könyvtárban találhatók, például betűtípusok olvasásához stb. Továbbá az Aspose.NET összetevők a core .NET rendszerosztályokon alapulnak, amelyek közül néhány szintén teljes megbízású engedélyeket igényel a megfelelő működéshez.

Az internetes szolgáltatók, akik több, különböző cégtől származó alkalmazást hosztolnak, jellemzően közepes biztonsági szintet érvényesítenek. A .NET 2.0 esetében az ilyen biztonsági szint az alábbi korlátozásokat állíthatja fel, amelyek befolyásolhatják az Aspose.CAD helyes működését.

- **RegistryPermission** nem érhető el. Ez azt jelenti, hogy nem férhet hozzá a rendszerleíró adatbázishoz, amely szükséges az telepített betűtípusok felsorolásához a dokumentumok renderelésekor.
- **FileIOPermission** korlátozott. Ez azt jelenti, hogy csak az alkalmazás virtuális könyvtárhierarchiájában található fájlokhoz férhet hozzá. Ez potenciálisan azt jelenti, hogy a betűtípusokat nem lehet olvasni az exportálás során.

A fenti okok miatt ajánlott, hogy az Aspose.CAD teljes megbízású engedélyekkel fusson. Lehet, hogy észreveszi, hogy a könyvtár bizonyos funkciói működnek közepes bizalom mellett különböző feladatok végrehajtásakor, míg mások nem (például renderelés), ami esetleg a GDI+ képfeldolgozási hívásokra vezethető vissza.

## **Rendszerkövetelmények**

### **Operációs rendszerek**

Az Aspose.CAD a .NET-hez támogat bármilyen 32 bites vagy 64 bites operációs rendszert, ahol a .NET vagy Mono keretrendszer telepítve van, beleértve, de nem kizárólag:

- Microsoft Windows asztali (XP, Vista, 7, 8, 10) és szerver operációs rendszerek (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS és mások)
- Mac OS X

### **Keretrendszerek**

Az Aspose.CAD a .NET-hez támogatja:

- .NET Framework verziók 2.0-tól 4.5-ig, beleértve a Client Profile verziókat
- .NET Core
- Mono 2.6.7 vagy újabb

### **Fejlesztési környezetek**

Az Aspose.CAD a .NET-hez használható bármilyen fejlesztési környezetben, amely a .NET platformra irányul, de az alábbi környezetek kifejezetten támogatottak:

- Microsoft Visual Studio 2010 vagy újabb
- MonoDevelop 2.4 és újabb
