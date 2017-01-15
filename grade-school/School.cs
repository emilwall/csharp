using System.Collections.Generic;

namespace grade_school
{
    public class School
    {
        public School()
        {
        }

        public Dictionary<int, List<string>> Roster =
            new Dictionary<int, List<string>>();

        public void Add(string name, int grade)
        {
            // Not implemented
        }

        public List<string> Grade(int grade) => null; // Not implemented
    }
}
