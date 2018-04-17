using System;
using System.Windows.Forms;

namespace innkg_taxcom
{
    
    public partial class Main : Form
    {
        public static Random m_Random = new Random(DateTime.Now.Millisecond);
        public Main()
        {
            InitializeComponent();
            this.txtiter.Text = "1000";
        }

        private void ZapuskIteratsii(int nomerDveri, int kolIter, ZapuskIgry runner,
           TextBox res)
        {

            int kolVigrysh = 0;
            int kolProigrysh = 0;
            for (int index = 0; index < kolIter; index++)
            {
                switch (runner.Run(nomerDveri))
                {
                    case ResultatIgry.Mashina:
                        ++kolVigrysh;
                        break;
                    case ResultatIgry.Otkaz:
                        // Retry
                        ++kolProigrysh;
                        --index;
                        break;
                }
            }

            res.Text = string.Format(Convert.ToString(kolVigrysh), kolProigrysh);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {//kolichestvo dverey
                int nomerDveri = 3;
                int kolIter = int.Parse(this.txtiter.Text);

                ZapuskIteratsii(nomerDveri, kolIter, new IgraSPodskazkoy(), this.txtresult1);
                ZapuskIteratsii(nomerDveri, kolIter, new IgraBezPodskazki(), this.txtresult2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
