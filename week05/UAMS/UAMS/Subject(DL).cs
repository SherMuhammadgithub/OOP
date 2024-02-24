using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class SubjectDL
    {
        public static List<Subjects> subjects = new List<Subjects>();
        public static void AddSubject(Subjects subject)
        {
            subjects.Add(subject);
        }
        public static void StoreInFile(string path, Subjects subject)
        {
            StreamWriter f = new StreamWriter(path, true);
            
            f.WriteLine(subject.code + "," + subject.name + "," + subject.creditHours + "," + subject.Fees);
            f.Flush();
            f.Close();
        }
        public static bool LoadSubjectData(string path)
        {
             StreamReader streamReader = new StreamReader(path);
            string line;
            if(File.Exists(path))
            {
                
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] data = line.Trim().Split(',');
                    int code = int.Parse(data[0]);
                    string name = data[1];
                    int creditHours = int.Parse(data[2]);
                    int fees = int.Parse(data[3]);
                    Subjects subject = new Subjects(code, creditHours, name, fees);
                    subjects.Add(subject);
                }
                streamReader.Close();
                return true;
            }
            return false;
          
        }
       public static Subjects IsSubjectExists(string subjectName)
        {
            foreach(var sub in subjects )
            {
                if(sub.name == subjectName)
                {
                    return sub;
                }
            }
            return null;
        }
    }
}
