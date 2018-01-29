namespace PosProject_psi
{
    public class SellItem
    {
        private string sellbarcode;

        public string Sellbarcode
        {
            get { return sellbarcode; }
            set { sellbarcode = value; }
        }

        private string selldate;

        public string Selldate
        {
            get { return selldate; }
            set { selldate = value; }
        }

        private string sellPaySel;

        public string SellPaySel
        {
            get { return sellPaySel; }
            set { sellPaySel = value; }
        }

        private int sellPayTot;

        public int SellPayTot
        {
            get { return sellPayTot; }
            set { sellPayTot = value; }
        }

        public SellItem()
        {
        }
    }
}