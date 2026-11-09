using System;
using System.Drawing;
using System.IO;

namespace Cafeshka.Properties
{
    internal static class Resources
    {
        private const string Prefix = "Cafeshka.Assets.";
        private static readonly Lazy<Bitmap> Button = new Lazy<Bitmap>(() =>
        {
            using (Stream stream = typeof(Resources).Assembly.GetManifestResourceStream(Prefix + "buttonOrder.png")
                   ?? throw new InvalidOperationException("Не найдено изображение кнопки заказа"))
            using (Bitmap image = new Bitmap(stream))
                return new Bitmap(image);
        });

        private static readonly Lazy<Icon> FormIcon = new Lazy<Icon>(() =>
        {
            using (Stream stream = typeof(Resources).Assembly.GetManifestResourceStream(Prefix + "FormCafe.ico")
                   ?? throw new InvalidOperationException("Не найден значок формы"))
                return new Icon(stream);
        });

        internal static Bitmap OrderButton => Button.Value;
        internal static Icon FormCafeIcon => FormIcon.Value;
    }
}
