namespace Bank.Models.DTOs
{
    public class TranFataDTos
    {
        public double money;
        public long NumberMabdaCard;
        public long NumberMaghsad;

        public TranFataDTos(double m, long NumManda, long NumMagh){
            this.money = m;
            this.NumberMabdaCard = NumManda;
            this.NumberMaghsad=NumMagh;
                 }

    }
}
