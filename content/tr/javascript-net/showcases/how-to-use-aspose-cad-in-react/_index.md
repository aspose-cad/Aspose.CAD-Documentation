---
title: Aspose.CAD'ı React'te Nasıl Kullanılır
type: docs
description: "Aspose.CAD'ı React'te kullanın"
weight: 75
url: /tr/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Ön Koşullar
- Visual Code
- Node.js

## DGN görüntüsünü PNG'ye dönüştürün ve tarayıcıda görüntüleyin

Bu örnekte, bir çizimi dönüştüren ve bir görüntü olarak kaydeden basit bir dönüşüm programı oluşturursunuz.

## React Projesi Oluşturma

1. Zaten bir React çalışma alanı dizininde olmadığınızdan emin olun.
1. Yeni bir tane başlatın ve ardından programın adını yazın veya Visual Code veya WebStorm gibi diğer programları kullanarak bir proje oluşturun:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. npm paketinden Aspose.CAD'ı kurun
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Çizimi yüklemek ve görüntülemek için bir giriş dosyası ve img etiketleri oluşturun
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="dönüştürüldü" id="image" />
</span>
{{< /highlight >}}
1. App.tsx'de, yardımcı işlemleri başlatma, işleme ve görüntüyü kaydetme sürecini tanımlıyoruz
{{< highlight plain >}}
import React from 'react';
import './App.css';
import {boot} from "aspose-cad/dotnet";
import {Image, PngOptions} from "aspose-cad";
function App() {
  return (
    <div className="App">
      <header className="App-header">
          <input id="file" type="file"/>
          <img alt="dönüştürüldü" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("WASM yükleniyor...");
  await boot();
  console.log("WASM yüklendi");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // YÜKLE
          var file = Image.load(array);

          // KAYDET
          var exportedFilePromise = Image.save(array, new PngOptions());
          exportedFilePromise.then((exportedFile: BlobPart) => {
            console.log(exportedFile);

            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            // @ts-ignore
            document.querySelector("#image").src = imageUrl;
          });
        }
        // @ts-ignore
        reader.readAsArrayBuffer(this.files[0]);
      },
      false);
};
export default App;

{{< /highlight >}}
1. Uygulamayı başlatın
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Uygulama örneği

1. Dosyayı seçin.<br>
![Dosyayı seçin](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
1. Cevap başarılıysa, dosya ekranda görüntülenecek ve indirilmesi teklif edilecektir.<br>
![Görüntüyü dönüştür](/cad/_assets/javascript-net/react/convert-image.png)<br>

## Ayrıca Bakın

- [Visual Code'u Kurun](https://code.visualstudio.com/)
- [Node.js'i Kurun](https://nodejs.org/en/)
