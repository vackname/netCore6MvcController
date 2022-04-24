using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace testMVC.DBFormat
{
	/// <summary>
    /// 會員基本資料
    /// </summary>
	public class tblMember
	{
		[JsonPropertyName("ac")]
		public string Account { set; get; }

		public string uid { set; get; }

		/// <summary>
		/// 匿稱
		/// </summary>
        [JsonPropertyName("n")]
		public string Name { set; get; }

		[JsonPropertyName("pass")]
		public string Password { set; get; }

		/// <summary>
        /// 最近登入時間
        /// </summary>
        [JsonIgnore]
		public DateTime LoginDateTime { set; get; }

		[JsonExtensionData]
		public Dictionary<string, object> extends { set; get; } = new Dictionary<string, object>();

	}
}

