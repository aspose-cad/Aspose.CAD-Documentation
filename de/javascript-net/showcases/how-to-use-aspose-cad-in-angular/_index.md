---
title: Wie man Aspose.CAD in Angular verwendet
type: docs
description: "Verwenden von Aspose.CAD in Angular."
weight: 71
url: /de/javascript-net/wie-man-aspose-cad-in-angular-verwendet
---

## Voraussetzungen
- Angular CLI
- Visual Studio Code
- Node.js

## DGN-Bild in PNG konvertieren und im Browser anzeigen

In diesem Beispiel erstellen Sie ein einfaches Konversionsprogramm, das eine Zeichnung konvertiert und als Bild speichert.

## Das Angular-Projekt erstellen

1. Stellen Sie sicher, dass Sie sich nicht bereits in einem Angular-Arbeitsbereisverzeichnis befinden.
1. Erstellen Sie ein neues und geben Sie dann den Namen des Programms ein oder verwenden Sie andere Programme, um ein Projekt zu erstellen, wie z. B. Visual Studio Code oder WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Installieren Sie Aspose.CAD aus dem npm-Paket
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Öffnen Sie die angular.json-Datei und fügen Sie einen Eintrag im Skriptfeld hinzu, dieses Skript beginnt mit dem Laden des Projekts, es ist erforderlich, um mit der Verarbeitung der Dateien zu beginnen
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. Erstellen Sie in der app.component.html ein Eingabetyp-Datei und img-Tags, um die Zeichnung zu laden und anzuzeigen
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. In der app.component.ts beschreiben wir den Prozess zum Starten der Hilfsprozesse, zur Verarbeitung und Speicherung des Bildes
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//notwendig, um den DotNet-Prozess zu starten
declare let dotnet: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular-example';

  imageUrl: any;
  imgFile: Uint8Array | null | undefined;

  constructor(private sanitizer: DomSanitizer) {
  }

  // @ts-ignore
  async ngOnInit() {
    console.log("Aspose.CAD WASM wird geladen...");
    await dotnet.boot().then((ex: any) => {
      console.log("Aspose.CAD WASM wurde geladen");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Bild laden
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //Bild als PNG speichern

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      // Erstelle Quelle für konvertiertes Bild
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      // PNG-Bild herunterladen
      let url = window.URL.createObjectURL(blob);
      let a = document.createElement('a');
      document.body.appendChild(a);
      a.setAttribute('style', 'display: none');
      a.href = url;
      a.download = "file.png";
      a.click();
      window.URL.revokeObjectURL(url);
      a.remove();

    });
  }
}
{{< /highlight >}}
1. Anwendung starten
{{< highlight plain >}}
npm start
//oder
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Der Befehl ng serve:

- Baut die Anwendung
- Startet den Entwicklungsserver
- Überwacht die Quelldateien
- Baut die Anwendung neu, wenn Änderungen vorgenommen werden

Der --open Flag öffnet einen Browser unter http://localhost:4200.
{{% /alert %}}

## Ausführungsbeispiel

1. Datei auswählen.<br>
![Datei auswählen](choose-file.png)<br>
1. Wählen Sie eine DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG-Datei aus.
1. Wenn die Antwort erfolgreich ist, wird die Datei auf dem Bildschirm angezeigt und es wird angeboten, sie herunterzuladen.<br>
![Bild konvertieren](convert-image.png)<br>

## Siehe auch

- [Angular CLI installieren](https://angular.io/guide/setup-local/)
- [Visual Studio Code installieren](https://code.visualstudio.com/)
- [Node.js installieren](https://nodejs.org/en/)
