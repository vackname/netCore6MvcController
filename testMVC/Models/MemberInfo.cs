using System;
using testMVC.APIInputORoutput;
using testMVC.Confing;
using testMVC.DBFormat;

namespace testMVC.Models
{
	public class MemberInfo
	{

		public object MBAddress()
		{
			try
			{
				var mb = new List<MemberApiOutput>() {
				new MemberApiOutput(){
					uid="aaa",
					Account="aaaAcount",
					LoginDateTime = DateTime.Now
				}
			};

				mb.Add(new MemberApiOutput()
				{
					uid = "bbb",
					Account = "bbbAcount",
					LoginDateTime = DateTime.Now
				});


				var address = new List<tblAddress>() {
				new tblAddress() {
					uid="aaa",
					Address="西安"
				}
			};

				var fun = ddFunc(func: (str, nu) =>
				{
					int aa = 1 + 1000;
					return $"hihi{str}{aa}";
				},
				aFun: str => { 
					mb.Where(n => n.uid == "aaa").First().Name = str;
				});

				return API.Ok(data: new
				{
					mb,
					AddressInfo = mb.Join(address, a => a.uid, b => b.uid, (a, b) => b)
					.ToList(),
					fun= fun
				});
			}
			catch
			{
				return API.Fail(Mes: "未知錯！");
			}
		}

		public object ddFunc(Func<string,int,object> func,Action<string> aFun)
		{
			aFun("HI");
			return func("我", 1);
		}
	}
}
