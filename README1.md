# Simple_shop

A simple C# application for parsing “tag” files and generating invoices for different customer types, each with unique pricing rules (VAT, discounts, etc.). This repository is split into two projects:

SimpleShop – Contains the main application (parsing logic, domain classes, main entry point).
SimpleShop.Test – Contains NUnit test suites to verify the correctness of the application.


## Overview
SimpleShop takes a “.tag” file as input, which contains order entries in a simple XML format. It then:
Parses and validates the data (e.g., checking for valid keyword sequences).
Creates InvoicePosition objects for each order.
Applies different rules based on the type of customer:
   -Company customers pay no VAT.
   -Student customers receive 20% discount before VAT.
   -Normal customers pay full VAT.
Prints invoices to the console (or another output stream) detailing item, quantity, and final price.
This project demonstrates basic data parsing, object-oriented design, and test-driven development with NUnit.

## Features
Keyword & KeywordPair
Encapsulates the idea of <Keyword> tags and their corresponding values.
ShopParser
Responsible for reading .tag-like data, extracting keywords, and validating them (checks for repetition, circular references, invalid inputs, etc.).
Customer & Inheritance
   Customer (base class) – Default rules (pays standard VAT).
   Company – Inherits Customer but pays no VAT.
   Student – Inherits Customer but receives 20% discount prior to VAT.
InvoicePosition
   Builds invoice line items from KeywordPair[].
   Calculates the final price, including or excluding VAT/discount.
Main Program (SimpleShop.cs)
   Reads a .tag file specified via arguments.
   Parses the data using ShopParser.
   Prints out invoice lines in the correct format.

##Technologies used
Framework: .NET 9.0
Language: C#
Platform: Console Application

##Testing
This project uses NUnit for unit testing.

1.Running Tests
From the solution root or the SimpleShop.Test folder, run:
dotnet test
This executes all tests found in SimpleShop.Test, including:
Keyword and KeywordPair tests
ShopParser logic tests
InvoicePosition creation and price calculation tests
Customer inheritance tests (e.g., Company, Student)
Additional checks in ToBeWritten.cs and WriteTestsHere.cs.

2.SampleOrder.tag
The included SampleOrder.tag file provides an example data set used in the tests.



##How to run
1.Open a terminal or command prompt in the SimpleShop project folder.
2.Run the following command (adjusting the path to point to your .csproj and .tag files):
dotnet run --project .\SimpleShop.csproj -- <path-to-SampleOrder.tag>
3.The program will parse the provided .tag file and then output the resulting invoice lines to the console.

Below is an example command and its output:
Command:
dotnet run --project .\SimpleShop.csproj -- .\SimpleShop.Test\SampleOrder.tag
Example Console Output:
James T. Kirk, Burger, 2, 19.04
James T. Kirk, Coke, 1, 2.98
S'chn T'gai Spock, IceCream, 7, 29.99





