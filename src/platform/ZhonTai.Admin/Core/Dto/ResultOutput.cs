﻿using Newtonsoft.Json;

namespace ZhonTai.Admin.Core.Dto
{
    /// <summary>
    /// 结果输出
    /// </summary>
    public class ResultOutput<T> : IResultOutput<T>
    {
        /// <summary>
        /// 是否成功标记
        /// </summary>
        [JsonIgnore]
        public bool Success { get; private set; }

        /// <summary>
        /// 状态码
        /// </summary>
        public int Code => Success ? 1 : 0;

        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; private set; }

        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; private set; }

        /// <summary>
        /// 成功
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="msg">消息</param>
        public ResultOutput<T> Ok(T data, string msg = null)
        {
            Success = true;
            Data = data;
            Msg = msg;

            return this;
        }

        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="msg">消息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public ResultOutput<T> NotOk(string msg = null, T data = default(T))
        {
            Success = false;
            Msg = msg;
            Data = data;

            return this;
        }
    }

    /// <summary>
    /// 静态结果输出
    /// </summary>
    public static partial class ResultOutput
    {
        /// <summary>
        /// 成功
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="msg">消息</param>
        /// <returns></returns>
        public static IResultOutput Ok<T>(T data = default(T), string msg = null)
        {
            return new ResultOutput<T>().Ok(data, msg);
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public static IResultOutput Ok()
        {
            return Ok<string>();
        }

        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="msg">消息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static IResultOutput NotOk<T>(string msg = null, T data = default(T))
        {
            return new ResultOutput<T>().NotOk(msg, data);
        }

        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="msg">消息</param>
        /// <returns></returns>
        public static IResultOutput NotOk(string msg = null)
        {
            return new ResultOutput<string>().NotOk(msg);
        }

        /// <summary>
        /// 根据布尔值返回结果
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        public static IResultOutput Result<T>(bool success)
        {
            return success ? Ok<T>() : NotOk<T>();
        }

        /// <summary>
        /// 根据布尔值返回结果
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        public static IResultOutput Result(bool success)
        {
            return success ? Ok() : NotOk();
        }
    }
}