using System;
using System.Drawing;
using System.IO;

namespace AreaOfSquare.Properties
{
    internal static class Resources
    {
        private const string Prefix = "AreaOfSquare.Assets.";

        private static Bitmap LoadBitmap(string name)
        {
            using (Stream stream = typeof(Resources).Assembly.GetManifestResourceStream(Prefix + name)
                   ?? throw new InvalidOperationException("Ресурс не найден: " + name))
            using (Bitmap bitmap = new Bitmap(stream))
                return new Bitmap(bitmap);
        }

        private static Icon LoadIcon(string name)
        {
            using (Stream stream = typeof(Resources).Assembly.GetManifestResourceStream(Prefix + name)
                   ?? throw new InvalidOperationException("Ресурс не найден: " + name))
                return new Icon(stream);
        }

        private static readonly Lazy<Bitmap> Box = new Lazy<Bitmap>(() => LoadBitmap("box_orange_128.png"));
        private static readonly Lazy<Bitmap> Exit = new Lazy<Bitmap>(() => LoadBitmap("ExitDoor16np.png"));
        private static readonly Lazy<Bitmap> Info = new Lazy<Bitmap>(() => LoadBitmap("InfoRoundBlue16np.png"));
        private static readonly Lazy<Bitmap> NewDocument = new Lazy<Bitmap>(() => LoadBitmap("New_Blank_Document_16_n_p.png"));
        private static readonly Lazy<Bitmap> OpenDocument = new Lazy<Bitmap>(() => LoadBitmap("Open File or Folder 16 n p.png"));
        private static readonly Lazy<Bitmap> SaveDocument = new Lazy<Bitmap>(() => LoadBitmap("Save Blue 16 n p.png"));
        private static readonly Lazy<Bitmap> SuperScript = new Lazy<Bitmap>(() => LoadBitmap("Superscript.png"));
        private static readonly Lazy<Icon> FormIcon = new Lazy<Icon>(() => LoadIcon("FormAreaOfSquare.ico"));

        internal static Bitmap box_orange_128 => Box.Value;
        internal static Bitmap ExitDoor16np => Exit.Value;
        internal static Bitmap InfoRoundBlue16np => Info.Value;
        internal static Bitmap New_Blank_Document_16_n_p => NewDocument.Value;
        internal static Bitmap Open_File_or_Folder_16_n_p => OpenDocument.Value;
        internal static Bitmap Save_Blue_16_n_p => SaveDocument.Value;
        internal static Bitmap Superscript => SuperScript.Value;
        internal static Icon FormAreaOfSquareIcon => FormIcon.Value;
    }
}
