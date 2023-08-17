# Dangling Reference Removal Extension Library

[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

A C# extension library for automatically removing dangling references from Lists, Arrays, and Dictionaries.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Installation](#installation)
  - [Usage](#usage)
- [Examples](#examples)
- [Contributing](#contributing)
- [License](#license)

## Introduction

Dangling references are a common issue in programming, leading to memory leaks and unintended behavior. This C# extension library provides simple extensions for `List`, `Array`, and `Dictionary` collections, allowing you to automatically remove elements with dangling references.

## Features

- Removes elements with dangling references from Lists, Arrays, and Dictionaries.
- Provides customizable condition functions to determine if an element has a dangling reference.

## Getting Started

### Installation

1. Clone or download the repository.

```bash
git clone https://github.com/yourusername/dangling-reference-extension.git
```
Open the solution in your preferred C# development environment (e.g., Visual Studio, Visual Studio Code).
Usage

Include the DanglingReferenceExtensionLibrary namespace in your code:
```cs
using DanglingReferenceExtensionLibrary;
```
Utilize the provided extension methods on your collections:
```cs
// Remove dangling references from a List
List<T> myList = new List<T>();
myList.RemoveDanglingReferences(item => /* your condition here */);

// Remove dangling references from an Array
T[] myArray = new T[] { /* your array elements */ };
T[] filteredArray = myArray.RemoveDanglingReferences(item => /* your condition here */);

// Remove dangling references from a Dictionary
Dictionary<TKey, TValue> myDictionary = new Dictionary<TKey, TValue>();
myDictionary.RemoveDanglingReferences(item => /* your condition here */);

```
Examples
Here's an example of how you can use the library to remove dangling references from a List:
```cs
using System;
using System.Collections.Generic;
using DanglingReferenceExtensionLibrary;

class Program
{
    static void Main()
    {
        List<string> stringList = new List<string> { "foo", "bar", "baz", "qux" };
        stringList.RemoveDanglingReferences(item => item.StartsWith("b"));

        foreach (var item in stringList)
        {
            Console.WriteLine(item);
        }
    }
}
```
