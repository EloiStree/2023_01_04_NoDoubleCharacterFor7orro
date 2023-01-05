using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZorroFiltering
{
        public class TestZorro 
    {

        public string m_fileImportPath="";
        public string m_fileExportPath="" ;

        public string m_listOfWordsAsText = "";

        List<string> m_wordsBeforeFilter = new List<string>();
        List<string> m_wordsAfterFilter = new List<string>();
        public string m_resultText="";

        public void ProcessWords()
        {
            m_listOfWordsAsText = File.ReadAllText(m_fileImportPath);

            m_wordsBeforeFilter.Clear();
            m_wordsAfterFilter.Clear();

            m_wordsBeforeFilter = m_listOfWordsAsText.Split("\n").ToList();
            foreach (var word in m_wordsBeforeFilter)
            {
                if (DicoSolution_HasDoubleCharInText(word)) { }
                else m_wordsAfterFilter.Add(word);

            }
            m_resultText = string.Join("\n", m_wordsAfterFilter);

            File.WriteAllText(m_fileExportPath, m_resultText);
        }


        public static bool DicoSolution_HasDoubleCharInText(string word)
        {
            // eloirroio
            // elroiro
            word = word.Trim();
            Dictionary<char, int> dico = new Dictionary<char, int>();
            foreach (char c in word.ToCharArray())
            {
                if (!dico.ContainsKey(c))
                    dico.Add(c, 1);
                else dico[c] += 1;

                if (dico[c] > 1)
                    return true;
            }
            return false;
        }
    


}
}
