namespace Training
{
    internal partial class Program
    {
        class Animal 
        {
            public string Category{ get; private set; }
            public string Name{ get; private set; }
            public string Alimentation { get; private set; }

            public Animal(string category, string name, string alimentation)
            {
                Category = category;
                Name = name;
                Alimentation = alimentation;
            }
        }
    }
}
