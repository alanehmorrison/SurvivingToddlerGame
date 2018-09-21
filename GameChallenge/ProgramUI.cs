using System;

namespace GameChallenge
{
    internal class ProgramUI
    {
        private HeroRepository _heroRepo = new HeroRepository();
        private EnemyRepository _enemyRepo = new EnemyRepository();

        public void Run()
        {
            SetUpGame();
            RunGame();
            EndGame();
        }

        private void EndGame()
        {
            throw new NotImplementedException();
        }

        private void SetUpGame()
        {
            CreateHero();
            CreateEnemy();
            ShowHeroDetails();
            ShowEnemyDetails();

        }

        private void ShowEnemyDetails()
        {
            Console.WriteLine("Here are the details for your toddler:\n");

            var enemy = _enemyRepo.CharacterDetails();

            Console.WriteLine($"Character Details:\n " +
                $"Name: {enemy.Name}\n" +
                $"Health: {enemy.Health}\n" +
                $"Attack: {enemy.AttackPower}\n");
            Console.Read();
        }

        private void ShowHeroDetails()
        {
            Console.WriteLine("Here are the details for you, Mom:");

            var hero = _heroRepo.CharacterDetails();

            Console.WriteLine($"Mom Details: \n" +
                $"Name: {hero.Name}\n" +
                $"Health: {hero.Health}\n" +
                $"Attack: {hero.AttackPower}\n");

            Console.Read();
        }

        private void CreateEnemy()
        {
            Console.WriteLine("Shrills come from the other and you drop what your\n" +
                "paper, panicked! Crap! It's time. Your toddler has awoken in the other\n" +
                "room. You rush to grab them from their bed. What is your toddlers name?\n");

            string name = Console.ReadLine();

            _enemyRepo.CreateCharacter(name);

            Console.Read();

        }

        private void CreateHero()
        {
            Console.WriteLine("What is thy Mom's name?");

            string name = Console.ReadLine();

            _heroRepo.CreateCharacter(name);

            Console.WriteLine($"Welcome to Surving Toddlers, {name}\n" +
                $"Let's see if you have what it takes to be a mom.\n " +
                $"We know what every good mom needs to make it through\n" +
                $"their day - WINE. You have 3 glasses of wine. It's simple.\n" +
                $"Do great things and gain wine. Mess up and cause stress\n" +
                $"to yourself and lose wine and/or health points. Let's see how you do.\n");

            Console.Read();
        }

        private void RunGame()
        {
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();

            while (hero.IsAlive && enemy.IsAlive)
            {
                //DO STUFF
                PromptPlayer();
            }
        }

        private void PromptPlayer()
        {
            Console.WriteLine("What would you like to do?:\n" +
                "1. Give the toddler a nap.\n" +
                "2. Take the toddler to the park.\n" +
                "3. Hide In the Pantry to eat your chocolate ice cream.\n" +
                "4. Arts and Crafts. "
                );
            var input = int.Parse(Console.ReadLine());

            HandleBattleInput(input);

            Console.Read();
        }

        private void HandleBattleInput(int input)
        {
            switch (input)
            {
                case 1:
                    Nap();
                    break;
                case 2:
                    Park();
                    break;
                case 3:
                    Pantry();
                    break;
                case 4:
                    ArtsCrafts();
                    break;
                default:
                    break;
            }
        }

        private void Toddlerout()
        {
            throw new NotImplementedException();
        }

        private void Nap()
        {
            //Get hero variable
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();

            Console.WriteLine($"You're trying to put {enemy.Name} down for a nap BUT\n" +
                $"they are refusing to lay down. You're getting worn out and \n" +
                $"{enemy.Name} is not budging. What do you do? \n" +
                $"1. Pat {enemy.Name} to sleep." +
                $"2. Turn on a lullaby and walk out." +
                $"3. Give {enemy.Name} a bottle and run.");
            var actions = int.Parse(Console.ReadLine());

            ToddlerNapInput(actions);

            _enemyRepo.TakeDamage(hero.AttackPower);

            Console.WriteLine($"{enemy.Name}'s health is: {enemy.Health}");
            Console.Read();
            //First the hero will strike

            //Then, decrement points from enemy

            //Print details

        }

        private void ToddlerNapInput(int actions)
        {
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();

            switch (actions)
            {

                case 1:
                    Console.WriteLine($"Congratulations you put {enemy.Name} to sleep! \n" +
                        $"You won 10 extra health points for yourself!");
                    _enemyRepo.TakeDamage(hero.AttackPower);
                    break;
                case 2:
                    Console.WriteLine($"Good try, {hero.Name}! We applaud your efforts." +
                        $"However, {enemy.Name} got out of bed as soon as you walked out." +
                        $"{enemy.Name} crapped their pants, rubbed the crap up the walls, " +
                        $"on themselves, and all over their crib. You came back in the room " +
                        $"to mudpies. You lost 10 health points exhaustively cleaning and " +
                        $"sanitizing your house. Next time, though, Mom.");
                    break;
                        
            }
        }

        private void Park()
        {
            throw new NotImplementedException();
        }

        private void Pantry()
        {
            throw new NotImplementedException();
        }

        private void ArtsCrafts()
        {
            throw new NotImplementedException();
        }
       
    }
}