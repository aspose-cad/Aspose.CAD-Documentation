---
title: Demos Setup
type: docs
weight: 40
url: /jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports includes a number of demo projects to help you get started.

The demos provided with Aspose.CAD for JasperReports are standard JasperReports demos modified to demonstrate the use of the new exporters.

{{% /alert %}}

To run Aspose.CAD for JasperReports demos, perform the following steps:

1. Download JasperReports (e.g https://sourceforge.net/projects/jasperreports/files/archive/). Make sure to download the entire archived project with the source code and demos, not just a single JAR.
1. Unpack the archived project to some location on your hard disk, for example C:\.
1. Copy all demo folders from the \samples folder of **aspose-cad-xx.x.zip** to **\InstallDir\demo\samples**, where "\InstallDir" is the location you have unpacked JasperReports to. This step is required because demo build scripts rely on the JasperReports’ folder structure, otherwise you will need to modify build scripts.
1. Copy **aspose-cad-jasperreports-xx.x.jar** from the \lib folder of **aspose-cad-jasperreports-xx.x.zip** to **\InstallDir\lib**.
1. Prepare Ant Build Tool and Ivy Dependency Manager, see **\InstallDir\readme.txt**.
1. Modify the **build.xml** at **\InstallDir\demo\samples**, add the aspose-cad-jasperreports-xx.x.jar into the classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Change the current directory to **\InstallDir\demo\hsqldb** and run the following command line:
   **Ant runServer**
1. Change the current directory to one of the Aspose.CAD for JasperReports demos, for example **\InstallDir\demo\samples\charts.ai** and run the following commands in the command line:
   **ant test** - to produce report files.
1. Open one of the resulting documents to view, for example **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
