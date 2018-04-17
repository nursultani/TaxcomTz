using System;

namespace innkg_taxcom
{
    public class IgraSPodskazkoy : ZapuskIgry
    {
        public ResultatIgry Run(int nomerDveri)
        {
            Random random = Main.m_Random;
            int DverMashinoy = random.Next(0, nomerDveri);
            int DverViborIgrok = random.Next(0, nomerDveri);

            if (DverMashinoy == DverViborIgrok)
            {            
                return ResultatIgry.Kozel;
            }
            else
            {
                return ResultatIgry.Mashina;
            }
        }
    }
}
