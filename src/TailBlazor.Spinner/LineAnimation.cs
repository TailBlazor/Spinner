using System.ComponentModel;

namespace TailBlazor.Spinner {
    public enum LineAnimation {
        
        [Description("linear")]
        Linear,

        [Description("ease")]
        Ease,

        [Description("ease-in")]
        EaseIn,

        [Description("ease-out")]
        EaseOut,

        [Description("ease-in-out")]
        EaseInOut
    }
}
