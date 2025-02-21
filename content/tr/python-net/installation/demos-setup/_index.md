---
title: Demo Kurulumu
type: docs
weight: 40
url: /tr/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for Python, başlangıç yapmanıza yardımcı olmak için bir dizi demo projesi içerir.

Aspose.CAD for Python ile sağlanan demolar, yeni ihracatçıların kullanımını göstermek için değiştirilmiş standart Python demolarıdır.

{{% /alert %}}

Aspose.CAD for Python demolarını çalıştırmak için aşağıdaki adımları izleyin:

1. Python'ı indirin (örn. https://sourceforge.net/projects/python-net/files/archive/). Kaynak kodu ve demolarla birlikte tüm arşivlenmiş projeyi indirmeyi unutmayın, sadece tek bir JAR indirmeyin.
1. Arşivlenmiş projeyi sabit diskinizde bir yere çıkarın, örneğin C:\.
1. **aspose-cad-xx.x.zip** dosyasının \samples klasöründeki tüm demo klasörlerini **\InstallDir\demo\samples** klasörüne kopyalayın, burada "\InstallDir" Python'ı çıkardığınız yerdir. Bu adım gereklidir çünkü demo yapı betikleri, Python'ın klasör yapısına dayanır; aksi takdirde yapı betiklerini değiştirmeniz gerekecektir.
1. **aspose-cad-pythons-xx.x.jar** dosyasını **aspose-cad-pythons-xx.x.zip** dosyasının \lib klasöründen **\InstallDir\lib** klasörüne kopyalayın.
1. Ant Build Tool ve Ivy Dependency Manager'ı hazırlayın, bkz. **\InstallDir\readme.txt**.
1. **\InstallDir\demo\samples** klasöründeki **build.xml** dosyasını değiştirin, aspose-cad-pythons-xx.x.jar dosyasını sınıf yoluna ekleyin:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Mevcut dizini **\InstallDir\demo\hsqldb** olarak değiştirin ve aşağıdaki komut satırını çalıştırın:
   **ant runServer**
1. Mevcut dizini, Aspose.CAD for Python demolarından birine, örneğin **\InstallDir\demo\samples\charts.ai** olarak değiştirin ve komut satırında aşağıdaki komutları çalıştırın:
   **ant test** - rapor dosyası oluşturmak için.
1. Ortaya çıkan belgelerden birini görüntülemek için açın, örneğin **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
