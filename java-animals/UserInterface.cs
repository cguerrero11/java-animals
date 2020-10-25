using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace java_animals
{
    class UserInterface
    {

        ArrayList zoo = new ArrayList();
        String input = "E";
        
        public void showInterface()
        {
            int miceKilled = 0;
            bool friendly = true;
            int age = 18;
            String names;
            bool loop = false;

            while (input == "E") {
                Console.WriteLine("What type of creature do you want to create?");
                Console.WriteLine("A) Teacher \nB) Dog\nC) Cat");
                input = Console.ReadLine();
                input = input.ToUpper();

                input = (input == "A") ? input = "Teacher" : (input == "B") ? input = "Dog" : (input == "C") ? input = "Cat" : error();
            }
            Console.WriteLine("What is the name of the " + input + "?");
            names = Console.ReadLine();

            if (input == "Teacher")
            {
                while (loop == false)
                {
                    Console.WriteLine("How old is " + names + "?");
                    input = Console.ReadLine();
                    try
                    {
                        age = Int32.Parse(input);
                        loop = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That is not a number!");
                        loop = false;

                    }
                    

                }
                addTeacher(age, names);

            } else if (input == "Dog")
            {
                while (loop == false)
                {
                    Console.WriteLine("Is " + names + " freindly? (Y/N)");
                    input = Console.ReadLine().ToUpper();

                    if (input == "Y")
                    {
                        friendly = true;
                        loop = true;
                    }
                    else if (input == "N")
                    {
                        friendly = false;
                        loop = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either Y for yes or N for no.");
                        loop = false;
                    }
                }
                addDog(friendly, names);

            } else if (input == "Cat")
            {
                while (loop == false) {
                    Console.WriteLine("How many mice has " + names + " killed?");
                    input = Console.ReadLine();
                    try
                    {
                        miceKilled = Int32.Parse(input);
                        loop = true;
                    } catch (Exception e)
                    {
                        Console.WriteLine("That is not a number!");
                        loop = false;
                        
                    }
                    
                }
                addCat(miceKilled, names);
            }
            
        }

        private String error()
        {
            Console.WriteLine("You did not provide the correct input.");
            return "E";
        }

        private void addTeacher(int age, String name)
        {
            zoo.Add(new Teacher(age, name));
            Console.WriteLine(name + " the Teacher added");
        }
        private void addDog(Boolean friendly, String name)
        {
            zoo.Add(new Dog(friendly, name));
            Console.WriteLine(name + " the Dog added");
        }
        private void addCat(int miceKilled, String name)
        {
            zoo.Add(new Cat(miceKilled, name));
            Console.WriteLine(name + " the Cat added");
        }
    }
}
