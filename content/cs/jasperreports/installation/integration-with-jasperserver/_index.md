---
title: Integrace s JasperServerem
type: docs
weight: 20
url: /cs/jasperreports/integration-with-jasperserver/
---
{{% alert color="primary" %}}
Pro integrování Aspose.CAD pro JasperReports s JasperServerem je nutné provést několik dalších kroků a aktualizovat konfigurační soubory JasperServeru. Tento článek vysvětluje jak na to.
{{% /alert %}}
1. Přidejte nové vlastnosti exportéru do konfiguračního souboru %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml.
{{< highlight xml >}}
    <!--JPG-->
    <bean id="reportASJpegExporter" class="com.aspose.cad.jasperreports.jpg.ASReportJpegExporter"
          parent="baseReportExporter">
        <property name="exportParameters" ref="jpgExportParameters"/>
        <property name="exportMode">
            <value type="com.aspose.cad.jasperreports.common.ExportMode">Batch</value>
        </property>
    </bean>

    <!-- zbylý kód vynechán pro zjednodušení -->

    <bean id="wmfASExporterParameters" class="com.jaspersoft.jasperserver.war.action.ExporterConfigurationBean">
        <property name="descriptionKey" value="WMF - Export obrázku z Aspose.CAD"/>
        <property name="parameterDialogName" value="wmfExportParams"/>
        <property name="exportParameters" ref="wmfExportParameters"/>
        <property name="currentExporter" ref="reportASWmfExporter"/>
    </bean>
{{< /highlight >}}

Pro změnu režimu exportu použijte vlastnost s názvem "exportMode" a dejte hodnotu v souladu s požadovaným režimem.
Například:
{{< highlight xml >}}
    <property name="exportMode">
        <value type="com.aspose.cad.jasperreports.common.ExportMode">SinglePage</value>
    </property>
{{< /highlight >}}
Hodnotu vlastnosti můžete změnit na Batch, SinglePage nebo Multipage pomocí výčtového typu com.aspose.cad.jasperreports.common.ExportMode.

2. Najděte prvek <util:map id="exporterConfigMap">...</util:map> v souboru %INTALL_DIR%\\apache-tomcat\webapps\jasperserver\WEB-INF\flows\viewReportBeans.xml a přidejte následující řádky:
{{< highlight xml >}}
    <util:map id="exporterConfigMap">
        <!-- komentáře odstraněny pro zjednodušení -->
        <entry key="as_jpg" value-ref="jpgASExporterParameters"/>
        <!-- zbylé položky exportérů vynechány pro zjednodušení -->
    </util:map>
{{< /highlight >}}

3. Zkopírujte aspose-cad-jasperreports-xx.xx.jar do %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\lib.
4. Pro použití funkcí exportu aktualizujte soubor %INTALL_DIR%\apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml následovně.
{{< highlight xml >}}
    <bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
        <!-- Komentáře vynechány pro zjednodušení -->
    </bean>

    <!-- zbylé položky exportérů vynechány pro zjednodušení -->
{{< /highlight >}}

5. Restartujte server JasperReports a otevřete libovolný report k zobrazení. Pokud byly předchozí kroky provedeny správně, uvidíte další možnosti v seznamu formátů exportu.
![todo:image_alt_text](/_assets/jasper/ExportReportView.png)

Pokud nevidíte další formáty (ikony nebo možnosti), zkontrolujte protokolovací soubory v adresáři \apache-tomcat\logs.