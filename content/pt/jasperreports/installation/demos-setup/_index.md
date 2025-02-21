---
title: Configuração de Demos
type: docs
weight: 40
url: /pt/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports inclui uma série de projetos de demonstração para ajudar você a começar.

As demos fornecidas com Aspose.CAD para JasperReports são demos padrão do JasperReports modificadas para demonstrar o uso dos novos exportadores.

{{% /alert %}}

Para executar as demos do Aspose.CAD para JasperReports, siga os seguintes passos:

1. Baixe o JasperReports (por exemplo, https://sourceforge.net/projects/jasperreports/files/archive/). Certifique-se de baixar o projeto arquivado completo com o código-fonte e as demos, não apenas um único JAR.
1. Descompacte o projeto arquivado em algum local do seu disco rígido, por exemplo, C:\.
1. Copie todas as pastas de demo da pasta \samples do **aspose-cad-xx.x.zip** para **\InstallDir\demo\samples**, onde "\InstallDir" é o local onde você descompactou o JasperReports. Este passo é necessário porque os scripts de construção da demo dependem da estrutura de pastas do JasperReports, caso contrário, você precisará modificar os scripts de construção.
1. Copie **aspose-cad-jasperreports-xx.x.jar** da pasta \lib do **aspose-cad-jasperreports-xx.x.zip** para **\InstallDir\lib**.
1. Prepare a Ant Build Tool e Ivy Dependency Manager, veja **\InstallDir\readme.txt**.
1. Modifique o **build.xml** em **\InstallDir\demo\samples**, adicione o aspose-cad-jasperreports-xx.x.jar ao classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Mude o diretório atual para **\InstallDir\demo\hsqldb** e execute o seguinte comando:
   **Ant runServer**
1. Mude o diretório atual para uma das demos do Aspose.CAD para JasperReports, por exemplo, **\InstallDir\demo\samples\charts.ai** e execute os seguintes comandos na linha de comando:
   **ant test** - para produzir arquivos de relatório.
1. Abra um dos documentos resultantes para visualizar, por exemplo, **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
