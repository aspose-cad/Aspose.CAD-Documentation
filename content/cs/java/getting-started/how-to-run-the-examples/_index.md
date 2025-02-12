---
title: Jak spustit příklady
type: docs
weight: 70
url: /cs/java/getting-started/how-to-run-the-examples/
---

## **Stáhněte si z GitHubu**

Všechny příklady Aspose.CAD pro Javu jsou hostovány na [Githubu](https://github.com/aspose-cad/Aspose.CAD-for-Java). Můžete buď klonovat repozitář pomocí vašeho oblíbeného klienta Github nebo stáhnout ZIP soubor odtud: [zde](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Obsah ZIP souboru rozbalte do jakéhokoli složky na vašem počítači. Všechny příklady jsou umístěny ve složce **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Obrázek: Adresář příkladů Aspose.CAD**|

## **Importujte příklady do IDE**

Projekt používá systém sestavení Maven. Jakýkoli moderní IDE může snadno otevřít nebo importovat projekt a jeho závislosti. Ukážeme vám, jak používat populární IDE k sestavení a spuštění příkladů.

### **IntelliJ IDEA**

Klikněte na nabídku **Soubor** a zvolte možnost **Otevřít**. Přejděte do složky s projektem a vyberte soubor **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Obrázek: Vyberte soubor nebo adresář k importování**|

Projekt se otevře a závislosti budou automaticky staženy. V záložce Projekt procházejte příklady ve složce **src/main/java**. Chcete-li spustit příklad, stačí pravým tlačítkem kliknout na soubor a vybrat "Spustit ..", příklad se spustí a výstup se zobrazí v okně konzole.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Obrázek: Spusťte příklad**|

### **Eclipse**

Klikněte na nabídku **Soubor** a zvolte možnost **Import**. Vyberte **Maven** - Stávající projekty Maven.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Obrázek: Importujte**|

Přejděte do složky, kterou jste klonovali nebo stáhli z GitHubu, a vyberte soubor **pom.xml**. Projekt se otevře a závislosti budou automaticky staženy. V záložce Průzkumník balíčků procházejte příklady ve složce **src/main/java**. Chcete-li spustit příklad, stačí pravým tlačítkem kliknout na soubor a vybrat možnost **Spustit jako** - **Java aplikace**, příklad se spustí a výstup se zobrazí v okně konzole.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Obrázek: Spusťte příklad**|

### **NetBeans**

Klikněte na nabídku **Soubor** a zvolte možnost **Otevřít projekt**. Přejděte do složky, kterou jste klonovali nebo stáhli z GitHubu. Ikona složky **Příklady** ukáže, že se jedná o projekt Maven. Vyberte Příklady a otevřete je.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Obrázek: Otevřít projekt**|

Projekt se otevře a závislosti budou automaticky staženy. V záložce Projekty procházejte příklady ve složce **source packages**. Chcete-li spustit příklad, stačí pravým tlačítkem kliknout na soubor a vybrat **Spustit soubor**, příklad se spustí a výstup se zobrazí v okně konzole.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Obrázek: Spusťte příklad**|

## **Přidání knihovny Aspose.CAD do lokálního repozitáře Maven**

Pokud importujete projekt **Aspose.CAD Příklady** do IDE, Maven automaticky stáhne soubor JAR pro aspose.cad z [Repositáře Aspose Maven](https://releases.aspose.com/java/repo/). Pokud nemáte přístup k internetu, můžete soubor JAR ručně přidat do svého lokálního repozitáře.

### **mvn install**

Stáhněte si [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), rozbalte ho a zkopírujte soubor aspose.cad-verze.jar kamkoliv jinam, například na disk C. Vydávejte následující příkaz:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-verze.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={verze}

    -Dpackaging=jar

{{< /highlight >}}

Nyní je JAR soubor **aspose.cad** zkopírován do vašeho lokálního repozitáře Maven.

### **pom.xml**

Po instalaci jen deklarujte souřadnici **aspose.cad** v souboru pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Hotovo**

Sestavte to, nyní je možné získat JAR soubor **aspose.cad** z vašeho lokálního repozitáře Maven.

## **Přispět**

Pokud chcete přidat nebo vylepšit příklad, povzbuzujeme vás k přispění do projektu. Všechny příklady a ukázkové projekty v tomto repozitáři jsou open source a mohou být volně použity ve vašich vlastních aplikacích.

Pro přispění můžete forkovat repozitář, upravit zdrojový kód a odeslat Pull Request. Vaše změny zkontrolujeme a zařadíme je do repozitáře, pokud se nám budou zdát užitečné.
