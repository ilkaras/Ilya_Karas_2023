using Value;

namespace Open_Closed
{
    public class MagicClass
    {
        public MagicValue CountYourMagic(int magic)
        {
            if (magic == 150)
            {
                return new MagicValue
                {
                    AmmounPower = magic, Magic = "Fire Wizzzzzard!!!"
                };
            }

            if (magic == 50000000)
            {

                return new MagicValue { AmmounPower = magic, Magic = "Fire Ice Wizzard!!!" };

            }

            return new MagicValue { AmmounPower=magic, Magic="And I didn`t know who are you! ahahah" };
        }
    }
}