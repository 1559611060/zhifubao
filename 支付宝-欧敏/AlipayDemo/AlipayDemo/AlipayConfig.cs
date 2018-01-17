using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlipayDemo
{
    public class AlipayConfig
    {
        //APPID
        public static string APPID = "2016082600315560";
        //网关
        public static string gateURL = "https://openapi.alipaydev.com/gateway.do";

        //解压“支付宝秘钥生成器”->运行->选择"PKCS1(非java适用,2048)"->生成密钥->复制“RSA密钥：应用公钥2048”里的--》沙箱应用:设置应用公钥
        //私有密钥
        public static string private_Key = "MIIEpQIBAAKCAQEAvbeGyZ3NFuGlFhHbrGa7BPRwYDhpCW2nWkOurmiQA790hl+XuPqCIXt/Odqfe5uiDdLWILJF++Br8V0tJzqPGX5GMmQbMvv2GNhKRzXITH6hNccS1Y7Ys6haxqVJWP+7r6HlWQmntlS0aEssfaPkLrD366kfZXNZjdVIkIbyOtEPuoppka3oGIFZC0Ns1zmr44bmE46rd48Nfoz1h64BssBL0IF0EnrdJDsRz/6ttxj7kKJA4JFxBuAPrBhhpI6WS1zg+DNErENeGiSw6FpR15ntoMb8jCjBW7b2n9z3eaheyWcZHFzxb0opyhATd8ByRrNp5LqMrWiS6fMbUMoyPwIDAQABAoIBAQCJy7Bh5nTdJr2SnxvwR5mVCrpImRBpobSJElnhId9gaYIIS4xW9dTo3ttUuR9XV35IDhgrHXFJdgLRB71RHe5sNNRlq2I6ENn5x7eDq2O1c9BB0Ds01BE/xItSdyEkPHMlKTD9D8851qJGkjtZcl29MBqSl39PX43vP7f6CZoM7yYICoyC7wiqxOX/pkwwmIiM6wAnPbqyxtjqlkpXX5lX71x3raRPiGUfkx2P1tKjd4aRKZiJHawfEWtjT94tA7OR1Z7CN0T0Mm7LPcipAS1zu0HMT7W4Yozs2JdZsUo/w+cgPPLOBcV69svnq78kgafRZRtNnjrnGauxgghZx6EZAoGBAOEkp0ij/5jO4KwZTK1iiE2GBZ1r5nJGxRVsXtyCsNT/OPYbeUAH+j31PtXfDVWZWSeDiadzsDnSHMgkmKDknQDRdt+SuizT+bCecufptTVEVZ/e8scvc3XJUdZrMHQkdjYPch6I+b4W3peXIlKKox19YsxLl81MdslGSqxPnSVLAoGBANe36TPtLCROsNJaE2GkU97hvh1KXWur58q59+dUBmIidSkFVLjZyix4W0jsi/y0QhsR4FSdZ5htIetv7PvP4SU9L0yvNg4TatEzUxFR2BZsW7eEwjJ9YNj62DF5HeHjoIh8qx3ZtofTNcfZBUMUKmSIc2cDOFUMNz2hwW52YTJdAoGBAI4dLNrVaklyjK8VaSkowRDuQC0WJuiLc2wKc/aNKEHKuJHg1bBtWLAzVe56VVhq67Pde86PX/WfgztynkUxCUmy7m5Bl/Mj+sBZw/5Pr2poMAQyHt1MPn1jDp1iG7u0KEoHhelwXPR4Sxk09R1VFZFPzEVYkgGs+m4iSJBr0K3xAoGAAVYcVbwEZ/0sz0DLmfFAq8LOQLQzO/WGrBTW2lIE8BqyixyDV9nRjND6D8uXWmtrdWt47k1DVQhoC2NYHn89L9PfNSRou1GXedBNlW/iXNEzCEIESffI388+A6BydPHKDs5m6PpuTQ0b6i8H/1BiqtjFjj/Q24YF2ZXk8uA83ekCgYEAk//nuEfenZ1J3sNIhLC3fgeK4VMmMTPgEVGxk56C0RvDvE7Ufd2aAH1I1YAK7/MN0EoIYjLU0hidYu9jh9vy/tZxmyGNBNT9t+4Rk282gDqYDGt41xQLE8p7FxBY4YTqbE51xdedkh/0txegeWGfbsyjGz/uVsOPYO20f6hLmkI=";
        //公有密钥
        public static string public_Key = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvbeGyZ3NFuGlFhHbrGa7BPRwYDhpCW2nWkOurmiQA790hl+XuPqCIXt/Odqfe5uiDdLWILJF++Br8V0tJzqPGX5GMmQbMvv2GNhKRzXITH6hNccS1Y7Ys6haxqVJWP+7r6HlWQmntlS0aEssfaPkLrD366kfZXNZjdVIkIbyOtEPuoppka3oGIFZC0Ns1zmr44bmE46rd48Nfoz1h64BssBL0IF0EnrdJDsRz/6ttxj7kKJA4JFxBuAPrBhhpI6WS1zg+DNErENeGiSw6FpR15ntoMb8jCjBW7b2n9z3eaheyWcZHFzxb0opyhATd8ByRrNp5LqMrWiS6fMbUMoyPwIDAQAB";

        //签名方式
        public static string sign_Type = "RSA2";
        //编码格式
        public static string charset = "UTF-8";

    }
}