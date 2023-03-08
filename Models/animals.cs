namespace Animal.Models
{
    class animal
    {
        string Name;

        public void move()
        {
            Console.WriteLine("l'animal se met a bougé");
        }
        public void sleep()
        {
            Console.WriteLine("il fait dodo");
        }
        public animal() 
        {
            this.Name = "bagera";
        }
        public animal(string name)
        {
            this.Name = name;
        }
    }


}