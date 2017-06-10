using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.Utility.Config
{
    /// <summary>
    /// 站点配置信息提供程序（读写站点配置信息）
    /// </summary>
    public interface ISiteConfigProvider
    {
        /// <summary>
        ///  读取站点配置文件
        /// </summary>
        /// <param name="configFilePath">站点配置文件的路径</param>
        /// <returns>站点配置类</returns>
        SiteConfig LoadConfig(string configFilePath);

        /// <summary>
        /// 写入站点配置文件
        /// </summary>
        /// <param name="siteConfig"></param>
        /// <param name="configFilePath"></param>
        /// <returns></returns>
        SiteConfig SaveConifg(SiteConfig siteConfig, string configFilePath);
    }
}
