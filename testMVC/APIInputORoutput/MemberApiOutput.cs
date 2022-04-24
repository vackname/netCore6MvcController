using System;
using testMVC.DBFormat;

namespace testMVC.APIInputORoutput
{
	/// <summary>
    /// Member api
    /// </summary>
	public class MemberApiOutput:tblMember
	{
		/// <summary>
        /// 登入時間
        /// </summary>
		public string LoginDateTimeStr { get {
				return LoginDateTime.ToString("yyyyMMddHHmmssfff");
			} }
	}
}

