using System.Drawing;

namespace Gestion.Colegial.Business.Helpers
{
    public class Variable
    {
        private static Color _primary = Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));

        public static Color Primary
        {
            get { return _primary; }
        }
    }
}