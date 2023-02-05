

namespace ChallangeApp
{
    internal class Employee
    {
        private List<int> grades = new List<int>();
        public Employee(string name, string sureName, string age) 
        {
            this.Name = name;
            this.Surename = sureName;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surename { get;private set; }
        public string Age { get; private set;}
        public int Count
        {
            get
            {
                return grades.Sum();
            }
        }
        public void AddGrades(int nextGrades)
        {
            grades.Add(nextGrades);
        }
    }
}
