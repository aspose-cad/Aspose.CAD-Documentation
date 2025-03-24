---
title: Aspose.CAD'i TypeScript'te Nasıl Kullanılır
type: docs
description: "Aspose.CAD'i TypeScript'te kullanın."
weight: 74
url: /tr/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---

## Gerekli Ön Koşullar
- Visual Code + Live Server
- Node.js

## DGN görüntüsünü PNG'ye dönüştürme ve tarayıcıda görüntüleme

Bu örnekte, bir çizimi dönüştüren ve resmi kaydeden basit bir dönüşüm programı oluşturursunuz.

## JavaScript Oluşturma

1. Proje klasöründe package.json oluşturun
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
2. package.json dosyasını düzenleyin, aspose-cad bağımlılıklarını ekleyin
{{< highlight plain >}}
"dependencies": {
    "aspose-cad": "^23.1.0"
  },
 "devDependencies": {
    "live-server": "^1.2.1",
    "typescript": "^3.3.3333",
    "yarn": "^1.22.19"
  }
{{< /highlight >}}
3. index.ts oluşturun
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //DOSYA_FORMATINI_AL
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // YÜKLE
    var file = Image.load(array);
    console.log(file);
    
    // KAYDET
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
4. npm komutunu kullanarak index.js oluşturun
{{< highlight plain >}}
tsc
{{< /highlight >}}
5. index.html oluşturun
{{< highlight plain >}}
<!DOCTYPE html>
Konsolu açın (Ctrl+Shift+I) çıktıyı görmek için.

<script src="./node_modules/aspose-cad/dotnet.js"></script>
<script type="module" src="./node_modules/aspose-cad/es2015/index-js.js"></script>

<body>
	<input id="file" type="file">
	<img id="image" />
</body>

<script>
window.onload = async function () {
	document.querySelector('input').addEventListener('change', function() {
      var reader = new FileReader();
      reader.onload = function() {
      
          var arrayBuffer = this.result;
          var array = new Uint8Array(arrayBuffer);
          
		  //DOSYA_FORMATINI_AL
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // YÜKLE
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // KAYDET
		  exportedFilePromise = Aspose.CAD.Image.save(array, new Aspose.CAD.PngOptions());
		  exportedFilePromise.then(exportedFile => {
			console.log(exportedFile);
			
			var urlCreator = window.URL || window.webkitURL;
			var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            document.querySelector("#image").src = imageUrl;
		  });
      }
	  
      reader.readAsArrayBuffer(this.files[0]);
    }, 
	false);
};
</script>
{{< /highlight >}}

6. npm komutunu kullanarak paketleri yükleyin
{{< highlight plain >}}
npm install
{{< /highlight >}}
7. Uygulamayı [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) veya yarn ile başlatın
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Uygulama Örneği

1. Dosya seçin.<br>
![Dosya seçin](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
2. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
3. Cevap başarılıysa, dosya ekranda görünecek ve indirmeniz için teklif verecektir.<br>
![Görüntüyü dönüştür](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## Ayrıca Bakınız

- [Visual Code'u Yükleyin](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.js'i Yükleyin](https://nodejs.org/en/)
