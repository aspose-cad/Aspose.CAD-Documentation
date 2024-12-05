---
title: Explaining caching behaviour of Aspose.CAD
type: docs
weight: 20
url: /python-net/caching-behaviour-explanation
---


## **How Aspose.CAD caches data**

All caching done by Aspose.CAD is completely automatic, without any user input needed or possible. There are essentially three kinds of caching, all of them are related to fonts.

### **Font name cache**

Font name cache is used to facilitate faster startup by pre-processing all found font files and compiling list of font names present in these files, as one font file may contain more than one font. It is stored as a temporary file and is at most tens of kilobytes in size for most systems.

### **Font glyph data cache**

An in-memory cache of all glyphs that have been used during application lifetime to reduce re-reading of actual on-disk font files during subsequent exports. As such, it would result in steadily increasing memory consumption if subsequent exports would have files that refer to new fonts and/or contain characters not encountered before. However, in practice, even on the whole 
Aspose.CAD's test suite, with thousands of files including files in different languages, its memory consumption is about 200 megabytes, which is not very significant for a modern system.

### **Per-character font fallback cache**

An in-memory cache that stores fonts that contain a given character for all Unicode characters in order to facilitate picking up a replacement font in case a font supplied by an text entity in a drawing doesn't contain a character in that entity's text content. It is built at the first export operation during application lifetime and resides until application termination. On our relatively modest test machines with massive font collections used in the test suites, the cache takes about 30 seconds to build and takes 70 megabytes. Once built, it no longer takes any time and doesn't grow. 

