---
title: Aspose.CAD'i JavaScript'te Nasıl Kullanılır
type: docs
description: "Aspose.CAD'i JavaScript'te kullanın."
weight: 73
url: /tr/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Ön Koşullar
- Visual Code + Live Server
- Node.js

## DGN görüntüsünü PNG'ye dönüştürme ve tarayıcıda görüntüleme

Bu örnekte, bir çizimi dönüştüren ve bunu bir görüntü olarak kaydeden basit bir dönüşüm programı oluşturuyorsunuz.

## JavaScript Oluşturma

1. Aspose.CAD bağımlılıkları ile package.json oluşturun
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
1. index.html oluşturun
{{< highlight plain >}}
<!DOCTYPE html>
Konsolu açmak için (Ctrl+Shift+I) çıkışları görün.

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

1. npm komutunu kullanarak paketleri yükleyin
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) veya yarn ile uygulamayı başlatın
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Çalıştırma örneği

1. Dosya seçin.<br>
![Dosya seçin](/cad/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Herhangi bir DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG dosyasını seçin.
1. Cevap başarılı olursa, dosya ekranda görüntülenir ve indirilmesi için teklif edilir.<br>
![Görüntüyü dönüştür](/cad/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Ayrıca Bakınız

- [Visual Code'u Yükleyin](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.js'i Yükleyin](https://nodejs.org/en/)
