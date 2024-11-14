
using _07_OOP_Sealed;

Kitap kitap = new Kitap();
kitap.ISBNNo = "234234234";
kitap.KitapTuru = "Roman";
kitap.CreatedDate = DateTime.Now;
kitap.Id = 4;
kitap.KitapAdi = "Sırlarımız Kadar Hastayız";
kitap.YazarAdi = "Bülent Demircioğlu";
kitap.GetLog();
kitap.GetUser();


//BaseKitap baseKitap = new BaseKitap();
//baseKitap.CreatedDate = DateTime.Now;
//baseKitap.DeletedDate = DateTime.Now;
//baseKitap.Id = 10;

//YeniKitap yeniKitap = new YeniKitap();
//yeniKitap.ISBNNo = "234234234";
//yeniKitap.KitapTuru = "Roman";
//yeniKitap.CreatedDate = DateTime.Now;
//yeniKitap.Id = 4;
//yeniKitap.KitapAdi = "Sırlarımız Kadar Hastayız";
//yeniKitap.YazarAdi = "Bülent Demircioğlu";
//yeniKitap.GetLog();
//yeniKitap.GetUser();

