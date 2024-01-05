namespace SwordDamage
{
    public class CalSwordDamage
    {

        //fields
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;
        //fields
        private int roll;
        private bool flaming;
        private bool magic;
        public decimal MagicMultiplier = 1M;
        public int FlamingDamage = 0;
        //auto implemented property that contains calculated damage
        //has a public get accessor and a private set accessor.
        public int Damage { get; private set; }

        //properties
        //sets and gets 3d6 roll.
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        //Calculatedamage method, where all the flaming and magic damage
        //calculations are being done.
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
        //if the sword is magic, set to true, otherwise false.
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }




        //if the sword is flaming set to true, otherwise false.
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        //a constructor.
        //it calculates damage based on default magic and flaming values
        //and a starting 3d6 roll.
        public CalSwordDamage(int startingRoll /*this is called a parameter*/)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
