# String Mutation
C# String Library currently under development.

#### Features
A String Extension Library to add functionality to the String Type. 

## Download


# Documentation

* [capitalize](#capitalize)
* [chars](#chars)
* [chop](#chop)
* [count](#count)
* [countCharacters](#countCharacters)
* [countLines](#countLines)
* [countSentences](#countSentences)
* [countWords](#countWords)
* [escape](#escape)
* [getLongestWord](#getLongestWord)
* [getShortestWord](#getShortestWord)
* [includes](#includes)
* [join](#join)
* [lines](#lines)
* [ltrim](#ltrim)
* [reverse](#reverse)
* [rtrim](#rtrim)
* [stripTags](#stripTags)
* [titleize](#titleize)
* [toBoolean](#toBoolean)
* [toFloat](#toFloat)
* [toInt](#toInt)
* [toLowercase](#toLowercase)
* [toNumber](#toNumber)
* [toUppercase](#toUppercase)
* [trim](#trim)
* [truncate](#truncate)
* [unescape](#unescape)
* [words](#words)

<a name="capitalize">
### Capitalize

```csharp
'lorem ipsum dolor isamet'.capitalize(); // => Lorem ipsum dolor isamet
```

<a name="chars">
### Chars

```csharp
.chars('lorem'); // => ['l', 'o', 'r', 'e', 'm']
```

<a name="chop">
### Chop

```csharp
.chop('lorem ipsum dolor', 4); // => ['lore', 'm ip', 'sum ', 'dolo', 'r']
```

<a name="count">
### Count

```csharp
.count('lorem ipsum dolor', 'lor'); // => 2
```

<a name="countCharacters">
### CountCharacters

```csharp
.countCharacters('lorem'); // => 5
```

<a name="countLines">
### CountLines

```javascript
.countLines('Lorem ipsum.\n Dolor isamet.'); // => 2
```

<a name="countWords">
### CountWords

```csharp
.countWords('lorem ipsum'); // => 2
```

<a name="getLongestWord">
### GetLongestWord

```csharp
.getLongestWord(['lorem', 'ipsum', 'dolor', 'isamet']); // => isamet
```

<a name="getShortestWord">
### GetShortestWord

```csharp
.getShortestWord(['lo', 'rem']); // => lo
```

<a name="includes">
### Includes

```csharp
.includes('lorem ipsum', 'rem'); // => true
```

<a name="join">
### Join

```csharp
.join(['Hello', 'World'], ' '); // => Hello World
```

<a name="lines">
### Lines

```csharp
"Lorem ipsum.\n Dolor isamet.".lines(); // => ['Lorem ipsum.', 'Dolor isamet.']
```

<a name="ltrim">
### LTrim

```csharp
"  Hello!  ".ltrim(); // => "Hello!  "
```

<a name="reverse">
### Reverse

```csharp
"Hello!".reverse(); // => !olleH
```

<a name="rtrim">
### RTrim

```csharp
"  Hello!  ".rtrim(); // => "  Hello!"
```

<a name="titleize">
### Titleize

```csharp
"lorem ipsum dolor".titleize(); // => Lorem Ipsum Dolor
```

<a name="toLowercase">
### ToLowercase

```csharp
"HELLO!".toLowercase(); // => hello!
```

<a name="toUppercase">
### ToUppercase

```csharp
"hello!".toUppercase(); // => HELLO!
```

<a name="trim">
### Trim

```csharp
"  Hello!  ".trim(); // => Hello!
```

<a name="truncate">
### Truncate

```csharp
"Lorem ipsum dolor isamet pidet quidu delime.".truncate(, 10); // => Lorem ipsu...
```

<a name="words">
### Words

```csharp
"Lorem ipsum dolor isamet pidet quidu delime.".words(); // => ['Lorem', 'ipsum', 'dolor', 'isamet', 'pidet', 'quidu', 'delime.']
```
# Running Tests
# License
The MIT License (MIT)

Copyright (c) 2014 http://eddierangel.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.