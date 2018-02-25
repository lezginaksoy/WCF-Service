using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidya.Models
{
    public class Enumarations
    {
        public enum ProductUnit : int
        {
            Kg = 0,
            Adet = 1,
            m = 2,
            Parsel = 3,
            Ton = 4,
            Varil = 5,
            Ons = 6,
            MW = 7,
            Karat = 8
        }

        public enum ProductFamily : int
        {
            GiyimveAyakkabi = 1,
            Mucevher = 2,
            Aksesuar = 3,
            Koku = 4,
            Ortu = 5,
            Saat = 6
        }
        
        public enum MediaEntityTypes : int
        {
            CategoryPicture = 1,
            ProductPicture = 2,
            ColorThumbPicture = 3,
            CampaignPicture = 4,
            StorePlatePicture = 5,
        }

        public enum CardName 
        {
            Banka_Kartı = 134,
            Bonus = 62,
            Maximum = 64,
            CardFinans = 111,       
          
        }
        public enum Sequence
        {
            SRYID,
            MDYID,
            ITMID,
            MDYQID,
            TCOLGRPID,
            NINT,
            INTSEQ,
            TMSGQID,
            CARTITMID,
            TICKETID,
            UIRID,
            GRYID
        };
    }
}