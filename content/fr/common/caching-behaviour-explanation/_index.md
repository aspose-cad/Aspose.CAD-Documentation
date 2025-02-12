---
title: Explication du comportement de mise en cache d'Aspose.CAD
type: docs
weight: 20
url: /fr/common/caching-behaviour-explanation
---


## **Comment Aspose.CAD met en cache les données**

Toute mise en cache effectuée par Aspose.CAD est entièrement automatique, sans aucune contribution ou possibilité d'intervention de l'utilisateur. Il existe essentiellement trois types de mise en cache, tous liés aux polices.

### **Cache de noms de polices**

Le cache de noms de polices est utilisé pour faciliter un démarrage plus rapide en prétraitant tous les fichiers de polices trouvés et en compilant une liste des noms de polices présents dans ces fichiers, car un fichier de polices peut contenir plus d'une police. Il est stocké sous forme de fichier temporaire et pèse au maximum quelques dizaines de kilo-octets pour la plupart des systèmes.

### **Cache de données de glyphes de polices**

Un cache en mémoire de tous les glyphes qui ont été utilisés pendant la durée de vie de l'application pour réduire la re-lecture des fichiers de polices réels sur disque lors des exports ultérieurs. En tant que tel, cela entraînerait une consommation de mémoire en constante augmentation si les exports suivants contenaient des fichiers qui se référaient à de nouvelles polices et/ou contenaient des caractères non rencontrés auparavant. Cependant, en pratique, même dans l'ensemble du 
ensemble de tests d'Aspose.CAD, avec des milliers de fichiers incluant des fichiers dans différentes langues, sa consommation de mémoire est d'environ 200 mégaoctets, ce qui n'est pas très significatif pour un système moderne.

### **Cache de secours de polices par caractère**

Un cache en mémoire qui stocke les polices contenant un caractère donné pour tous les caractères Unicode afin de faciliter la sélection d'une police de remplacement au cas où une police fournie par une entité de texte dans un dessin ne contiendrait pas un caractère dans le contenu textuel de cette entité. Il est constitué lors de la première opération d'exportation pendant la durée de vie de l'application et demeure jusqu'à la terminaison de l'application. Sur nos machines de test relativement modestes avec d'énormes collections de polices utilisées dans les suites de tests, le cache prend environ 30 secondes à construire et occupe 70 mégaoctets. Une fois construit, il ne prend plus de temps et ne grandit plus.
