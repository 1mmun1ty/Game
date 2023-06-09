namespace ConsoleApp34
{
    class program
    {
        public class Enemy
        {
            public int Health { get; set; }
            public int Damage { get; set; }
            public int Level { get; set; }
            public int Experience { get; set; }

            public Enemy(int health, int damage, int level, int experience)
            {
                Health = health;
                Damage = damage;
                Level = level;
                Experience = experience;
            }
        }


        public class Hero
        {
            public int Health { get; set; }
            public int Damage { get; set; }
            public int Level { get; set; }
            public int Experience { get; set; }

            public Hero(int health, int damage, int level, int experience)
            {
                Health = health;
                Damage = damage;
                Level = level;
                Experience = experience;
            }
        }

        public class BlackEagle : Enemy
        {
            public BlackEagle() : base(50, 5, 1, 150)
            {
            }
        }

        public class People : Enemy
        {
            public People() : base(50, 10, 1, 200)
            {
            }
        }

        public class RoboSuck : Enemy
        {
            public RoboSuck() : base(65, 13, 2, 300)
            {
            }
        }

        var blackEagle = new BlackEagle();
        var people = new People();
        var roboSuck = new RoboSuck();
        var hero = new Hero(100, 15, 1, 0);

        static void Main(string[] args)
        {
            BranchingInTheStory branch = new BranchingInTheStory();

         
                Console.WriteLine("Однажды вы решили расследовать одно дело по пропаже мальчика \nВы решили зайти в полицейский участок и посмотреть ещё несколько дел похожих на это");
                Console.WriteLine("Зайдя в полицейский участок вы были удивлены, что никого нет на своих рабочих местах \nНо посмотрев на календарь, который висел на стене, было понятно, что сегодня воскресенье\n15 июля 2077 года... ");
                Console.WriteLine("Включить новости на телевизоре или нет \n (Y)es or (N)o\n");
                branch.News();

                Console.WriteLine("Приступив к просмотру дел вы практически ничего не понимали о записях и пометках по типу 'КиберПсихоз', но вскоре вы начали впитывать информацию как губку и было понятно, что здесь происходить что-то неладное ");
                Console.WriteLine("Пойти исследовать мир или остаться в офисе\n (Y)es or (N)o\n");
                branch.NewGame();

           
            
         
        }

      
    }
}