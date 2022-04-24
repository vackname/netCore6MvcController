using System;
namespace testMVC.Confing
{
    /// <summary>
    /// 錯誤代碼
    /// </summary>
    public enum errorCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        ok=1,
        /// <summary>
        /// 失敗
        /// </summary>
        Fail=0,
        /// <summary>
        /// 輸入錯誤
        /// </summary>
        errorInput = -1

    }

	public static class API
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">錯誤代碼</param>
        /// <param name="mes">Api資訊</param>
        /// <param name="data">輸出數據</param>
        /// <returns></returns>
        private static object Obj(errorCode code,String mes= "", object data = null)
        {
            Dictionary<string, object> output = new Dictionary<string, object>() {
                { "code",(int)code }
            };

            if (data == null)
            {
                output.Add("mes", mes);
            }
            else
            {
                output.Add("data", data);
            }

            return output;
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <param name="code">錯誤代碼</param>
        /// <param name="mes">Api資訊</param>
        /// <param name="data">輸出數據</param>
        /// <returns></returns>
        public static object Ok(errorCode code = errorCode.ok, String Mes = "", object data = null)
        => Obj(code, mes: Mes, data: data);

        /// <summary>
        /// 失敗
        /// </summary>
        /// <param name="code">錯誤代碼</param>
        /// <param name="mes">Api資訊</param>
        /// <param name="data">輸出數據</param>
        /// <returns></returns>
        public static object Fail(errorCode code = errorCode.Fail, String Mes = "", object data = null)
        => Obj(code, mes: Mes, data: data);
    }
}

