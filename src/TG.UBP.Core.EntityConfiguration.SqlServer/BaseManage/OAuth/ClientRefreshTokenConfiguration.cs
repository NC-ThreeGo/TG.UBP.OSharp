// -----------------------------------------------------------------------
//  <copyright file="ClientRefreshTokenConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2015 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-11-10 5:01</last-date>
// -----------------------------------------------------------------------

using System;

using OSharp.Data.Entity;
using TG.UBP.Core.Entity.BaseManage.OAuth;


namespace TG.UBP.Core.EntityConfiguration.SqlServer.BaseManage.OAuth
{
    public class ClientRefreshTokenConfiguration : EntityConfigurationBase<OAuthClientRefreshToken, Guid>
    { }
}