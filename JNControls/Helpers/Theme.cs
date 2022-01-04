using System.Drawing;

namespace JNControls.Helpers
{
    public static class Theme
    {
        static private Color primary = Color.FromArgb(85, 85, 170);
        static private Color lightPrimary = Color.FromArgb(229, 231, 236);
        static private Color primaryHover;
        static private Color secundary = Color.FromArgb(247, 164, 0);
        static private Color lightsecundary;
        static private Color secundaryHover;

        public static Color Primary { get => primary; set => primary = value; }
        public static Color LightPrimary { get => lightPrimary; set => lightPrimary = value; }
        public static Color PrimaryHover { get => primaryHover; set => primaryHover = value; }
        public static Color Secundary { get => secundary; set => secundary = value; }
        public static Color Lightsecundary { get => lightsecundary; set => lightsecundary = value; }
        public static Color SecundaryHover { get => secundaryHover; set => secundaryHover = value; }
        //Font font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

    }
}
