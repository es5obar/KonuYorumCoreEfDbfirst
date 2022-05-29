namespace KonuYorumCoreEfDbfirst.Models
{
    public class KonuYorumInnerJoinModel // KonuYorumInnerJoinDTO, DTO: Data Transfer Object
    {
        #region Konu entity'sinden gelen özellikler
        //public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        #endregion

        #region Yorum entity'sinden gelen özellikler
        //public int Id { get; set; }
        public string Icerik { get; set; }
        public string Yorumcu { get; set; }
        public int? Puan { get; set; }
        //public int KonuId { get; set; }
        #endregion

        #region Sayfanın ihtiyacına göre oluşturulan özellikler
        public string PuanDurumu { get; set; }
        #endregion
    }
}
