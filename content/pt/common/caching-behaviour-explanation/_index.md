---
title: Explicando o comportamento de caching do Aspose.CAD
type: docs
weight: 20
url: /pt/common/caching-behaviour-explanation/
---


## **Como o Aspose.CAD faz cache de dados**

Todo o caching feito pelo Aspose.CAD é completamente automático, sem necessidade ou possibilidade de input do usuário. Existem essencialmente três tipos de caching, todos relacionados a fontes.

### **Cache de nome de fonte**

O cache de nome de fonte é usado para facilitar um início mais rápido, pré-processando todos os arquivos de fonte encontrados e compilando uma lista de nomes de fonte presentes nesses arquivos, já que um arquivo de fonte pode conter mais de uma fonte. Ele é armazenado como um arquivo temporário e tem, no máximo, algumas dezenas de kilobytes na maioria dos sistemas.

### **Cache de dados de glifos de fonte**

Um cache em memória de todos os glifos que foram usados durante a vida útil do aplicativo para reduzir a releitura dos arquivos de fonte reais no disco durante exportações subsequentes. Assim, resultaria em um consumo de memória crescente se as exportações subsequentes contivessem arquivos que se referissem a novas fontes e/ou contivessem caracteres não encontrados antes. No entanto, na prática, mesmo em toda a 
suíte de testes do Aspose.CAD, com milhares de arquivos incluindo arquivos em diferentes idiomas, seu consumo de memória é de cerca de 200 megabytes, o que não é muito significativo para um sistema moderno.

### **Cache de fallback de fonte por caractere**

Um cache em memória que armazena fontes que contêm um determinado caractere para todos os caracteres Unicode, a fim de facilitar a escolha de uma fonte substituta caso uma fonte fornecida por uma entidade de texto em um desenho não contenha um caractere no conteúdo de texto dessa entidade. Ele é construído na primeira operação de exportação durante a vida útil do aplicativo e permanece até a terminação do aplicativo. Em nossas máquinas de teste relativamente modestos, com coleções massivas de fontes usadas nas suítes de teste, o cache leva cerca de 30 segundos para construir e ocupa 70 megabytes. Uma vez construído, ele não leva mais tempo e não cresce.
