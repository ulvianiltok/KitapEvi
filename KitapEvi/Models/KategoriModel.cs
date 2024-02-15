namespace KitapEvi.Models
{
    public class KategoriModel
    {
        public int KitapId {  get; set; }
        public string KitapName { get; set; }
        public string SayfaSayi { get; set; }
        List<KategoriModel>kitapListesi= new List<KategoriModel> { };
    }
}
