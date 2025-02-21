---
title: Aspose.CAD를 JavaScript에서 사용하는 방법
type: docs
description: "JavaScript에서 Aspose.CAD를 사용하세요."
weight: 73
url: /ko/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## 전제 조건
- Visual Code + Live Server
- Node.js

## dgn 이미지를 png로 변환하고 브라우저에 표시하기

이 예제에서는 그림을 변환하고 이미지를 저장하는 간단한 변환 프로그램을 생성합니다.

## JavaScript 만들기

1. aspose-cad 종속성이 있는 package.json 생성
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
1. index.html 생성
{{< highlight plain >}}
<!DOCTYPE html>
콘솔을 열려면(Ctrl+Shift+I) 출력 결과를 확인하세요.

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
          
		  //파일 형식 가져오기
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // 로드
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // 저장
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

1. npm 명령어로 패키지 설치
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) 또는 yarn으로 애플리케이션 시작
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## 실행 예시

1. 파일 선택.<br>
![파일 선택](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG 파일 중 하나를 선택하세요.
1. 응답이 성공적이면 파일이 화면에 표시되고 다운로드를 제안합니다.<br>
![이미지 변환](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## 참조

- [Visual Code 설치하기](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.js 설치하기](https://nodejs.org/en/)
