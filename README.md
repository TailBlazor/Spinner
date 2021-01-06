# TailBlazor.Spinner

Blazor spinner using tailwindcss

super simple custom spinner designed to work with our TailBlazor component library

![Nuget](https://img.shields.io/nuget/v/TailBlazor.Spinner.svg)

![Demo](screenshot.gif)

## Getting Setup

You can install the package via the NuGet package manager just search for TailBlazor.Spinner. You can also install via powershell using the following command.

`Install-Package TailBlazor.Spinner`

Or via the dotnet CLI.

`dotnet add package TailBlazor.Spinner`

### 1. Add Imports

Add line to your \_Imports.razor

```
@using TailBlazor.Spinner
```

#### 4. Create your spinner

by default everything is already configured for a medium sized, gray spinner.

```
<TailBlazorSpinner />
```

#### 4. Customize styles

We give you tons of options to customize just about everything. The table below outlines the parameters you can set.

Parameter | Default Value
--- | ---
`Stroke` | `text-gray-500`
`StrokeWidth` | `2`
`Size` | `64`
`LineStyle` | `LineStyle.Round`
`Speed` | `2` (seconds)
`LimeAnimation` | `LineAnimation.Linear`

If you need even more customization, you can use `Stroke` to add even more classes. For example if you wanted the spinner to have a low opacity you could simply append `text-opacity-25` to the Stroke class.

```
<TailBlazorSpinner Stroke="text-gray-500 text-opacity-25" />
```