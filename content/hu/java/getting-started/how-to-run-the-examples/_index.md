---
title: Hogyan futtathatjuk a példákat
type: docs
weight: 70
url: /hu/java/getting-started/how-to-run-the-examples/
---

## **Letöltés a GitHubról**

Minden példa az Aspose.CAD for Java projekthez a [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java) oldalon található. Klónozhatja a tárolót a kedvenc GitHub kliensével, vagy letöltheti a ZIP fájlt [innen](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Húzza ki a ZIP fájl tartalmát egy mappába a számítógépén. Minden példa a **Példák** mappában található.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Ábra: Aspose.CAD Példák Mappa**|

## **Példák importálása az IDE-be**

A projekt Maven építési rendszert használ. Bármely modern IDE könnyedén megnyithatja vagy importálhatja a projektet és annak függőségeit. Az alábbiakban bemutatjuk, hogyan lehet népszerű IDE-ket használni a példák felépítéséhez és futtatásához.

### **IntelliJ IDEA**

Kattintson a **Fájl** menüre és válassza az **Megnyitás** lehetőséget. Keresse meg a projekt mappáját és válassza a **pom.xml** fájlt.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Ábra: Fájl vagy Mappa Kiválasztása az Importáláshoz**|
A projekt megnyílik és automatikusan letölti a függőségeket. A Projekt fülből böngésszen a példák között a **src/main/java** mappában. A példa futtatásához egyszerűen kattintson a jobb gombbal a fájlra és válassza a "Futtatás .." lehetőséget, a példa végrehajtódik és az eredmény megjelenik a beépített konzol kimeneti ablakban.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Ábra: Példa Futtatása**|

### **Eclipse**

Kattintson a **Fájl** menüre és válassza az **Importálás** lehetőséget. Válassza a **Maven** - Meglévő Maven Projektek lehetőséget.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Ábra: Importálás**|
Keresse meg azt a mappát, amelyet klónozott vagy letöltött a GitHub-ról, és válassza a **pom.xml** fájlt. A projekt megnyílik és automatikusan letölti a függőségeket. A Csomagkezelő fülben böngésszen a példák között a **src/main/java** mappában. Egy példa futtatásához egyszerűen kattintson a jobb gombbal a fájlra és válassza a **Futtatás mint** - **Java Alkalmazás** lehetőséget, a példa végrehajtódik és az eredmény megjelenik a beépített konzol kimeneti ablakban.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Ábra: Példa Futtatása**|

### **NetBeans**

Kattintson a **Fájl** menüre és válassza az **Projekt Megnyitása** lehetőséget. Keresse meg azt a mappát, amelyet klónozott vagy letöltött a GitHub-ról. A **Példák** mappa ikonja megmutatja, hogy ez egy Maven projekt. Válassza a Példák mappát és nyissa meg.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Ábra: Projekt Megnyitása**|
A projekt megnyílik és automatikusan letölti a függőségeket. A Projektek fülben böngésszen a példák között a **forrás csomagok** mappában. A példa futtatásához egyszerűen kattintson a jobb gombbal a fájlra és válassza a **Fájl Futtatása** lehetőséget, a példa végrehajtódik és az eredmény megjelenik a beépített konzol kimeneti ablakban.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Ábra: Példa Futtatása**|

## **Aspose.CAD Könyvtár Hozzáadása a Maven Helyi Tárhoz**

Amikor importálja az **Aspose.CAD Példák** projektet az IDE-be, a Maven automatikusan letölti az aspose.cad JAR fájlt az [Aspose Maven Tárból](https://releases.aspose.com/java/repo/). Ha nincs internet hozzáférése, manuálisan is hozzáadhatja a JAR-t a helyi tárhoz.

### **mvn install**

Töltse le az [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), bontsa ki és másolja az aspose.cad-verzió.jar fájlt máshova, például a C: meghajtóra. Adja ki a következő parancsot:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Most az **aspose.cad** JAR átmásolódik a Maven helyi tárába.

### **pom.xml**

A telepítés után egyszerűen deklarálja az **aspose.cad** koordinátát a pom.xml fájlban.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Kész**

Építse meg, most az **aspose.cad** JAR elérhető a Maven helyi tárából.

## **Összeadás**

Ha szeretne hozzáadni vagy javítani egy példát, bátorítjuk, hogy járuljon hozzá a projekthez. Minden példa és bemutató projekt ebben a tárolóban nyílt forráskódú, és szabadon felhasználható a saját alkalmazásaiban.

A hozzájáruláshoz klónozhatja a tárolót, szerkesztheti a forráskódot és beküldheti a pull kérést. Áttekintjük a változásokat, és ha hasznosnak találjuk, akkor hozzáadjuk a tárolóhoz.
