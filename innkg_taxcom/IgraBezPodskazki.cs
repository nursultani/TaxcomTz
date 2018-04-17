using System;


namespace innkg_taxcom
{
    public class IgraBezPodskazki : ZapuskIgry
    {
        public ResultatIgry Run(int nomerDveri)
        {
            Random random = Main.m_Random;
            int DverMashinoy = random.Next(0, nomerDveri);
            int DverViborIgrok = random.Next(0, nomerDveri);
            int DverViborVedushiy = random.Next(0, nomerDveri - 1);

            if (DverMashinoy == DverViborIgrok)
            {
                return ResultatIgry.Kozel;
            }
            else
            {

                if (DverMashinoy < DverViborIgrok && DverMashinoy != DverViborVedushiy ||
                    DverMashinoy > DverViborIgrok && DverMashinoy != DverViborVedushiy + 1)
                {
                    return ResultatIgry.Otkaz;
                }
                else
                {
                    return ResultatIgry.Mashina;
                }
            }
        }
    }
}
