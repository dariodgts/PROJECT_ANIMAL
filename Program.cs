using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ANIMAL
{
    public class TestPersona
    {


       
            public class ANIMALES
        {
            public string cat="onix y artenisa";
            public   static void Catt(string eats="miningo")
            {
            
               Console.WriteLine(eats) ;
            
            }

            public static object FarmAnimalll(Pet pet, ANIMALES human)
            {
                throw new NotImplementedException();
            }

            public abstract class FarmAnimal
            {
                protected FarmAnimal(string name)
                {
                    Name = name;
                }

                public int Id { get; set; }
                public string Name { get; set; }
                public abstract string Species { get; }

                public Food? stringFood { get; set; }

                public class Food
                {
                }
            }

            public abstract class Pet : FarmAnimal
            {
                protected Pet(string name)
                    : base(name)
                {
                }

                public string? Vet { get; set; }

                public ICollection<Human> Humans { get; } = new List<Human>();
            }

            public class FarmAnimall : FarmAnimal
            {
                public FarmAnimall(string name, string species)
                    : base(name)
                {
                    Species = species;
                }

                public override string Species { get; }

                [Precision(18, 2)]
                public decimal Value { get; set; }
                public string? StrigFood { get; private set; }

                public override string ToString()
                    => $"Farm animal '{Name}' ({Species}/{Id}) worth {Value:C} eats {StrigFood?.ToString() ?? "<Unknown>"}";
            }

            public class Cat : Pet
            {
                private string? strigFood;

                public Cat(string name, string educationLevel)
                    : base(name)
                {
                    EducationLevel = educationLevel;
                }

                public string EducationLevel { get; set; }
                public override string Species => "Felis catus";

                public override string ToString()
                {
                    return $"Cat '{Name}' ({Species}/{Id}) with education '{EducationLevel}' eats {strigFood?.ToString() ?? "<Unknown>"}";
                }
            }

            public class Dog : Pet
            {
                public Dog(string name, string favoriteToy)
                    : base(name)
                {
                    FavoriteToy = favoriteToy;
                }

                public string FavoriteToy { get; set; }
                public override string Species => "Canis familiaris";

                public string? StingsFood { get; private set; }

                public override string ToString()
                    => $"Dog '{Name}' ({Species}/{Id}) with favorite toy '{FavoriteToy}' eats {StingsFood?.ToString() ?? "<Unknown>"}";
            }

            public class Human : FarmAnimal
            {
                public Human(string name)
                    : base(name)
                {
                }

                public override string Species => "Homo sapiens";

                public FarmAnimal? FavoriteAnimal { get; set; }
                public ICollection<Pet> Pets { get; } = new List<Pet>();

                public override string ToString()
                {
                    return $"Human '{Name}' ({Species}/{Id}) with favorite animal '{FavoriteAnimal?.Name ?? "<Unknown>"}'" +
                                   $" eats {stringFood?.ToString() ?? "<Unknown>"}";
                }
            }
public class PrecisionAttribute : Attribute
        {
            private int v1=1000;
            private int v2=3000;

            public PrecisionAttribute(int v1, int v2)
            {
                this.v1 = v1;
                this.v2 = v2;
                
            }
            public int GETV1(){
                return v1;
            }
            public int  GETV2(){
                return v2;
            }
        }

             public static void Main(string[] args)
        {
            ANIMALES FarmAnimalll = new ANIMALES();
         Cat a = new ANIMALES.Cat("MININGO","AFRODITA");
         Human b= new ANIMALES.Human(" ");
         Dog c= new ANIMALES.Dog("","");
         Console.WriteLine();
         PrecisionAttribute d = new PrecisionAttribute(1000,2000);
         FarmAnimall e= new FarmAnimall("", "");
         Console.WriteLine("{0} ghghhghjhkhkhjk       {1}",d.GETV1(), d.GETV2());
         Console.WriteLine();
         Console.WriteLine(FarmAnimalll.ToString());     
         Console.WriteLine();
         Console.WriteLine(a.ToString());
         Console.WriteLine(a.Species);
         Console.WriteLine(a.Name);
            Console.WriteLine(a.EducationLevel);
            Console.WriteLine(FarmAnimalll.cat);
            Console.WriteLine();
            Console.WriteLine(c.ToString());
         Console.WriteLine(c.Species);
         Console.WriteLine();
         Console.WriteLine(b.ToString());
            Console.WriteLine(b.Species);
            Console.WriteLine();
            Console.WriteLine(e.ToString());
           
            
        }
        }

        






    }
    }
