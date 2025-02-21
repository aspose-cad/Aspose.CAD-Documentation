---
title: Demo Kurulumu
type: docs
weight: 40
url: /tr/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports, başlamanıza yardımcı olacak bir dizi demo projesi içerir.

Aspose.CAD for JasperReports ile sağlanan demolar, yeni çıkartıcıların kullanımını göstermek için değiştirilmiş standart JasperReports demolarıdır.

{{% /alert %}}

Aspose.CAD for JasperReports demolarını çalıştırmak için aşağıdaki adımları izleyin:

1. JasperReports'u indirin (örneğin https://sourceforge.net/projects/jasperreports/files/archive/). Tam arşivlenmiş proje kaynağı ve demolar ile birlikte indirdiğinizden emin olun, sadece tek bir JAR indirmeyin.
1. Arşivlenmiş projeyi sabit diskinizde bir konuma açın, örneğin C:\.
1. **aspose-cad-xx.x.zip** içindeki \samples klasöründen tüm demo klasörlerini **\InstallDir\demo\samples** konumuna kopyalayın; burada "\InstallDir" JasperReports'u açtığınız konumdur. Bu adım gereklidir çünkü demo oluşturma betikleri JasperReports’un klasör yapısına bağlıdır, aksi takdirde oluşturma betiklerini değiştirmeniz gerekecektir.
1. **aspose-cad-jasperreports-xx.x.jar** dosyasını **aspose-cad-jasperreports-xx.x.zip** içindeki \lib klasöründen **\InstallDir\lib** konumuna kopyalayın.
1. Ant Build Tool ve Ivy Dependency Manager'ı hazırlayın, bkz. **\InstallDir\readme.txt**.
1. **\InstallDir\demo\samples** konumundaki **build.xml** dosyasını değiştirin, aspose-cad-jasperreports-xx.x.jar dosyasını classpath'e ekleyin:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Mevcut dizini **\InstallDir\demo\hsqldb** konumuna değiştirin ve aşağıdaki komut satırını çalıştırın:
   **Ant runServer**
1. Mevcut dizini Aspose.CAD for JasperReports demolarından birine değiştirin, örneğin **\InstallDir\demo\samples\charts.ai** ve komut satırında aşağıdaki komutları çalıştırın:
   **ant test** - rapor dosyalarını oluşturmak için.
1. Ortaya çıkan belgelerden birini görüntülemek için açın, örneğin **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
