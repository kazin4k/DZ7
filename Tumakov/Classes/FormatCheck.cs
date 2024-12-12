using System;

namespace Tumakov.Classes
{
    public class FormattableChecker
    {
        public static bool CheckIfIFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                return true;
            }
            IFormattable formattableObj = obj as IFormattable;
            return formattableObj != null;
        }
    }
}