---
title: Integrace s JasperServerem
type: docs
weight: 20
url: /cs/python-net/integrace-s-jasperserverem/
---
{{% alert color="primary" %}}
Pro integraci Aspose.CAD pro Python s JasperServerem je nutné provést několik dalších kroků a aktualizovat konfigurační soubory JasperServeru. Tento článek vysvětluje jak.
{{% /alert %}}
1. Přidejte nové vlastnosti exportéru do konfiguračního souboru %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml.
{{< highlight xml >}}
    <!--JPG-->
    <bean id="reportASJpegExporter" class="com.aspose.cad.pythons.jpg.ASReportJpegExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.pythons.common.ExportMode">Batch</value>
        </property>
    </bean>

    <!-- zbytek kódu byl zjednodušen pro přehlednost -->
{{< /highlight >}}

    Pro změnu módu exportu použijte vlastnost s názvem "exportMode" a dejte hodnotu dle požadovaného módu. 
Například:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.pythons.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
    Hodnotu vlastnosti můžete změnit na Batch, SinglePage nebo Multipage použitím výčtu typu com.aspose.cad.pythons.common.ExportMode.

2. Najděte prvek <util:map id="exporterConfigMap">...</util:map> v souboru %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml a přidejte následující řádky:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- zbytek kódu byl zjednodušen pro přehlednost -->
        <!-- 
        <entry key="txt" value-ref="txtExporterConfiguration"/>
        -->
		
			<!-- přidejte tyto záznamy do exporterConfigMap -->
			<!-- Aspose.CAD Pythons START -->
		<!-- zbytek kódu byl zjednodušen pro přehlednost -->
		<!-- Aspose.CAD for Python END -->
    </util:map>
{{< /highlight >}}
3. Zkopírujte aspose-cad-pythons-xx.xx.jar do %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib.
4. Pro použití exportních funkcí aktualizujte %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml následovně.
{{< highlight xml >}}
    <!-- zbytek kódu byl zjednodušen pro přehlednost -->
{{< /highlight >}}

5. Restartujte server Pythons a otevřete libovolnou zprávu k zobrazení. Pokud byly předchozí kroky provedeny správně, uvidíte další možnosti ve výběru formátů exportu.
![todo:image_alt_text](/_assets/ExportReportView.png)

Pokud nevidíte další formáty (ikony nebo možnosti), zkontrolujte logovací soubory ve složce \apache-tomcat\logs.