﻿using System;

namespace OpenRCT2.API.AppVeyor
{
    public class JNuGetFeed
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool publishingEnabled { get; set; }
        public string created { get; set; }
    }

    public class JAccessRightDefinition
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class JAccessRight
    {
        public string name { get; set; }
        public bool allowed { get; set; }
    }

    public class JRoleAce
    {
        public int roleId { get; set; }
        public string name { get; set; }
        public bool isAdmin { get; set; }
        public JAccessRight[] accessRights { get; set; }
    }

    public class JSecurityDescriptor
    {
        public JAccessRightDefinition[] accessRightDefinitions { get; set; }
        public JRoleAce[] roleAces { get; set; }
    }

    public class JProject
    {
        public int projectId { get; set; }
        public int accountId { get; set; }
        public string accountName { get; set; }
        public JBuild[] builds { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string repositoryType { get; set; }
        public string repositoryScm { get; set; }
        public string repositoryName { get; set; }
        public string repositoryBranch { get; set; }
        public bool isPrivate { get; set; }
        public bool skipBranchesWithoutAppveyorYml { get; set; }
        public bool enableSecureVariablesInPullRequests { get; set; }
        public bool enableDeploymentInPullRequests { get; set; }
        public bool rollingBuilds { get; set; }
        public bool alwaysBuildClosedPullRequests { get; set; }
        public JNuGetFeed nuGetFeed { get; set; }
        public JSecurityDescriptor securityDescriptor { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
    }

    public class JJob
    {
        public string jobId { get; set; }
        public string name { get; set; }
        public bool allowFailure { get; set; }
        public int messagesCount { get; set; }
        public int compilationMessagesCount { get; set; }
        public int compilationErrorsCount { get; set; }
        public int compilationWarningsCount { get; set; }
        public int testsCount { get; set; }
        public int passedTestsCount { get; set; }
        public int failedTestsCount { get; set; }
        public int artifactsCount { get; set; }
        public string status { get; set; }
        public string started { get; set; }
        public string finished { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
    }

    public class JBuild
    {
        public int buildId { get; set; }
        public JJob[] jobs { get; set; }
        public int buildNumber { get; set; }
        public string version { get; set; }
        public string message { get; set; }
        public string branch { get; set; }
        public string commitId { get; set; }
        public string authorName { get; set; }
        public string authorUsername { get; set; }
        public string committerName { get; set; }
        public string committerUsername { get; set; }
        public string committed { get; set; }
        public object[] messages { get; set; }
        public string status { get; set; }
        public string started { get; set; }
        public string finished { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
    }

    public class JMessage
    {
        public string category { get; set; }
        public string message { get; set; }
        public string details { get; set; }
        public DateTime created { get; set; }
    }
}
