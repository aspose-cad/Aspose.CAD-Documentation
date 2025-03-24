---
title: Aspose.CADをTypeScriptで使用する方法
type: docs
description: "TypeScriptでAspose.CADを使用します。"
weight: 74
url: /ja/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## 必要条件
- Visual Code + Live Server
- Node.js

## dgn画像をpngに変換してブラウザに表示する

この例では、図面を変換し、画像として保存するシンプルな変換プログラムを作成します。

## JavaScriptの作成

1. プロジェクトフォルダーにpackage.jsonを作成します
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. package.jsonを修正し、aspose-cadの依存関係を追加します
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
1. index.tsを作成します
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //ファイルフォーマット取得
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // 読み込み
    var file = Image.load(array);
    console.log(file);
    
    // 保存
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. npmコマンドを使ってindex.jsを作成します
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. index.htmlを作成します
{{< highlight plain >}}
<!DOCTYPE html>
コンソールを開く (Ctrl+Shift+I) で出力を確認します。

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
          
		  //ファイルフォーマット取得
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // 読み込み
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // 保存
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

1. npmコマンドを使用してパッケージをインストールします
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)またはyarnを使用してアプリケーションを起動します
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## 実行例

1. ファイルを選択します。<br>
![ファイルを選択](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVGファイルを任意で選択します。
1. 応答が成功すると、ファイルが画面に表示され、ダウンロードを提案します。<br>
![画像を変換](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## 関連リンク

- [Visual Codeをインストール](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.jsをインストール](https://nodejs.org/en/)
