

namespace ChallangeApp
{
    internal class User
    {
        private List<int> scores = new List<int>();
        public User(string name, string sureName)
        {
            this.Name = name;
            this.Surename = sureName;

        }
        public string Name { get; private set; }
        public string Surename { get; private set; }
        public int Score
        {
            get
            {
                return scores.Sum();
            }

        }
        public void AddScore(int nextNumber)
        {
            this.scores.Add(nextNumber);
        }
    }
}

