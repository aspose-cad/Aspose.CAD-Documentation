---
title: Aspose.CAD'i Angular'da Kullanma
type: docs
description: "Aspose.CAD'i Angular'da kullanın."
weight: 71
url: /tr/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Önkoşullar
- Angular CLI
- Visual Code
- Node.js

## DGN resmini PNG'ye çevirin ve tarayıcıda görüntüleyin

Bu örnekte, bir çizimi dönüştüren ve bir resim olarak kaydeden basit bir dönüştürme programı oluşturuyorsunuz.

## Angular Projesini Oluşturma

1. Zaten bir Angular çalışma alanı dizininde olmadığınızdan emin olun.
1. Yeni bir tane başlatın ve ardından programın adını verin ya da bir projeyi oluşturmak için Visual Code veya WebStorm gibi diğer programları kullanın:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. npm paketinden Aspose.CAD'i yükleyin
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. angular.json dosyasını açın ve script alanına bir girdi ekleyin, bu script proje ile birlikte yüklenmeye başlar, dosyaların işlenmesi için gereklidir
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. app.component.html dosyasında, çizimi yüklemek ve görüntülemek için bir dosya türü girişi ve img etiketleri oluşturun
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. app.component.ts dosyasında, yardımcı süreçlerin başlatılması, işlenmesi ve resmin kaydedilmesi sürecini tanımlıyoruz
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//dotnet sürecini başlatmak gerekiyor
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
    console.log("aspose-cad WASM yükleniyor...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM yüklendi");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Resmi yükle
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //Resmi png olarak kaydet

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //dönüştürülen resim için src oluştur
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //png resmini indir
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
1. Uygulamayı başlatın
{{< highlight plain >}}
npm start
//veya
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
ng serve komutu:

- Uygulamayı oluşturur
- Geliştirme sunucusunu başlatır
- Kaynak dosyalarını izler
- Değişiklik yaptıkça uygulamayı yeniden oluşturur

--open bayrağı, http://localhost:4200 adresinde bir tarayıcı açar.
{{% /alert %}}

## Uygulama Örneği

1. Dosya seçin.<br>
![Dosya seçin](/_assets/javascript-net/angular/choose-file.png)<br>
1. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
1. Cevap başarılıysa, dosya ekranda görüntülenecek ve indirilmesi önerilecektir.<br>
![Resmi dönüştür](/_assets/javascript-net/angular/convert-image.png)<br>

## Ayrıca Bakınız

- [Angular CLI'yi Kurun](https://angular.io/guide/setup-local/)
- [Visual Code'u Kurun](https://code.visualstudio.com/)
- [Node.js'i Kurun](https://nodejs.org/en/)
