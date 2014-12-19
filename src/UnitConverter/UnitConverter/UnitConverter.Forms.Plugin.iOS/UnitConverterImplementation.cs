using UnitConverter.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using UnitConverter.Forms.Plugin.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(UnitConverter.Forms.Plugin.Abstractions.UnitConverterControl), typeof(UnitConverterRenderer))]
namespace UnitConverter.Forms.Plugin.iOS
{
    /// <summary>
    /// UnitConverter Renderer
    /// </summary>
    public class UnitConverterRenderer //: TRender (replace with renderer type
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }
    }
}
