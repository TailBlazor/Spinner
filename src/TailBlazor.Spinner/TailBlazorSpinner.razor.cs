using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;


namespace TailBlazor.Spinner
{
    public partial class TailBlazorSpinner
    {
        [Parameter] public string Stroke { get; set; } = "text-gray-500";
        [Parameter] public int StrokeWidth { get; set; } = 4;
        [Parameter] public int Size { get; set; } = 64;
        [Parameter] public LineStyle LineStyle { get; set; } = LineStyle.Round;
        [Parameter] public int Speed { get; set; } = 2;
        [Parameter] public LineAnimation LineAnimation { get; set; } = LineAnimation.Linear;
    }
}
