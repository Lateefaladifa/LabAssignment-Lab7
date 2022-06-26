using System;

namespace Lab7
{
    abstract class Animal

    {
        public string name;
         public string age;
         public string gender;
        public abstract void animalSound();
        
        public void say()
        {
            Console.WriteLine("Different Type of Animal");
        }
        }
        class Dog : Animal{
            public override void animalSound(){
                Console.WriteLine("A dog barks"  +  "GbauGbauGbau...");
            }
        }

        class Frog : Animal{
            public override void animalSound(){
                Console.WriteLine("A frog makes" + "PonPonPon...");
            }
        }
        class Cat : Animal{
            public override void animalSound(){
                Console.WriteLine("A cat mewmew");
            }
        }
        class Kitten : Animal{
            public override void animalSound(){
                Console.WriteLine("A Kitten make shinshinshin sound");
            }
        }
        class Tomcat : Animal{
            public override void animalSound(){
                Console.WriteLine("A Tomcat make meeeeewmeeeeew sound");
            }
        }
        class Program
        {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
             dog.animalSound();
            dog.name = "Dog";                       
            dog.age = "3 months";
            dog.gender = "male";
            Console.WriteLine(dog.name);
            Console.WriteLine(dog.age);
            Console.WriteLine(dog.gender);

            Frog frog = new Frog();
            frog.animalSound();
            frog.name = "Frog";                       
            frog.age = "6 months old";
            frog.gender = "female";
            Console.WriteLine(frog.name);
            Console.WriteLine(frog.age);
            Console.WriteLine(frog.gender);

            Cat cat = new Cat();
            cat.animalSound();
            cat.name = "Cat";                       
            cat.age = "2 years old";
            cat.gender = "female";
            Console.WriteLine(cat.name);
            Console.WriteLine(cat.age);
            Console.WriteLine(cat.gender);
           
            Kitten kitten = new Kitten();
            kitten.animalSound();
            kitten.name = "Kitten";                       
            kitten.age = "9 months old";
            kitten.gender = "male";
            Console.WriteLine(kitten.name);
            Console.WriteLine(kitten.age);
            Console.WriteLine(kitten.gender);
            
            Tomcat tomcat = new Tomcat();
            tomcat.animalSound();
            tomcat.name = "Tomcat";                       
            tomcat.age = "5 weeks old";
            tomcat.gender = "male";
            Console.WriteLine(tomcat.name);
            Console.WriteLine(tomcat.age);
            Console.WriteLine(tomcat.gender);
            
           
        }
    }
}
