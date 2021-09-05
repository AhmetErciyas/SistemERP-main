using System;
using System.ComponentModel;

namespace ERP.Core
{
    
    public enum EnmbankaHesapTur
    {
    }
    
    public enum EnmfirmaTur
    {
        [Description("Tedarikçi")]
        Tedarikci = 1,

        [Description("Potansiyel")]
        Potansiyel = 2
    }
    
    public enum EnmeFaturaTur
    {
        [Description("Temel")]
        Temel = 1,

        [Description("Ticari")]
        Ticari = 2,

        [Description("HKS")]
        Hks = 3,

        [Description("İhracat")]
        Ihracat = 4,

        [Description("Yolcu Beraber")]
        YolcuBeraber = 5
    }
    
    public enum EnmnakliyeTur
    {
        [Description("Cost and Freight")]
        CostAndFreight = 1,

        [Description("Cost Insurance and Freight")]
        CostInsuranceAndFreight = 2,

        [Description("Navlun ve Sigorta Ödenmiş")]
        NavlunVeSigortaOdenmis = 3,

        [Description("Navlun Ödenmiş")]
        NavlunOdenmis = 4,

        [Description("Delivered at Frontier")]
        DeliveredAtFrontier = 5,

        [Description("Gümrük Vergileri Ödenmiş")]
        GumrukVergileriOdenmis = 6,

        [Description("Delivered Duty Unpaid")]
        DeliveredDutyUnpaid = 7,

        [Description("Delivered ex Quay")]
        DeliveredExQuay = 8,

        [Description("Delivered ex Ship")]
        DeliveredExShip = 9,

        [Description("Fabrika Teslim")]
        FabrikaTeslim = 10,

        [Description("Free Along Ship")]
        FreeAlongShip = 11,

        [Description("Taşıma Vasıtasının Yanında Teslim")]
        TasimaVasitasininYanindaTeslim = 12,

        [Description("Free on Board")]
        FreeOnBoard = 13,

        [Description("Pickup at Location")]
        PickupAtLocation = 14,

        [Description("Terminalde Teslim")]
        TerminaldeTeslim = 15,

        [Description("Belirtilen Noktada Teslim")]
        BelirtilenNoktadaTeslim = 16,

        [Description("Mal Mukabili Ödeme")]
        MalMukabiliOdeme = 17
    }
    
    public enum EnmsozlesmeTur
    {
        [Description("Belirli Süreli")]
        BelirliSureli = 1,

        [Description("Belirsiz Süreli")]
        BelirsizSureli = 2,

        [Description("Ksımi Zamanlı")]
        KsimiZamanli = 3
    }
}
