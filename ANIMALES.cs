using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ANIMAL
{
    internal class ANIMALES
    {
        internal static string Catt()
        {
            throw new NotImplementedException();
        }

        internal static object FarmAnimalll(Pet pet, ANIMALES human)
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
    }

    internal class PrecisionAttribute : Attribute
    {
        private int v1;
        private int v2;

        public PrecisionAttribute(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
