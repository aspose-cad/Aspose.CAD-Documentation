---
title: Wie man die Beispiele ausführt
type: docs
weight: 70
url: /de/java/how-to-run-the-examples/
---

## **Herunterladen von GitHub**

Alle Beispiele von Aspose.CAD für Java sind auf [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java) gehostet. Sie können entweder das Repository mit Ihrem bevorzugten Github-Client klonen oder die ZIP-Datei von [hier](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip) herunterladen.

Extrahieren Sie den Inhalt der ZIP-Datei in einen beliebigen Ordner auf Ihrem Computer. Alle Beispiele befinden sich im **Beispiele**-Ordner.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Abbildung: Aspose.CAD Beispiele Verzeichnis**|

## **Beispiele in die IDE importieren**

Das Projekt verwendet das Maven-Bausystem. Jede moderne IDE kann das Projekt und dessen Abhängigkeiten problemlos öffnen oder importieren. Im Folgenden zeigen wir Ihnen, wie Sie beliebte IDEs verwenden können, um die Beispiele zu kompilieren und auszuführen.

### **IntelliJ IDEA**

Klicken Sie auf das **Datei**-Menü und wählen Sie **Öffnen**. Navigieren Sie zum Projektordner und wählen Sie die **pom.xml**-Datei aus.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Abbildung: Datei oder Verzeichnis zum Import auswählen**|
Es öffnet das Projekt und lädt die Abhängigkeiten automatisch herunter. Im Projekt-Tab durchsuchen Sie die Beispiele im **src/main/java**-Ordner. Um ein Beispiel auszuführen, klicken Sie mit der rechten Maustaste auf die Datei und wählen Sie "Ausführen ..", das Beispiel wird ausgeführt und die Ausgabe wird im integrierten Konsolenfenster angezeigt.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Abbildung: Beispiel ausführen**|

### **Eclipse**

Klicken Sie auf das **Datei**-Menü und wählen Sie **Import**. Wählen Sie **Maven** - Bestehende Maven-Projekte.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Abbildung: Importieren**|
Navigieren Sie zum Ordner, den Sie von GitHub geklont oder heruntergeladen haben, und wählen Sie die **pom.xml**-Datei aus. Das Projekt wird geöffnet und die Abhängigkeiten automatisch heruntergeladen. Im Package Explorer-Tab durchsuchen Sie die Beispiele im **src/main/java**-Ordner. Um ein Beispiel auszuführen, klicken Sie mit der rechten Maustaste auf die Datei und wählen Sie **Als Java-Anwendung ausführen**, das Beispiel wird ausgeführt und die Ausgabe wird im integrierten Konsolenfenster angezeigt.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Abbildung: Beispiel ausführen**|

### **NetBeans**

Klicken Sie auf das **Datei**-Menü und wählen Sie **Projekt öffnen**. Navigieren Sie zum Ordner, den Sie von GitHub geklont oder heruntergeladen haben. Das Symbol des **Beispiele**-Ordners zeigt an, dass es sich um ein Maven-Projekt handelt. Wählen Sie Beispiele und öffnen Sie sie.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Abbildung: Projekt öffnen**|
Das Projekt wird geöffnet und die Abhängigkeiten automatisch heruntergeladen. Im Projects-Tab durchsuchen Sie die Beispiele im **Quellpakete**. Um ein Beispiel auszuführen, klicken Sie mit der rechten Maustaste auf die Datei und wählen Sie **Datei ausführen**, das Beispiel wird ausgeführt und die Ausgabe wird im integrierten Konsolenfenster angezeigt.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Abbildung: Beispiel ausführen**|

## **Hinzufügen der Aspose.CAD-Bibliothek zum Maven-Lokalrepository**

Wenn Sie das **Aspose.CAD Beispiele**-Projekt in die IDE importieren, lädt Maven automatisch die aspose.cad JAR-Datei aus dem [Aspose Maven-Repository](https://releases.aspose.com/java/repo/) herunter. Falls Sie keinen Internetzugriff haben, können Sie das JAR manuell in Ihr lokales Repository hinzufügen.

### **mvn install**

Laden Sie die [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) herunter, extrahieren Sie sie und kopieren Sie die aspose.cad-version.jar an einen anderen Ort, zum Beispiel auf Laufwerk C. Geben Sie den folgenden Befehl ein:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Nun ist das **aspose.cad**-JAR in Ihr Maven-Lokalrepository kopiert.

### **pom.xml**

Nach der Installation geben Sie einfach die **aspose.cad**-Koordinate in der pom.xml-Datei an.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Fertig**

Bauen Sie es, nun kann das **aspose.cad**-JAR aus Ihrem Maven-Lokalrepository abgerufen werden.

## **Beitragen**

Wenn Sie ein Beispiel hinzufügen oder verbessern möchten, ermutigen wir Sie, zum Projekt beizutragen. Alle Beispiele und Showcase-Projekte in diesem Repository sind Open Source und können frei in Ihren eigenen Anwendungen verwendet werden.

Um beizutragen, können Sie das Repository fork, den Quellcode bearbeiten und einen Pull-Request einreichen. Wir werden die Änderungen überprüfen und sie in das Repository aufnehmen, wenn sie hilfreich sind.
