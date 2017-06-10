using OSharp.Core.Caching;
using System;
using System.Collections.Generic;
using System.Text;
using TG.UBP.Utility.Data;

namespace TG.UBP.Utility.Config
{
    /// <summary>
    /// 数据访问类:站点配置
    /// </summary>
    public partial class SiteConfigProvider : ISiteConfigProvider
    {
        private static object lockHelper = new object();

        /// <summary>
        ///  读取站点配置文件
        /// </summary>
        public SiteConfig LoadConfig(string configFilePath)
        {
            //获取或新建区域名为“XmlConfig”的缓存执行者，系统约定：所有和配置文件相关的缓存都属于区域名为“XmlConfig”的缓存执行者。
            ICache cache = CacheManager.GetCacher("XmlConfig");

            SiteConfig siteCofnig = cache.Get<SiteConfig>(ContextKeys.CACHE_SITE_CONFIG);
            if (siteCofnig == null)
            {
                siteCofnig = (SiteConfig)SerializationHelper.Load(typeof(SiteConfig), configFilePath);
                cache.Set(ContextKeys.CACHE_SITE_CONFIG, siteCofnig);
            }
            return siteCofnig;
        }

        /// <summary>
        /// 写入站点配置文件
        /// </summary>
        public SiteConfig SaveConifg(SiteConfig siteConfig, string configFilePath)
        {
            lock (lockHelper)
            {
                SerializationHelper.Save(siteConfig, configFilePath);

                ICache cache = CacheManager.GetCacher("XmlConfig");
                cache.Remove(ContextKeys.CACHE_SITE_CONFIG);
            }
            return siteConfig;
        }

    }
}
