
using a=Animal.Models;
class Program
{

    static void Main(string[] args)
    {
        a.animal myAnimal = new a.animal("chien");
        a.animal myAnimal2 = new a.animal("chat");
        myAnimal.sleep();
        myAnimal2.sleep();
        myAnimal.move();
        myAnimal2.move();


    }


}
    

   
