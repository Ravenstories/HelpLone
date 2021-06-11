using System;

namespace HelpLone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        // All classes posses these three abilities. So I believe that every future class will posses them as well
        
        public interface ICharacter // Wizard,  Barbarian,  Knight, Witch
        {
            void Heal();
            void Die(); 
            void Fight();
        }
        // I have decided to split Bash, Slash and Cleave. They could be grouped into one, but that would create a problem if a new class arrived that doesn't have all three.
        // I want to keep this as open as posible so if there is generated new classes it's easy to implement skills. Or to generate new interfaces later.
        
        // Offense
        public interface IBash { void Bash(); } // Barbarian,  Knight
        public interface ICleave { void Cleave(); } // Barbarian,  Knight
        public interface ISlash { void Slash(); } // Barbarian,  Knight

        //Defense
        public interface IRaiseShield { void RaiseShield(); } // Knight, Witch
        public interface IShieldGlare { void ShieldGlare(); } // Knight, Witch

        //Spells
        public interface ITeleport { void Teleport(int x, int y); } // Wizard, Witch
        public interface IThrowFrostNova { void ThrowFrostNova(); } // Wizard,
        public interface IThrowMagicMisile { void ThrowMagicMisile(); } // Wizard,



        public class Wizard : ICharacter, ITeleport, IThrowFrostNova, IThrowMagicMisile
        {
            public void Die()
            {
                Console.WriteLine("I'm dying");
            }

            public void Fight()
            {
                Console.WriteLine("I'm fighting");
            }

            public void Heal()
            {
                Console.WriteLine("I'm healing");
            }

            public void Teleport(int x, int y)
            {
                Console.WriteLine("I'm teleporting to " + x + " " + y);
            }

            public void ThrowFrostNova()
            {
                Console.WriteLine("I'm throwing my frost nova");
            }

            public void ThrowMagicMisile()
            {
                Console.WriteLine("I'm throwing a magic misile");
            }
        }

        public class Babarian : ICharacter, IBash, ISlash, ICleave
        {
            public void Bash()
            {
                Console.WriteLine("I'm bashing someone");
            }

            public void Cleave()
            {
                Console.WriteLine("I'm cleaving someone");
            }

            public void Die()
            {
                Console.WriteLine("I'm dying");
            }

            public void Fight()
            {
                Console.WriteLine("I'm fighting");
            }

            public void Heal()
            {
                Console.WriteLine("I'm healing");
            }

            public void Slash()
            {
                Console.WriteLine("I'm slashing someone");
            }
        }

        public class Knight : ICharacter, IBash, ICleave, ISlash, IRaiseShield, IShieldGlare
        {
            public void Bash()
            {
                Console.WriteLine("I'm bashing someone");
            }

            public void Cleave()
            {
                Console.WriteLine("I'm cleaving someone");
            }

            public void Die()
            {
                Console.WriteLine("I'm dying");
            }

            public void Fight()
            {
                Console.WriteLine("I'm fighting");
            }

            public void Heal()
            {
                Console.WriteLine("I'm healing");
            }

            public void RaiseShield()
            {
                Console.WriteLine("I'm raising my shield");
            }

            public void ShieldGlare()
            {
                Console.WriteLine("I'm throwing shield glare");
            }

            public void Slash()
            {
                Console.WriteLine("I'm slashing someone");
            }
            
        }

        public class Witch : ICharacter, IRaiseShield, IShieldGlare, ITeleport
        {
           
            public void Die()
            {
                Console.WriteLine("I'm dying");
            }

            public void Fight()
            {
                Console.WriteLine("I'm fighting");
            }

            public void Heal()
            {
                Console.WriteLine("I'm healing");
            }

            public void RaiseShield()
            {
                Console.WriteLine("I'm raising my shield");
            }

            public void ShieldGlare()
            {
                Console.WriteLine("I'm throwing shield glare");
            }

            public void Teleport(int x, int y)
            {
                Console.WriteLine("I'm teleporting to " + x + " " + y);
            }
           
        }

    }
}
