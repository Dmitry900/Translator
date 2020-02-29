using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace translator
{
    class StaticTables
    {
        List<string> lexems;

        
        public StaticTables(string file)
        {
            lexems = new List<string>();
            using (StreamReader sr = new StreamReader(file))
            { 
                while (!sr.EndOfStream)
                    this.Add(sr.ReadLine());     
            }
            lexems.Sort();
        }
        void Add(string element)
        {
            if (!lexems.Contains(element))
            {
                lexems.Add(element);
            }
        }
        public string GetName(int num)

        {
            if((num -1 <= lexems.Count)&&(num-1 >= 0))
                return lexems[num-1];
            return null;
        }
        public int GetNumber(string name)
        {
            if (lexems.Contains(name))
                return lexems.IndexOf(name)+1;
            
            return 0;
        }
    }
}
