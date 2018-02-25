using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lidya.Models
{
    public class Token
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
        public decimal UserId { get; set; }
  public decimal UserType { get; set; }
        public string  UserlistId { get; set; }
        public decimal CategoryImageId { get; set; }
        public decimal SupplierAdventage { get; set; }
        public decimal SupplierCommission { get; set; }

        public string TokenKey
        {
            get { return string.Format("{0}:{1}:{2}:{3}", Ip, UserName, Password, UserId); }
        }
        public string GenerateToken()
        {
            return Guid.NewGuid().ToString();
        }

        public string GetIPAddress()
        {
            string ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ip))
                ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            else
                ip = ip.Split(',')[0];

            return ip;
        }
    }

    public class TokenCollection : Dictionary<string, Token>
    {
        public bool GetTokenValue(string securityToken)
        {
            return this.ContainsKey(securityToken);
        }

        public Token GetToken(string securityToken)
        {
            foreach (var tk in this)
            {
                if (tk.Key == securityToken)
                {
                    return (Token)tk.Value;
                }
            }

            return null;
        }


    }
}
