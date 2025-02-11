﻿namespace ZhonTai.Admin.Core.Configs
{
    /// <summary>
    /// 应用配置
    /// </summary>
    public class AppConfig
    {
        public AppType AppType { get; set; } = AppType.Controllers;

        /// <summary>
        /// Api地址，默认 http://*:8000
        /// </summary>
        public string[] Urls { get; set; }

        /// <summary>
        /// 跨域地址，默认 http://*:9000
        /// </summary>
        public string[] CorUrls { get; set; }

        /// <summary>
        /// 程序集名称，默认 ZhonTai.Admin
        /// </summary>
        public string[] AssemblyNames { get; set; }

        /// <summary>
        /// 租户类型
        /// </summary>
        public bool Tenant { get; set; } = false;

        /// <summary>
        /// Swagger文档
        /// </summary>
        public SwaggerConfig Swagger { get; set; } = new SwaggerConfig();

        /// <summary>
        /// 新版Api文档
        /// </summary>
        public ApiUIConfig ApiUI { get; set; } = new ApiUIConfig();

        /// <summary>
        /// MiniProfiler性能分析器
        /// </summary>
        public bool MiniProfiler { get; set; } = false;

        /// <summary>
        /// 统一认证授权服务器
        /// </summary>
        public IdentityServer IdentityServer { get; set; } = new IdentityServer();

        /// <summary>
        /// Aop配置
        /// </summary>
        public AopConfig Aop { get; set; } = new AopConfig();

        /// <summary>
        /// 日志配置
        /// </summary>
        public LogConfig Log { get; set; } = new LogConfig();

        /// <summary>
        /// 限流
        /// </summary>
        public bool RateLimit { get; set; } = false;

        /// <summary>
        /// 验证码配置
        /// </summary>
        public VarifyCodeConfig VarifyCode { get; set; } = new VarifyCodeConfig();
    }

    /// <summary>
    /// Swagger配置
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; } = false;

        /// <summary>
        /// 地址
        /// </summary>
        public string Url { get; set; }
    }

    /// <summary>
    ///新版Api文档配置
    /// </summary>
    public class ApiUIConfig
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; } = false;

        public SwaggerFooterConfig Footer { get; set; } = new SwaggerFooterConfig();
    }

    /// <summary>
    /// Swagger页脚配置
    /// </summary>
    public class SwaggerFooterConfig
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; } = true;

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }

    /// <summary>
    /// 统一认证授权服务器配置
    /// </summary>
    public class IdentityServer
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; } = false;

        /// <summary>
        /// 地址
        /// </summary>
        public string Url { get; set; } = "https://localhost:5000";
    }

    /// <summary>
    /// Aop配置
    /// </summary>
    public class AopConfig
    {
        /// <summary>
        /// 事物
        /// </summary>
        public bool Transaction { get; set; } = true;
    }

    /// <summary>
    /// 日志配置
    /// </summary>
    public class LogConfig
    {
        /// <summary>
        /// 操作日志
        /// </summary>
        public bool Operation { get; set; } = true;
    }

    /// <summary>
    /// 验证码配置
    /// </summary>
    public class VarifyCodeConfig
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; } = true;

        /// <summary>
        /// 操作日志
        /// </summary>
        public string[] Fonts { get; set; }// = new[] { "Times New Roman", "Verdana", "Arial", "Gungsuh", "Impact" };
    }

    /// <summary>
    /// 应用程序类型
    /// </summary>
    public enum AppType
    {
        Controllers,
        ControllersWithViews,
        MVC
    }
}