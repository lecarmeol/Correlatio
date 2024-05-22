# Correlatio
Versatile data fit application for lazy scientists

![App typical view](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/00_Fullview.png)

## Description
### Features
- Import data from file (csv, tab delimited)
- Generate data from a list of functions (with possibility to add randomness)
- Fit input data with functions defined in a list
- The list of functions is highly customizable. Data are stored in ListOfFunctions.xml in RICPFitter module

### Notes
- The app can handle XY data only (1D fit).

## Dev information
1. Based on .NET8
2. Use the old but use to handle Windows Form framework for UI

## Dependencies
1. RICPFitter as mathematic module (https://github.com/lecarmeol/RICPFitter)
2. ScottPlot lib for the data viz

## Installation
1. Go to the [release page](https://github.com/lecarmeol/Correlatio/releases/)
2. Download the last release, open the archive and run Correlatio.exe

## Use
1. In the "From file" panel, import your data (use \t for tab delimited column)

![Import data](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/01_Import_data.png)

2. Alternatively your can generate data for test purpose in the "From function" panel :

![Generate data](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/01b_Generate_data.png)

    2.1 Choose your input function
    2.2 Edit "Parameters" collection to set the desired equation
    2.3 Add randomness if wished
    2.4 Choose the start and end value and the number of points
    2.5 Click on "Generate"
3. Configure fitting parameters :

![Fit configuration](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/02_Fit_configuration.png)   
   
    3.1 Choose your fit function (if not found read further to learn hiw to add your own functions)
    3.2 Edit the initial guess

![Edit initial guess](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/03_Edit_initial_guesses.png)   
   
    3.3 Click on "Do fit"
4. Read and export fit result:

    4.1 Fitted coefficients are visible in Fit configuration --> 1) General --> Parameters collection

 ![Check result](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/04_Check_fit_result.png)     
   
    4.2 The coefficient of determination (R²) is in the "3) Fit" section
    4.3 Data can be exported in the "Export" panel

![Export result](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/05_Export_data.png)   
   
    4.4 Graph can also be exported by right-clicking on it and choosing "Save image" or "Show/Hide export panel" to get size options

![Export graph](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/06_Export_graph.png)   

### Adding custom functions to the app

All functions used by the App are described in the file ListOfFunctions.xml located in the App directory (or in the RICPFitter source code for Dev).

![ListOfFunctions content](https://github.com/lecarmeol/Correlatio/blob/main/dev/graphics/XML%20with%20functions.png)

To add a function, a new "Function" tag must be added. It must contain the above information :
1. A name as attribute
2. An "Equation" tag written as C# code. All mathematical operations available are those present in the [Math library of .NET 8](https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-8.0)
3. A "Variable" tag as written in the equation
4. A series of "Parameter" tags as written in the equation. They can have 2 attributes "description" as long name of the parameter and "defaultValue". WARNING : the maximum number of parameters is 5 !
