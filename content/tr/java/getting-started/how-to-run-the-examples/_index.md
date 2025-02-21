---
title: Örnekleri Çalıştırma Yöntemi
type: docs
weight: 70
url: /tr/java/getting-started/how-to-run-the-examples/
---

## **GitHub'dan İndirin**

Aspose.CAD for Java'nın tüm örnekleri [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java) üzerinde bulunmaktadır. İsterseniz favori Github istemcinizi kullanarak depoyu klonlayabilir veya [buradan](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip) ZIP dosyasını indirebilirsiniz.

ZIP dosyasının içeriğini bilgisayarınızdaki herhangi bir klasöre çıkarın. Tüm örnekler **Examples** klasöründe bulunmaktadır.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Şekil: Aspose.CAD Örnekleri Dizini**|

## **Örnekleri IDE'ye Aktarın**

Proje Maven yapı sistemini kullanmaktadır. Herhangi bir modern IDE projeyi ve bağımlılıklarını kolayca açabilir veya içe aktarabilir. Aşağıda popüler IDE'leri kullanarak örnekleri nasıl oluşturup çalıştıracağınızı gösteriyoruz.

### **IntelliJ IDEA**

**File** menüsüne tıklayın ve **Open** seçeneğini seçin. Proje klasörüne göz atın ve **pom.xml** dosyasını seçin.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Şekil: İçe Aktarılacak Dosya veya Dizin Seçin**|
Proje açılacak ve bağımlılıklar otomatik olarak indirilecektir. Proje sekmesinden, **src/main/java** klasöründeki örneklere göz atın. Bir örneği çalıştırmak için dosyanın üzerine sağ tıklayın ve "Run .." seçeneğini seçin, örnek çalıştırılacak ve sonuç dahili konsol çıktısı penceresinde gösterilecektir.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Şekil: Örneği Çalıştır**|

### **Eclipse**

**File** menüsüne tıklayın ve **Import** seçeneğini seçin. **Maven** - Mevcut Maven Projeleri'ni seçin.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Şekil: İçe Aktar**|
GitHub'dan klonladığınız veya indirdiğiniz klasöre göz atın ve **pom.xml** dosyasını seçin. Proje açılacak ve bağımlılıklar otomatik olarak indirilecektir. Paket Gezgini sekmesinden, **src/main/java** klasöründeki örneklere göz atın. Bir örneği çalıştırmak için dosyanın üzerine sağ tıklayın ve **Run As** - **Java Application** seçeneğini seçin, örnek çalıştırılacak ve sonuç dahili konsol çıktısı penceresinde gösterilecektir.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Şekil: Örneği Çalıştır**|

### **NetBeans**

**File** menüsüne tıklayın ve **Open Project** seçeneğini seçin. GitHub'dan klonladığınız veya indirdiğiniz klasöre göz atın. **Examples** klasörünün simgesi bu bir Maven projesi olduğunu gösterecektir. Örnekleri seçin ve açın.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Şekil: Projeyi Aç**|
Proje açılacak ve bağımlılıklar otomatik olarak indirilecektir. Projeler sekmesinden, **source packages** içindeki örneklere göz atın. Bir örneği çalıştırmak için dosyanın üzerine sağ tıklayın ve **Run File** seçeneğini seçin, örnek çalıştırılacak ve sonuç dahili konsol çıktısı penceresinde gösterilecektir.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Şekil: Örneği Çalıştır**|

## **Aspose.CAD Kütüphanesini Maven Yerel Depoya Eklemek**

**Aspose.CAD Örnekleri** projesini IDE'ye aktardığınızda, Maven otomatik olarak aspose.cad JAR dosyasını [Aspose Maven Repository](https://releases.aspose.com/java/repo/) adresinden indirir. İnternete erişiminiz yoksa, JAR dosyasını yerel deponuza elle ekleyebilirsiniz.

### **mvn install**

[aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) dosyasını indirin, çıkarın ve aspose.cad-version.jar'ı başka bir yere, örneğin C sürücüsüne kopyalayın. Aşağıdaki komutu verin:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Şimdi, **aspose.cad** jar dosyası Maven yerel deponuza kopyalanmış durumdadır.

### **pom.xml**

Kurulumdan sonra, sadece **pom.xml** içinde **aspose.cad** koordinatını bildirin.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Tamamlandı**

İnşa edin, artık **aspose.cad** jar dosyası Maven yerel deponuzdan alınabilir.

## **Katkıda Bulunun**

Bir örneği eklemek veya geliştirmek isterseniz, projeye katkıda bulunmanızı teşvik ediyoruz. Bu depodaki tüm örnekler ve vitrin projeleri açık kaynak olup kendi uygulamalarınızda serbestçe kullanılabilir.

Katkıda bulunmak için, depoyu çatallayabilir, kaynak kodunu düzenleyebilir ve bir Pull Request gönderebilirsiniz. Değişiklikleri gözden geçireceğiz ve yararlı bulunursa depoya ekleyeceğiz.
