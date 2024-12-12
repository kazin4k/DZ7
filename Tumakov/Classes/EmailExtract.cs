using System;

namespace Tumakov.Classes
{
    public class EmailExtractor
    {
        public void SearchMail(ref string s)
        {
            string[] parts = s.Split('#');
            if (parts.Length > 1)
            {
                s = parts[1].Trim();
            }
            else
            {
                s = string.Empty;
            }
        }
    }
}
