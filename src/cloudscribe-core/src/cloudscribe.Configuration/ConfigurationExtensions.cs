﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2015-06-18
// Last Modified:			2015-07-04
// 


using Microsoft.Framework.Configuration;
using System;

namespace cloudscribe.Configuration
{
    public static class ConfigurationExtensions
    {

        public static string GetOrDefault(this IConfiguration config, string key, string defaultIfNotFound)
        {
            string result = config.Get(key);

            if(string.IsNullOrEmpty(result)) { return defaultIfNotFound; }

            return result;
        }

        public static int GetOrDefault(this IConfiguration config, string key, int defaultIfNotFound)
        {
            string result = config.Get(key);

            if (string.IsNullOrEmpty(result)) { return defaultIfNotFound; }

            return Convert.ToInt32(result);
        }

        public static bool GetOrDefault(this IConfiguration config, string key, bool defaultIfNotFound)
        {
            string result = config.Get(key);

            if (string.IsNullOrEmpty(result)) { return defaultIfNotFound; }

            return Convert.ToBoolean(result);
        }

        public static Guid GetOrDefault(this IConfiguration config, string key, Guid defaultIfNotFound)
        {
            string result = config.Get(key);

            if (string.IsNullOrEmpty(result)) { return defaultIfNotFound; }
            if(result.Length != 36) { return defaultIfNotFound; }

            return new Guid(result);
        }

        //public static bool UseRelatedSiteMode(this IConfiguration config)
        //{
        //    return config.GetOrDefault("AppSettings:UseRelatedSiteMode", false);
        //}

        //public static bool UseFoldersInsteadOfHostnamesForMultipleSites(this IConfiguration config)
        //{
        //    return config.GetOrDefault("AppSettings:UseFoldersInsteadOfHostnamesForMultipleSites", true);
        //}

        

        //public static bool DontUseEmailForLogin(this IConfiguration config)
        //{
        //    return config.GetOrDefault("AppSettings:DontUseEmailForLogin", false);
        //}

        


        //public static int RelatedSiteId (this IConfiguration config)
        //{
        //    return config.GetOrDefault("AppSettings:RelatedSiteId", 1);
        //}

        //public static string CkEditorCustomConfigPath(this IConfiguration config)
        //{
        //    return config.GetOrDefault("CkEditor:CustomConfigPath", "~/js/cloudscribe-ckeditor-config.js");
        //}

        

        public static bool UserStoreDebugEnabled(this IConfiguration config)
        {
            return config.GetOrDefault("AppSettings:UserStoreDebugEnabled", false);
        }

        public static string DefaultRolesForNewUsers(this IConfiguration config)
        {
            return config.GetOrDefault("AppSettings:DefaultRolesForNewUsers", "Authenticated Users");
        }

        

        

        

        

        

    }
}
