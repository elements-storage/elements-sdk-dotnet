# ELEMENTS .NET SDK

- API version: 2
- .NET Standard 2.0
- The SDK and its documentation are automatically generated from the API schema

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Framework >=4.6.1
- .NET 5
- .NET Core >=2.0
- Mono/Xamarin >=5.4

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later

## NuGet Repo

- [https://github.com/orgs/elements-storage/packages](https://github.com/orgs/elements-storage/packages)

## Usage

```csharp
var c = new Configuration();
var userToken = "...";
c.BasePath = "http://192.168.1.10"
c.DefaultHeaders["Authorization"] = $"Bearer {userToken}";

var workspaces = await new StorageApi(c).GetAllWorkspacesAsync()
// var workspaces = new StorageApi(c).GetAllWorkspaces()
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://elements.local*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AWSApi* | [**CreateAWSAccount**](docs/AWSApi#createawsaccount) | **POST** /api/2/aws-accounts | 
*AWSApi* | [**DeleteAWSAccount**](docs/AWSApi#deleteawsaccount) | **DELETE** /api/2/aws-accounts/{id} | 
*AWSApi* | [**GetAWSAccount**](docs/AWSApi#getawsaccount) | **GET** /api/2/aws-accounts/{id} | 
*AWSApi* | [**GetAWSAccountBuckets**](docs/AWSApi#getawsaccountbuckets) | **GET** /api/2/aws-accounts/{id}/buckets | 
*AWSApi* | [**GetAWSAccountSNSTopics**](docs/AWSApi#getawsaccountsnstopics) | **GET** /api/2/aws-accounts/{id}/sns/topics | 
*AWSApi* | [**GetAllAWSAccounts**](docs/AWSApi#getallawsaccounts) | **GET** /api/2/aws-accounts | 
*AWSApi* | [**PatchAWSAccount**](docs/AWSApi#patchawsaccount) | **PATCH** /api/2/aws-accounts/{id} | 
*AWSApi* | [**TestAWSAccountCredentials**](docs/AWSApi#testawsaccountcredentials) | **POST** /api/2/aws-accounts/test-credentials | 
*AWSApi* | [**UpdateAWSAccount**](docs/AWSApi#updateawsaccount) | **PUT** /api/2/aws-accounts/{id} | 
*AuthApi* | [**CheckAuthTicket**](docs/AuthApi#checkauthticket) | **POST** /api/2/auth/ticket/check | 
*AuthApi* | [**CreateAuthTicket**](docs/AuthApi#createauthticket) | **POST** /api/2/auth/ticket | 
*AuthApi* | [**DeleteAccessToken**](docs/AuthApi#deleteaccesstoken) | **DELETE** /api/2/auth/access-tokens/{id} | 
*AuthApi* | [**GeneratePassword**](docs/AuthApi#generatepassword) | **POST** /api/2/auth/generate-password | 
*AuthApi* | [**GetAccessToken**](docs/AuthApi#getaccesstoken) | **GET** /api/2/auth/access-tokens/{id} | 
*AuthApi* | [**GetAllAccessTokens**](docs/AuthApi#getallaccesstokens) | **GET** /api/2/auth/access-tokens | 
*AuthApi* | [**Login**](docs/AuthApi#login) | **POST** /api/2/auth/login | 
*AuthApi* | [**Logout**](docs/AuthApi#logout) | **POST** /api/2/auth/logout | 
*AuthApi* | [**ResetPassword**](docs/AuthApi#resetpassword) | **POST** /api/2/auth/reset-password | 
*AuthApi* | [**SendAccessTokenEmailNotification**](docs/AuthApi#sendaccesstokenemailnotification) | **POST** /api/2/auth/access-tokens/{id}/email | 
*AuthApi* | [**StartImpersonation**](docs/AuthApi#startimpersonation) | **POST** /api/2/auth/impersonation | 
*AuthApi* | [**StopImpersonation**](docs/AuthApi#stopimpersonation) | **POST** /api/2/auth/impersonation/stop | 
*AutomationApi* | [**AbortTask**](docs/AutomationApi#aborttask) | **POST** /api/2/tasks/{id}/abort | 
*AutomationApi* | [**CreateJob**](docs/AutomationApi#createjob) | **POST** /api/2/jobs | 
*AutomationApi* | [**CreateSchedule**](docs/AutomationApi#createschedule) | **POST** /api/2/schedules | 
*AutomationApi* | [**CreateSubtask**](docs/AutomationApi#createsubtask) | **POST** /api/2/subtasks | 
*AutomationApi* | [**DeleteFinishedTasks**](docs/AutomationApi#deletefinishedtasks) | **DELETE** /api/2/tasks/finished | 
*AutomationApi* | [**DeleteJob**](docs/AutomationApi#deletejob) | **DELETE** /api/2/jobs/{id} | 
*AutomationApi* | [**DeleteSchedule**](docs/AutomationApi#deleteschedule) | **DELETE** /api/2/schedules/{id} | 
*AutomationApi* | [**DeleteSubtask**](docs/AutomationApi#deletesubtask) | **DELETE** /api/2/subtasks/{id} | 
*AutomationApi* | [**DeleteTask**](docs/AutomationApi#deletetask) | **DELETE** /api/2/tasks/{id} | 
*AutomationApi* | [**DownloadAllTaskLogs**](docs/AutomationApi#downloadalltasklogs) | **GET** /api/2/tasks/logs/download | 
*AutomationApi* | [**DownloadTaskLog**](docs/AutomationApi#downloadtasklog) | **GET** /api/2/tasks/{id}/log/download | 
*AutomationApi* | [**GetAllEvents**](docs/AutomationApi#getallevents) | **GET** /api/2/events | 
*AutomationApi* | [**GetAllJobs**](docs/AutomationApi#getalljobs) | **GET** /api/2/jobs | 
*AutomationApi* | [**GetAllSchedules**](docs/AutomationApi#getallschedules) | **GET** /api/2/schedules | 
*AutomationApi* | [**GetAllSubtasks**](docs/AutomationApi#getallsubtasks) | **GET** /api/2/subtasks | 
*AutomationApi* | [**GetAllTaskQueues**](docs/AutomationApi#getalltaskqueues) | **GET** /api/2/tasks/queues | 
*AutomationApi* | [**GetAllTaskTypes**](docs/AutomationApi#getalltasktypes) | **GET** /api/2/tasks/types | 
*AutomationApi* | [**GetAllTasks**](docs/AutomationApi#getalltasks) | **GET** /api/2/tasks | 
*AutomationApi* | [**GetEvent**](docs/AutomationApi#getevent) | **GET** /api/2/events/{id} | 
*AutomationApi* | [**GetFinishedTasks**](docs/AutomationApi#getfinishedtasks) | **GET** /api/2/tasks/finished | 
*AutomationApi* | [**GetJob**](docs/AutomationApi#getjob) | **GET** /api/2/jobs/{id} | 
*AutomationApi* | [**GetPendingTasks**](docs/AutomationApi#getpendingtasks) | **GET** /api/2/tasks/pending | 
*AutomationApi* | [**GetPythonEnvironments**](docs/AutomationApi#getpythonenvironments) | **GET** /api/2/python/environments | 
*AutomationApi* | [**GetSchedule**](docs/AutomationApi#getschedule) | **GET** /api/2/schedules/{id} | 
*AutomationApi* | [**GetSubtask**](docs/AutomationApi#getsubtask) | **GET** /api/2/subtasks/{id} | 
*AutomationApi* | [**GetTask**](docs/AutomationApi#gettask) | **GET** /api/2/tasks/{id} | 
*AutomationApi* | [**GetTaskLog**](docs/AutomationApi#gettasklog) | **GET** /api/2/tasks/{id}/log | 
*AutomationApi* | [**GetTaskType**](docs/AutomationApi#gettasktype) | **GET** /api/2/tasks/types/{type} | 
*AutomationApi* | [**GetTasksSummary**](docs/AutomationApi#gettaskssummary) | **GET** /api/2/tasks/summary | 
*AutomationApi* | [**KillAllPendingTasks**](docs/AutomationApi#killallpendingtasks) | **DELETE** /api/2/tasks/pending | 
*AutomationApi* | [**KillTask**](docs/AutomationApi#killtask) | **POST** /api/2/tasks/{id}/kill | 
*AutomationApi* | [**PatchJob**](docs/AutomationApi#patchjob) | **PATCH** /api/2/jobs/{id} | 
*AutomationApi* | [**PatchSchedule**](docs/AutomationApi#patchschedule) | **PATCH** /api/2/schedules/{id} | 
*AutomationApi* | [**PatchSubtask**](docs/AutomationApi#patchsubtask) | **PATCH** /api/2/subtasks/{id} | 
*AutomationApi* | [**RestartTask**](docs/AutomationApi#restarttask) | **POST** /api/2/tasks/{id}/restart | 
*AutomationApi* | [**StartJob**](docs/AutomationApi#startjob) | **POST** /api/2/jobs/{id}/start | 
*AutomationApi* | [**StartTask**](docs/AutomationApi#starttask) | **POST** /api/2/tasks/start | 
*AutomationApi* | [**UpdateJob**](docs/AutomationApi#updatejob) | **PUT** /api/2/jobs/{id} | 
*AutomationApi* | [**UpdateSchedule**](docs/AutomationApi#updateschedule) | **PUT** /api/2/schedules/{id} | 
*AutomationApi* | [**UpdateSubtask**](docs/AutomationApi#updatesubtask) | **PUT** /api/2/subtasks/{id} | 
*ClickApi* | [**AbortClickUpload**](docs/ClickApi#abortclickupload) | **DELETE** /api/2/click/uploads/{upload_id} | 
*ClickApi* | [**ContinueClickUploadInBackground**](docs/ClickApi#continueclickuploadinbackground) | **POST** /api/2/click/uploads/{upload_id}/background | 
*ClickApi* | [**CreateClickGallery**](docs/ClickApi#createclickgallery) | **POST** /api/2/click/connections/{connection_id}/galleries | 
*ClickApi* | [**CreateClickGalleryLink**](docs/ClickApi#createclickgallerylink) | **POST** /api/2/click/connections/{connection_id}/gallery-links | 
*ClickApi* | [**DeleteClickGalleryLink**](docs/ClickApi#deleteclickgallerylink) | **DELETE** /api/2/click/connections/{connection_id}/gallery-links/{id} | 
*ClickApi* | [**GetAllClickGalleries**](docs/ClickApi#getallclickgalleries) | **GET** /api/2/click/connections/{connection_id}/galleries | 
*ClickApi* | [**GetAllClickGalleryLinks**](docs/ClickApi#getallclickgallerylinks) | **GET** /api/2/click/connections/{connection_id}/gallery-links | 
*ClickApi* | [**GetClickGallery**](docs/ClickApi#getclickgallery) | **GET** /api/2/click/connections/{connection_id}/galleries/{id} | 
*ClickApi* | [**GetClickGalleryLink**](docs/ClickApi#getclickgallerylink) | **GET** /api/2/click/connections/{connection_id}/gallery-links/{id} | 
*ClickApi* | [**PatchClickGallery**](docs/ClickApi#patchclickgallery) | **PATCH** /api/2/click/connections/{connection_id}/galleries/{id} | 
*ClickApi* | [**SendClickGalleryLinkEmail**](docs/ClickApi#sendclickgallerylinkemail) | **POST** /api/2/click/connections/{connection_id}/gallery-links/{link_id}/send | 
*ClickApi* | [**StartClickUpload**](docs/ClickApi#startclickupload) | **POST** /api/2/click/uploads | 
*ClickApi* | [**UpdateClickGallery**](docs/ClickApi#updateclickgallery) | **PUT** /api/2/click/connections/{connection_id}/galleries/{id} | 
*IntegrationsApi* | [**DeleteSlackConnection**](docs/IntegrationsApi#deleteslackconnection) | **DELETE** /api/2/integrations/slack/{id} | 
*IntegrationsApi* | [**DeleteTeamsConnection**](docs/IntegrationsApi#deleteteamsconnection) | **DELETE** /api/2/integrations/teams/{id} | 
*IntegrationsApi* | [**GetAllSlackConnections**](docs/IntegrationsApi#getallslackconnections) | **GET** /api/2/integrations/slack | 
*IntegrationsApi* | [**GetAllTeamsConnections**](docs/IntegrationsApi#getallteamsconnections) | **GET** /api/2/integrations/teams | 
*IntegrationsApi* | [**GetSlackChannels**](docs/IntegrationsApi#getslackchannels) | **GET** /api/2/integrations/slack/{id}/channels | 
*IntegrationsApi* | [**GetSlackConnection**](docs/IntegrationsApi#getslackconnection) | **GET** /api/2/integrations/slack/{id} | 
*IntegrationsApi* | [**GetSlackEmoji**](docs/IntegrationsApi#getslackemoji) | **GET** /api/2/integrations/slack/{id}/emoji | 
*IntegrationsApi* | [**GetSlackUsers**](docs/IntegrationsApi#getslackusers) | **GET** /api/2/integrations/slack/{id}/users | 
*IntegrationsApi* | [**GetTeamsChannels**](docs/IntegrationsApi#getteamschannels) | **GET** /api/2/integrations/teams/{id}/channels | 
*IntegrationsApi* | [**GetTeamsConnection**](docs/IntegrationsApi#getteamsconnection) | **GET** /api/2/integrations/teams/{id} | 
*IntegrationsApi* | [**GetTeamsUsers**](docs/IntegrationsApi#getteamsusers) | **GET** /api/2/integrations/teams/{id}/users | 
*IntegrationsApi* | [**PatchSlackConnection**](docs/IntegrationsApi#patchslackconnection) | **PATCH** /api/2/integrations/slack/{id} | 
*IntegrationsApi* | [**PatchTeamsConnection**](docs/IntegrationsApi#patchteamsconnection) | **PATCH** /api/2/integrations/teams/{id} | 
*IntegrationsApi* | [**SendSlackMessage**](docs/IntegrationsApi#sendslackmessage) | **POST** /api/2/integrations/slack/{id}/message | 
*IntegrationsApi* | [**SendTeamsMessage**](docs/IntegrationsApi#sendteamsmessage) | **POST** /api/2/integrations/teams/{id}/send-message | 
*IntegrationsApi* | [**StartSlackConnectionFlow**](docs/IntegrationsApi#startslackconnectionflow) | **GET** /api/2/integrations/slack/connect | 
*IntegrationsApi* | [**StartSlackConnectionTokenRefreshFlow**](docs/IntegrationsApi#startslackconnectiontokenrefreshflow) | **GET** /api/2/integrations/slack/{id}/refresh-token | 
*IntegrationsApi* | [**StartTeamsConnectionFlow**](docs/IntegrationsApi#startteamsconnectionflow) | **GET** /api/2/integrations/teams/connect | 
*IntegrationsApi* | [**StartTeamsConnectionTokenRefreshFlow**](docs/IntegrationsApi#startteamsconnectiontokenrefreshflow) | **GET** /api/2/integrations/teams/{id}/refresh-token | 
*IntegrationsApi* | [**UpdateSlackConnection**](docs/IntegrationsApi#updateslackconnection) | **PUT** /api/2/integrations/slack/{id} | 
*IntegrationsApi* | [**UpdateTeamsConnection**](docs/IntegrationsApi#updateteamsconnection) | **PUT** /api/2/integrations/teams/{id} | 
*MainApi* | [**ApplyConfiguration**](docs/MainApi#applyconfiguration) | **POST** /api/2/configuration/apply | 
*MainApi* | [**Beep**](docs/MainApi#beep) | **POST** /api/2/system/beep | 
*MainApi* | [**CheckCertificate**](docs/MainApi#checkcertificate) | **POST** /api/2/system/certificate/check | 
*MainApi* | [**CheckChunkUploaded**](docs/MainApi#checkchunkuploaded) | **GET** /api/2/uploads/chunk | 
*MainApi* | [**CheckInternetConnectivity**](docs/MainApi#checkinternetconnectivity) | **POST** /api/2/system/check-connectivity | 
*MainApi* | [**CheckStorNextLicense**](docs/MainApi#checkstornextlicense) | **POST** /api/2/stornext-license/check | 
*MainApi* | [**CollectDiagnostics**](docs/MainApi#collectdiagnostics) | **POST** /api/2/system/collect-diagnostics | 
*MainApi* | [**CreateArchive**](docs/MainApi#createarchive) | **POST** /api/2/download-archive/create | 
*MainApi* | [**CreateGroup**](docs/MainApi#creategroup) | **POST** /api/2/groups | 
*MainApi* | [**CreateHomeWorkspace**](docs/MainApi#createhomeworkspace) | **POST** /api/2/users/{id}/home | 
*MainApi* | [**CreateNTPServer**](docs/MainApi#createntpserver) | **POST** /api/2/system/time/servers | 
*MainApi* | [**CreateUser**](docs/MainApi#createuser) | **POST** /api/2/users | 
*MainApi* | [**CreateWorkstation**](docs/MainApi#createworkstation) | **POST** /api/2/workstations | 
*MainApi* | [**DeleteDownloadArchive**](docs/MainApi#deletedownloadarchive) | **DELETE** /api/2/download-archive/{id} | 
*MainApi* | [**DeleteGroup**](docs/MainApi#deletegroup) | **DELETE** /api/2/groups/{id} | 
*MainApi* | [**DeleteHomeWorkspace**](docs/MainApi#deletehomeworkspace) | **DELETE** /api/2/users/{id}/home | 
*MainApi* | [**DeleteNTPServer**](docs/MainApi#deletentpserver) | **DELETE** /api/2/system/time/servers/{id} | 
*MainApi* | [**DeleteUser**](docs/MainApi#deleteuser) | **DELETE** /api/2/users/{id} | 
*MainApi* | [**DeleteWorkstation**](docs/MainApi#deleteworkstation) | **DELETE** /api/2/workstations/{id} | 
*MainApi* | [**DisableUserTOTP**](docs/MainApi#disableusertotp) | **DELETE** /api/2/users/{id}/totp | 
*MainApi* | [**EnableUserTOTP**](docs/MainApi#enableusertotp) | **POST** /api/2/users/{id}/totp | 
*MainApi* | [**FinishUpload**](docs/MainApi#finishupload) | **POST** /api/2/uploads/finish | 
*MainApi* | [**FixLDAPGroupMemberships**](docs/MainApi#fixldapgroupmemberships) | **POST** /api/2/ldap-servers/{id}/fix-memberships | 
*MainApi* | [**GetAllDownloadArchives**](docs/MainApi#getalldownloadarchives) | **GET** /api/2/download-archive | 
*MainApi* | [**GetAllDownloads**](docs/MainApi#getalldownloads) | **GET** /api/2/downloads | 
*MainApi* | [**GetAllGroups**](docs/MainApi#getallgroups) | **GET** /api/2/groups | 
*MainApi* | [**GetAllLDAPServers**](docs/MainApi#getallldapservers) | **GET** /api/2/ldap-servers | 
*MainApi* | [**GetAllNTPServers**](docs/MainApi#getallntpservers) | **GET** /api/2/system/time/servers | 
*MainApi* | [**GetAllStorageNodes**](docs/MainApi#getallstoragenodes) | **GET** /api/2/nodes | 
*MainApi* | [**GetAllUsers**](docs/MainApi#getallusers) | **GET** /api/2/users | 
*MainApi* | [**GetAllWorkstations**](docs/MainApi#getallworkstations) | **GET** /api/2/workstations | 
*MainApi* | [**GetCertificateConfiguration**](docs/MainApi#getcertificateconfiguration) | **GET** /api/2/system/certificate | 
*MainApi* | [**GetClientDownloadFile**](docs/MainApi#getclientdownloadfile) | **GET** /api/2/downloads/clients/{file} | 
*MainApi* | [**GetClientDownloads**](docs/MainApi#getclientdownloads) | **GET** /api/2/downloads/clients | 
*MainApi* | [**GetCurrentWorkstation**](docs/MainApi#getcurrentworkstation) | **GET** /api/2/workstations/current | 
*MainApi* | [**GetDownload**](docs/MainApi#getdownload) | **GET** /api/2/downloads/{id} | 
*MainApi* | [**GetDownloadArchive**](docs/MainApi#getdownloadarchive) | **GET** /api/2/download-archive/{id} | 
*MainApi* | [**GetDownloadArchiveFile**](docs/MainApi#getdownloadarchivefile) | **GET** /api/2/download-archive/{id}/download | 
*MainApi* | [**GetDownloadFile**](docs/MainApi#getdownloadfile) | **GET** /api/2/downloads/{id}/download | 
*MainApi* | [**GetDownloadIcon**](docs/MainApi#getdownloadicon) | **GET** /api/2/downloads/{id}/icon | 
*MainApi* | [**GetGroup**](docs/MainApi#getgroup) | **GET** /api/2/groups/{id} | 
*MainApi* | [**GetHomeWorkspace**](docs/MainApi#gethomeworkspace) | **GET** /api/2/users/{id}/home | 
*MainApi* | [**GetIPMIConfiguration**](docs/MainApi#getipmiconfiguration) | **GET** /api/2/nodes/{id}/ipmi | 
*MainApi* | [**GetLDAPServer**](docs/MainApi#getldapserver) | **GET** /api/2/ldap-servers/{id} | 
*MainApi* | [**GetLDAPServerGroups**](docs/MainApi#getldapservergroups) | **GET** /api/2/ldap-servers/{id}/groups | 
*MainApi* | [**GetLDAPServerUsers**](docs/MainApi#getldapserverusers) | **GET** /api/2/ldap-servers/{id}/users | 
*MainApi* | [**GetLicense**](docs/MainApi#getlicense) | **GET** /api/2/license | 
*MainApi* | [**GetLocalTime**](docs/MainApi#getlocaltime) | **GET** /api/2/system/time | 
*MainApi* | [**GetLog**](docs/MainApi#getlog) | **GET** /api/2/system/log/{path} | 
*MainApi* | [**GetNTPServer**](docs/MainApi#getntpserver) | **GET** /api/2/system/time/servers/{id} | 
*MainApi* | [**GetNodeIPMISensors**](docs/MainApi#getnodeipmisensors) | **GET** /api/2/nodes/{id}/sensors | 
*MainApi* | [**GetNodeStats**](docs/MainApi#getnodestats) | **GET** /api/2/nodes/{id}/stats | 
*MainApi* | [**GetParameters**](docs/MainApi#getparameters) | **GET** /api/2/parameters | 
*MainApi* | [**GetProfile**](docs/MainApi#getprofile) | **GET** /api/2/users/me | 
*MainApi* | [**GetReleaseNotes**](docs/MainApi#getreleasenotes) | **GET** /api/2/release-notes | 
*MainApi* | [**GetSMTPConfiguration**](docs/MainApi#getsmtpconfiguration) | **GET** /api/2/system/smtp | 
*MainApi* | [**GetServiceStatus**](docs/MainApi#getservicestatus) | **GET** /api/2/nodes/{id}/services/{service} | 
*MainApi* | [**GetStorNextLicense**](docs/MainApi#getstornextlicense) | **GET** /api/2/stornext-license | 
*MainApi* | [**GetStorageNode**](docs/MainApi#getstoragenode) | **GET** /api/2/nodes/{id} | 
*MainApi* | [**GetSystemInfo**](docs/MainApi#getsysteminfo) | **GET** /api/2/system/info | 
*MainApi* | [**GetUser**](docs/MainApi#getuser) | **GET** /api/2/users/{id} | 
*MainApi* | [**GetWorkstation**](docs/MainApi#getworkstation) | **GET** /api/2/workstations/{id} | 
*MainApi* | [**InstallStorNextLicense**](docs/MainApi#installstornextlicense) | **POST** /api/2/stornext-license | 
*MainApi* | [**PatchCurrentWorkstation**](docs/MainApi#patchcurrentworkstation) | **PATCH** /api/2/workstations/current | 
*MainApi* | [**PatchDownloadArchive**](docs/MainApi#patchdownloadarchive) | **PATCH** /api/2/download-archive/{id} | 
*MainApi* | [**PatchGroup**](docs/MainApi#patchgroup) | **PATCH** /api/2/groups/{id} | 
*MainApi* | [**PatchNTPServer**](docs/MainApi#patchntpserver) | **PATCH** /api/2/system/time/servers/{id} | 
*MainApi* | [**PatchProfile**](docs/MainApi#patchprofile) | **PATCH** /api/2/users/me | 
*MainApi* | [**PatchUser**](docs/MainApi#patchuser) | **PATCH** /api/2/users/{id} | 
*MainApi* | [**PatchWorkstation**](docs/MainApi#patchworkstation) | **PATCH** /api/2/workstations/{id} | 
*MainApi* | [**PreviewUser**](docs/MainApi#previewuser) | **POST** /api/2/users/preview | 
*MainApi* | [**Reboot**](docs/MainApi#reboot) | **POST** /api/2/system/reboot | 
*MainApi* | [**RegisterUpload**](docs/MainApi#registerupload) | **POST** /api/2/uploads/register | 
*MainApi* | [**RegisterUploadMetadata**](docs/MainApi#registeruploadmetadata) | **POST** /api/2/uploads/metadata | 
*MainApi* | [**RenderEmailTemplatePreview**](docs/MainApi#renderemailtemplatepreview) | **POST** /api/2/system/smtp/preview | 
*MainApi* | [**ResetUserPassword**](docs/MainApi#resetuserpassword) | **POST** /api/2/users/{id}/password/reset | 
*MainApi* | [**RunServiceOperation**](docs/MainApi#runserviceoperation) | **POST** /api/2/nodes/{id}/services/{service}/{operation} | 
*MainApi* | [**SetIPMIConfiguration**](docs/MainApi#setipmiconfiguration) | **PUT** /api/2/nodes/{id}/ipmi | 
*MainApi* | [**SetLocalTime**](docs/MainApi#setlocaltime) | **POST** /api/2/system/time | 
*MainApi* | [**SetMyPassword**](docs/MainApi#setmypassword) | **POST** /api/2/users/me/password | 
*MainApi* | [**SetUserPassword**](docs/MainApi#setuserpassword) | **POST** /api/2/users/{id}/password | 
*MainApi* | [**Shutdown**](docs/MainApi#shutdown) | **POST** /api/2/system/shutdown | 
*MainApi* | [**StartSolrReindex**](docs/MainApi#startsolrreindex) | **POST** /api/2/system/solr/reindex | 
*MainApi* | [**StartSupportSession**](docs/MainApi#startsupportsession) | **POST** /api/2/system/support-session/start | 
*MainApi* | [**StartSystemBackup**](docs/MainApi#startsystembackup) | **POST** /api/2/system/backup/start | 
*MainApi* | [**SyncLDAPGroup**](docs/MainApi#syncldapgroup) | **POST** /api/2/groups/{id}/ldap-sync | 
*MainApi* | [**SyncLDAPUsers**](docs/MainApi#syncldapusers) | **POST** /api/2/ldap-servers/{id}/sync-users | 
*MainApi* | [**SyncTime**](docs/MainApi#synctime) | **POST** /api/2/system/time/sync | 
*MainApi* | [**SyncUserTOTP**](docs/MainApi#syncusertotp) | **PUT** /api/2/users/{id}/totp | 
*MainApi* | [**TestSMTPConfiguration**](docs/MainApi#testsmtpconfiguration) | **POST** /api/2/system/smtp/test | 
*MainApi* | [**UpdateCertificateConfiguration**](docs/MainApi#updatecertificateconfiguration) | **PUT** /api/2/system/certificate | 
*MainApi* | [**UpdateCurrentWorkstation**](docs/MainApi#updatecurrentworkstation) | **PUT** /api/2/workstations/current | 
*MainApi* | [**UpdateDownloadArchive**](docs/MainApi#updatedownloadarchive) | **PUT** /api/2/download-archive/{id} | 
*MainApi* | [**UpdateGroup**](docs/MainApi#updategroup) | **PUT** /api/2/groups/{id} | 
*MainApi* | [**UpdateNTPServer**](docs/MainApi#updatentpserver) | **PUT** /api/2/system/time/servers/{id} | 
*MainApi* | [**UpdateParameters**](docs/MainApi#updateparameters) | **PUT** /api/2/parameters | 
*MainApi* | [**UpdateProfile**](docs/MainApi#updateprofile) | **PUT** /api/2/users/me | 
*MainApi* | [**UpdateSMTPConfiguration**](docs/MainApi#updatesmtpconfiguration) | **PUT** /api/2/system/smtp | 
*MainApi* | [**UpdateUser**](docs/MainApi#updateuser) | **PUT** /api/2/users/{id} | 
*MainApi* | [**UpdateWorkstation**](docs/MainApi#updateworkstation) | **PUT** /api/2/workstations/{id} | 
*MainApi* | [**UploadChunk**](docs/MainApi#uploadchunk) | **POST** /api/2/uploads/chunk | 
*MediaLibraryApi* | [**BookmarkMediaDirectory**](docs/MediaLibraryApi#bookmarkmediadirectory) | **POST** /api/2/media/files/{id}/bookmark | 
*MediaLibraryApi* | [**ClearSubclipClipboard**](docs/MediaLibraryApi#clearsubclipclipboard) | **DELETE** /api/2/media/subclips/clipboard/clear | 
*MediaLibraryApi* | [**CombineAssetsIntoSet**](docs/MediaLibraryApi#combineassetsintoset) | **POST** /api/2/media/assets/combine | 
*MediaLibraryApi* | [**CreateAsset**](docs/MediaLibraryApi#createasset) | **POST** /api/2/media/assets | 
*MediaLibraryApi* | [**CreateAssetRating**](docs/MediaLibraryApi#createassetrating) | **POST** /api/2/media/ratings | 
*MediaLibraryApi* | [**CreateComment**](docs/MediaLibraryApi#createcomment) | **POST** /api/2/media/comments | 
*MediaLibraryApi* | [**CreateCustomField**](docs/MediaLibraryApi#createcustomfield) | **POST** /api/2/media/custom-fields | 
*MediaLibraryApi* | [**CreateEditorProject**](docs/MediaLibraryApi#createeditorproject) | **POST** /api/2/media/editor | 
*MediaLibraryApi* | [**CreateExternalTranscoder**](docs/MediaLibraryApi#createexternaltranscoder) | **POST** /api/2/media/external-transcoders | 
*MediaLibraryApi* | [**CreateMarker**](docs/MediaLibraryApi#createmarker) | **POST** /api/2/media/markers | 
*MediaLibraryApi* | [**CreateMediaFileTemplate**](docs/MediaLibraryApi#createmediafiletemplate) | **POST** /api/2/media/files/templates | 
*MediaLibraryApi* | [**CreateMediaRoot**](docs/MediaLibraryApi#createmediaroot) | **POST** /api/2/media/roots | 
*MediaLibraryApi* | [**CreateMediaRootPermission**](docs/MediaLibraryApi#createmediarootpermission) | **POST** /api/2/media/root-permissions | 
*MediaLibraryApi* | [**CreateMediaTag**](docs/MediaLibraryApi#createmediatag) | **POST** /api/2/media/tags | 
*MediaLibraryApi* | [**CreateProxyProfile**](docs/MediaLibraryApi#createproxyprofile) | **POST** /api/2/media/proxy-profiles | 
*MediaLibraryApi* | [**CreateSubclip**](docs/MediaLibraryApi#createsubclip) | **POST** /api/2/media/subclips | 
*MediaLibraryApi* | [**CreateSubclipClipboardEntry**](docs/MediaLibraryApi#createsubclipclipboardentry) | **POST** /api/2/media/subclips/clipboard | 
*MediaLibraryApi* | [**DeleteAsset**](docs/MediaLibraryApi#deleteasset) | **DELETE** /api/2/media/assets/{id} | 
*MediaLibraryApi* | [**DeleteAssetRating**](docs/MediaLibraryApi#deleteassetrating) | **DELETE** /api/2/media/ratings/{id} | 
*MediaLibraryApi* | [**DeleteComment**](docs/MediaLibraryApi#deletecomment) | **DELETE** /api/2/media/comments/{id} | 
*MediaLibraryApi* | [**DeleteCustomField**](docs/MediaLibraryApi#deletecustomfield) | **DELETE** /api/2/media/custom-fields/{id} | 
*MediaLibraryApi* | [**DeleteEasySharingTokenForBundle**](docs/MediaLibraryApi#deleteeasysharingtokenforbundle) | **DELETE** /api/2/media/bundles/{id}/easy-sharing-token | 
*MediaLibraryApi* | [**DeleteEasySharingTokenForDirectory**](docs/MediaLibraryApi#deleteeasysharingtokenfordirectory) | **DELETE** /api/2/media/files/{id}/easy-sharing-token | 
*MediaLibraryApi* | [**DeleteExternalTranscoder**](docs/MediaLibraryApi#deleteexternaltranscoder) | **DELETE** /api/2/media/external-transcoders/{id} | 
*MediaLibraryApi* | [**DeleteMarker**](docs/MediaLibraryApi#deletemarker) | **DELETE** /api/2/media/markers/{id} | 
*MediaLibraryApi* | [**DeleteMediaFileTemplate**](docs/MediaLibraryApi#deletemediafiletemplate) | **DELETE** /api/2/media/files/templates/{id} | 
*MediaLibraryApi* | [**DeleteMediaLibraryObjects**](docs/MediaLibraryApi#deletemedialibraryobjects) | **POST** /api/2/media/delete | 
*MediaLibraryApi* | [**DeleteMediaRoot**](docs/MediaLibraryApi#deletemediaroot) | **DELETE** /api/2/media/roots/{id} | 
*MediaLibraryApi* | [**DeleteMediaRootPermission**](docs/MediaLibraryApi#deletemediarootpermission) | **DELETE** /api/2/media/root-permissions/{id} | 
*MediaLibraryApi* | [**DeleteMediaTag**](docs/MediaLibraryApi#deletemediatag) | **DELETE** /api/2/media/tags/{id} | 
*MediaLibraryApi* | [**DeleteMediaUpdate**](docs/MediaLibraryApi#deletemediaupdate) | **DELETE** /api/2/media/updates/{id} | 
*MediaLibraryApi* | [**DeleteProxy**](docs/MediaLibraryApi#deleteproxy) | **DELETE** /api/2/media/proxies/{id} | 
*MediaLibraryApi* | [**DeleteProxyProfile**](docs/MediaLibraryApi#deleteproxyprofile) | **DELETE** /api/2/media/proxy-profiles/{id} | 
*MediaLibraryApi* | [**DeleteSubclip**](docs/MediaLibraryApi#deletesubclip) | **DELETE** /api/2/media/subclips/{id} | 
*MediaLibraryApi* | [**DeleteSubclipClipboardEntry**](docs/MediaLibraryApi#deletesubclipclipboardentry) | **DELETE** /api/2/media/subclips/clipboard/{id} | 
*MediaLibraryApi* | [**DiscoverMedia**](docs/MediaLibraryApi#discovermedia) | **POST** /api/2/scanner/discover | 
*MediaLibraryApi* | [**DownloadAssetProxyFile**](docs/MediaLibraryApi#downloadassetproxyfile) | **GET** /api/2/media/assets/{id}/proxy-files/{filename} | 
*MediaLibraryApi* | [**DownloadMediaFile**](docs/MediaLibraryApi#downloadmediafile) | **GET** /api/2/media/files/{id}/download | 
*MediaLibraryApi* | [**DownloadProxy**](docs/MediaLibraryApi#downloadproxy) | **GET** /api/2/media/proxies/{id}/download | 
*MediaLibraryApi* | [**EditorExportXMLForAssset**](docs/MediaLibraryApi#editorexportxmlforassset) | **GET** /api/2/media/editor/asset/{asset_ids}/xml-export | 
*MediaLibraryApi* | [**EditorExportXMLForBundle**](docs/MediaLibraryApi#editorexportxmlforbundle) | **GET** /api/2/media/editor/bundle/{bundle_ids}/xml-export | 
*MediaLibraryApi* | [**EditorExportXMLForProject**](docs/MediaLibraryApi#editorexportxmlforproject) | **GET** /api/2/media/editor/{id}/xml-export | 
*MediaLibraryApi* | [**ExportCommentsForAvid**](docs/MediaLibraryApi#exportcommentsforavid) | **GET** /api/2/media/editor/asset/{asset_id}/{export_format}-export/avid-comments | 
*MediaLibraryApi* | [**ExportEditorTimeline**](docs/MediaLibraryApi#exporteditortimeline) | **POST** /api/2/media/editor/timeline-export | 
*MediaLibraryApi* | [**ForgetDeletedMediaFiles**](docs/MediaLibraryApi#forgetdeletedmediafiles) | **POST** /api/2/media/files/{id}/forget-deleted | 
*MediaLibraryApi* | [**GenerateProxies**](docs/MediaLibraryApi#generateproxies) | **POST** /api/2/media/proxies | 
*MediaLibraryApi* | [**GetAllAssetProjectLinks**](docs/MediaLibraryApi#getallassetprojectlinks) | **GET** /api/2/media/assets/project-links | 
*MediaLibraryApi* | [**GetAllAssetRatings**](docs/MediaLibraryApi#getallassetratings) | **GET** /api/2/media/ratings | 
*MediaLibraryApi* | [**GetAllAssetTapeBackups**](docs/MediaLibraryApi#getallassettapebackups) | **GET** /api/2/media/backups | 
*MediaLibraryApi* | [**GetAllAssets**](docs/MediaLibraryApi#getallassets) | **GET** /api/2/media/assets | 
*MediaLibraryApi* | [**GetAllBundlesForMediaRoot**](docs/MediaLibraryApi#getallbundlesformediaroot) | **GET** /api/2/media/bundles/flat/{root} | 
*MediaLibraryApi* | [**GetAllClickLinks**](docs/MediaLibraryApi#getallclicklinks) | **GET** /api/2/media/assets/click-links | 
*MediaLibraryApi* | [**GetAllComments**](docs/MediaLibraryApi#getallcomments) | **GET** /api/2/media/comments | 
*MediaLibraryApi* | [**GetAllCustomFields**](docs/MediaLibraryApi#getallcustomfields) | **GET** /api/2/media/custom-fields | 
*MediaLibraryApi* | [**GetAllExternalTranscoders**](docs/MediaLibraryApi#getallexternaltranscoders) | **GET** /api/2/media/external-transcoders | 
*MediaLibraryApi* | [**GetAllMarkers**](docs/MediaLibraryApi#getallmarkers) | **GET** /api/2/media/markers | 
*MediaLibraryApi* | [**GetAllMediaFileBundles**](docs/MediaLibraryApi#getallmediafilebundles) | **GET** /api/2/media/bundles | 
*MediaLibraryApi* | [**GetAllMediaFileTemplates**](docs/MediaLibraryApi#getallmediafiletemplates) | **GET** /api/2/media/files/templates | 
*MediaLibraryApi* | [**GetAllMediaFiles**](docs/MediaLibraryApi#getallmediafiles) | **GET** /api/2/media/files | 
*MediaLibraryApi* | [**GetAllMediaFilesForBundles**](docs/MediaLibraryApi#getallmediafilesforbundles) | **POST** /api/2/media/files/for-bundles | 
*MediaLibraryApi* | [**GetAllMediaFilesForMediaRoot**](docs/MediaLibraryApi#getallmediafilesformediaroot) | **GET** /api/2/media/files/flat/{root} | 
*MediaLibraryApi* | [**GetAllMediaRootPermissions**](docs/MediaLibraryApi#getallmediarootpermissions) | **GET** /api/2/media/root-permissions | 
*MediaLibraryApi* | [**GetAllMediaRoots**](docs/MediaLibraryApi#getallmediaroots) | **GET** /api/2/media/roots | 
*MediaLibraryApi* | [**GetAllMediaTags**](docs/MediaLibraryApi#getallmediatags) | **GET** /api/2/media/tags | 
*MediaLibraryApi* | [**GetAllMediaUpdates**](docs/MediaLibraryApi#getallmediaupdates) | **GET** /api/2/media/updates | 
*MediaLibraryApi* | [**GetAllProxyGenerators**](docs/MediaLibraryApi#getallproxygenerators) | **GET** /api/2/media/proxy-generators | 
*MediaLibraryApi* | [**GetAllProxyProfiles**](docs/MediaLibraryApi#getallproxyprofiles) | **GET** /api/2/media/proxy-profiles | 
*MediaLibraryApi* | [**GetAllSubclipClipboardEntries**](docs/MediaLibraryApi#getallsubclipclipboardentries) | **GET** /api/2/media/subclips/clipboard | 
*MediaLibraryApi* | [**GetAllSubclips**](docs/MediaLibraryApi#getallsubclips) | **GET** /api/2/media/subclips | 
*MediaLibraryApi* | [**GetAllTranscoderProfiles**](docs/MediaLibraryApi#getalltranscoderprofiles) | **GET** /api/2/transcoder-profiles | 
*MediaLibraryApi* | [**GetAsset**](docs/MediaLibraryApi#getasset) | **GET** /api/2/media/assets/{id} | 
*MediaLibraryApi* | [**GetAssetRating**](docs/MediaLibraryApi#getassetrating) | **GET** /api/2/media/ratings/{id} | 
*MediaLibraryApi* | [**GetBookmarkedMediaFilesDirectories**](docs/MediaLibraryApi#getbookmarkedmediafilesdirectories) | **GET** /api/2/media/files/bookmarks | 
*MediaLibraryApi* | [**GetComment**](docs/MediaLibraryApi#getcomment) | **GET** /api/2/media/comments/{id} | 
*MediaLibraryApi* | [**GetCustomField**](docs/MediaLibraryApi#getcustomfield) | **GET** /api/2/media/custom-fields/{id} | 
*MediaLibraryApi* | [**GetEasySharingTokenForBundle**](docs/MediaLibraryApi#geteasysharingtokenforbundle) | **GET** /api/2/media/bundles/{id}/easy-sharing-token | 
*MediaLibraryApi* | [**GetEasySharingTokenForDirectory**](docs/MediaLibraryApi#geteasysharingtokenfordirectory) | **GET** /api/2/media/files/{id}/easy-sharing-token | 
*MediaLibraryApi* | [**GetEditorProject**](docs/MediaLibraryApi#geteditorproject) | **GET** /api/2/media/editor/{id} | 
*MediaLibraryApi* | [**GetExternalTranscoder**](docs/MediaLibraryApi#getexternaltranscoder) | **GET** /api/2/media/external-transcoders/{id} | 
*MediaLibraryApi* | [**GetFrame**](docs/MediaLibraryApi#getframe) | **GET** /api/2/media/assets/{id}/frames/{frame} | 
*MediaLibraryApi* | [**GetLatestMediaUpdate**](docs/MediaLibraryApi#getlatestmediaupdate) | **GET** /api/2/media/updates/latest | 
*MediaLibraryApi* | [**GetMarker**](docs/MediaLibraryApi#getmarker) | **GET** /api/2/media/markers/{id} | 
*MediaLibraryApi* | [**GetMediaFile**](docs/MediaLibraryApi#getmediafile) | **GET** /api/2/media/files/{id} | 
*MediaLibraryApi* | [**GetMediaFileBundle**](docs/MediaLibraryApi#getmediafilebundle) | **GET** /api/2/media/bundles/{id} | 
*MediaLibraryApi* | [**GetMediaFileContents**](docs/MediaLibraryApi#getmediafilecontents) | **GET** /api/2/media/files/{id}/contents | 
*MediaLibraryApi* | [**GetMediaFileTemplate**](docs/MediaLibraryApi#getmediafiletemplate) | **GET** /api/2/media/files/templates/{id} | 
*MediaLibraryApi* | [**GetMediaRoot**](docs/MediaLibraryApi#getmediaroot) | **GET** /api/2/media/roots/{id} | 
*MediaLibraryApi* | [**GetMediaRootPermission**](docs/MediaLibraryApi#getmediarootpermission) | **GET** /api/2/media/root-permissions/{id} | 
*MediaLibraryApi* | [**GetMediaTag**](docs/MediaLibraryApi#getmediatag) | **GET** /api/2/media/tags/{id} | 
*MediaLibraryApi* | [**GetMultipleAssets**](docs/MediaLibraryApi#getmultipleassets) | **POST** /api/2/media/assets/multiple | 
*MediaLibraryApi* | [**GetMultipleBundles**](docs/MediaLibraryApi#getmultiplebundles) | **POST** /api/2/media/bundles/multiple | 
*MediaLibraryApi* | [**GetMultipleFiles**](docs/MediaLibraryApi#getmultiplefiles) | **POST** /api/2/media/files/multiple | 
*MediaLibraryApi* | [**GetMyMediaRootPermissions**](docs/MediaLibraryApi#getmymediarootpermissions) | **GET** /api/2/media/root-permissions/mine | 
*MediaLibraryApi* | [**GetMyResolvedMediaRootPermissions**](docs/MediaLibraryApi#getmyresolvedmediarootpermissions) | **GET** /api/2/media/root-permissions/mine/resolved | 
*MediaLibraryApi* | [**GetProxy**](docs/MediaLibraryApi#getproxy) | **GET** /api/2/media/proxies/{id} | 
*MediaLibraryApi* | [**GetProxyGenerator**](docs/MediaLibraryApi#getproxygenerator) | **GET** /api/2/media/proxy-generators/{id} | 
*MediaLibraryApi* | [**GetProxyProfile**](docs/MediaLibraryApi#getproxyprofile) | **GET** /api/2/media/proxy-profiles/{id} | 
*MediaLibraryApi* | [**GetProxyProfileProxyCount**](docs/MediaLibraryApi#getproxyprofileproxycount) | **GET** /api/2/media/proxy-profiles/{id}/proxy-count | 
*MediaLibraryApi* | [**GetSubclip**](docs/MediaLibraryApi#getsubclip) | **GET** /api/2/media/subclips/{id} | 
*MediaLibraryApi* | [**GetTranscoderProfile**](docs/MediaLibraryApi#gettranscoderprofile) | **GET** /api/2/transcoder-profiles/{id} | 
*MediaLibraryApi* | [**GetVantageWorkflows**](docs/MediaLibraryApi#getvantageworkflows) | **GET** /api/2/media/external-transcoders/{id}/workflows | 
*MediaLibraryApi* | [**InstantiateMediaFileTemplate**](docs/MediaLibraryApi#instantiatemediafiletemplate) | **POST** /api/2/media/files/templates/{id}/instantiate | 
*MediaLibraryApi* | [**LocateEditorProjectPaths**](docs/MediaLibraryApi#locateeditorprojectpaths) | **GET** /api/2/media/editor/{id}/locate-paths | 
*MediaLibraryApi* | [**MarkMediaDirectoryAsShowroom**](docs/MediaLibraryApi#markmediadirectoryasshowroom) | **POST** /api/2/media/files/{id}/showroom | 
*MediaLibraryApi* | [**PatchAsset**](docs/MediaLibraryApi#patchasset) | **PATCH** /api/2/media/assets/{id} | 
*MediaLibraryApi* | [**PatchAssetRating**](docs/MediaLibraryApi#patchassetrating) | **PATCH** /api/2/media/ratings/{id} | 
*MediaLibraryApi* | [**PatchComment**](docs/MediaLibraryApi#patchcomment) | **PATCH** /api/2/media/comments/{id} | 
*MediaLibraryApi* | [**PatchCustomField**](docs/MediaLibraryApi#patchcustomfield) | **PATCH** /api/2/media/custom-fields/{id} | 
*MediaLibraryApi* | [**PatchEditorProject**](docs/MediaLibraryApi#patcheditorproject) | **PATCH** /api/2/media/editor/{id} | 
*MediaLibraryApi* | [**PatchExternalTranscoder**](docs/MediaLibraryApi#patchexternaltranscoder) | **PATCH** /api/2/media/external-transcoders/{id} | 
*MediaLibraryApi* | [**PatchMarker**](docs/MediaLibraryApi#patchmarker) | **PATCH** /api/2/media/markers/{id} | 
*MediaLibraryApi* | [**PatchMediaFile**](docs/MediaLibraryApi#patchmediafile) | **PATCH** /api/2/media/files/{id} | 
*MediaLibraryApi* | [**PatchMediaFileTemplate**](docs/MediaLibraryApi#patchmediafiletemplate) | **PATCH** /api/2/media/files/templates/{id} | 
*MediaLibraryApi* | [**PatchMediaRoot**](docs/MediaLibraryApi#patchmediaroot) | **PATCH** /api/2/media/roots/{id} | 
*MediaLibraryApi* | [**PatchMediaRootPermission**](docs/MediaLibraryApi#patchmediarootpermission) | **PATCH** /api/2/media/root-permissions/{id} | 
*MediaLibraryApi* | [**PatchMediaTag**](docs/MediaLibraryApi#patchmediatag) | **PATCH** /api/2/media/tags/{id} | 
*MediaLibraryApi* | [**PatchProxyProfile**](docs/MediaLibraryApi#patchproxyprofile) | **PATCH** /api/2/media/proxy-profiles/{id} | 
*MediaLibraryApi* | [**PatchSubclip**](docs/MediaLibraryApi#patchsubclip) | **PATCH** /api/2/media/subclips/{id} | 
*MediaLibraryApi* | [**RecursivelyTagMediaDirectory**](docs/MediaLibraryApi#recursivelytagmediadirectory) | **POST** /api/2/media/files/{id}/tag | 
*MediaLibraryApi* | [**ReindexMediaDirectory**](docs/MediaLibraryApi#reindexmediadirectory) | **POST** /api/2/media/files/{id}/search-reindex | 
*MediaLibraryApi* | [**RenameCustomField**](docs/MediaLibraryApi#renamecustomfield) | **POST** /api/2/media/custom-fields/{id}/rename | 
*MediaLibraryApi* | [**RenderSequence**](docs/MediaLibraryApi#rendersequence) | **POST** /api/2/media/editor/render | 
*MediaLibraryApi* | [**RenderSubclip**](docs/MediaLibraryApi#rendersubclip) | **POST** /api/2/media/subclips/{id}/render | 
*MediaLibraryApi* | [**RequestMediaScan**](docs/MediaLibraryApi#requestmediascan) | **POST** /api/2/scanner/scan | 
*MediaLibraryApi* | [**ResolveComment**](docs/MediaLibraryApi#resolvecomment) | **POST** /api/2/media/comments/{id}/resolve | 
*MediaLibraryApi* | [**ShareMediaLibraryObjects**](docs/MediaLibraryApi#sharemedialibraryobjects) | **POST** /api/2/media/share | 
*MediaLibraryApi* | [**TestExternalTranscoderConnection**](docs/MediaLibraryApi#testexternaltranscoderconnection) | **POST** /api/2/media/external-transcoders/test-connection | 
*MediaLibraryApi* | [**TransitionWorkflow**](docs/MediaLibraryApi#transitionworkflow) | **POST** /api/2/media/workflow/transition | 
*MediaLibraryApi* | [**UnbookmarkMediaDirectory**](docs/MediaLibraryApi#unbookmarkmediadirectory) | **DELETE** /api/2/media/files/{id}/bookmark | 
*MediaLibraryApi* | [**UnmarkMediaDirectoryAsShowroom**](docs/MediaLibraryApi#unmarkmediadirectoryasshowroom) | **DELETE** /api/2/media/files/{id}/showroom | 
*MediaLibraryApi* | [**UnresolveComment**](docs/MediaLibraryApi#unresolvecomment) | **POST** /api/2/media/comments/{id}/unresolve | 
*MediaLibraryApi* | [**UpdateAsset**](docs/MediaLibraryApi#updateasset) | **PUT** /api/2/media/assets/{id} | 
*MediaLibraryApi* | [**UpdateAssetRating**](docs/MediaLibraryApi#updateassetrating) | **PUT** /api/2/media/ratings/{id} | 
*MediaLibraryApi* | [**UpdateComment**](docs/MediaLibraryApi#updatecomment) | **PUT** /api/2/media/comments/{id} | 
*MediaLibraryApi* | [**UpdateCustomField**](docs/MediaLibraryApi#updatecustomfield) | **PUT** /api/2/media/custom-fields/{id} | 
*MediaLibraryApi* | [**UpdateEditorProject**](docs/MediaLibraryApi#updateeditorproject) | **PUT** /api/2/media/editor/{id} | 
*MediaLibraryApi* | [**UpdateExternalTranscoder**](docs/MediaLibraryApi#updateexternaltranscoder) | **PUT** /api/2/media/external-transcoders/{id} | 
*MediaLibraryApi* | [**UpdateMarker**](docs/MediaLibraryApi#updatemarker) | **PUT** /api/2/media/markers/{id} | 
*MediaLibraryApi* | [**UpdateMediaFile**](docs/MediaLibraryApi#updatemediafile) | **PUT** /api/2/media/files/{id} | 
*MediaLibraryApi* | [**UpdateMediaFileTemplate**](docs/MediaLibraryApi#updatemediafiletemplate) | **PUT** /api/2/media/files/templates/{id} | 
*MediaLibraryApi* | [**UpdateMediaRoot**](docs/MediaLibraryApi#updatemediaroot) | **PUT** /api/2/media/roots/{id} | 
*MediaLibraryApi* | [**UpdateMediaRootPermission**](docs/MediaLibraryApi#updatemediarootpermission) | **PUT** /api/2/media/root-permissions/{id} | 
*MediaLibraryApi* | [**UpdateMediaTag**](docs/MediaLibraryApi#updatemediatag) | **PUT** /api/2/media/tags/{id} | 
*MediaLibraryApi* | [**UpdateProxyProfile**](docs/MediaLibraryApi#updateproxyprofile) | **PUT** /api/2/media/proxy-profiles/{id} | 
*MediaLibraryApi* | [**UpdateSubclip**](docs/MediaLibraryApi#updatesubclip) | **PUT** /api/2/media/subclips/{id} | 
*SatelliteApi* | [**ActivateSatelliteHost**](docs/SatelliteApi#activatesatellitehost) | **POST** /api/2/rdc/hosts/{id}/activate | 
*SatelliteApi* | [**AnnounceSatelliteHost**](docs/SatelliteApi#announcesatellitehost) | **POST** /api/2/rdc/hosts/announce | 
*SatelliteApi* | [**CreateSatelliteSession**](docs/SatelliteApi#createsatellitesession) | **POST** /api/2/rdc/sessions | 
*SatelliteApi* | [**DeleteSatelliteSession**](docs/SatelliteApi#deletesatellitesession) | **DELETE** /api/2/rdc/sessions/{id} | 
*SatelliteApi* | [**GetAllSatelliteHosts**](docs/SatelliteApi#getallsatellitehosts) | **GET** /api/2/rdc/hosts | 
*SatelliteApi* | [**GetAllSatelliteSessions**](docs/SatelliteApi#getallsatellitesessions) | **GET** /api/2/rdc/sessions | 
*SatelliteApi* | [**GetSatelliteHost**](docs/SatelliteApi#getsatellitehost) | **GET** /api/2/rdc/hosts/{id} | 
*SatelliteApi* | [**GetSatelliteSession**](docs/SatelliteApi#getsatellitesession) | **GET** /api/2/rdc/sessions/{id} | 
*StatusApi* | [**GetAlert**](docs/StatusApi#getalert) | **GET** /api/2/alerts/{id} | 
*StatusApi* | [**GetAllAlerts**](docs/StatusApi#getallalerts) | **GET** /api/2/alerts | 
*StatusApi* | [**GetTelegrafStats**](docs/StatusApi#gettelegrafstats) | **GET** /api/2/telegraf-stats | 
*StatusApi* | [**PatchAlert**](docs/StatusApi#patchalert) | **PATCH** /api/2/alerts/{id} | 
*StatusApi* | [**SubmitKapacitorAlert**](docs/StatusApi#submitkapacitoralert) | **POST** /api/2/alerts/submit | 
*StatusApi* | [**UpdateAlert**](docs/StatusApi#updatealert) | **PUT** /api/2/alerts/{id} | 
*StorageApi* | [**ApplyWorkspaceAffinity**](docs/StorageApi#applyworkspaceaffinity) | **POST** /api/2/workspaces/{id}/apply-affinity | 
*StorageApi* | [**BookmarkWorkspace**](docs/StorageApi#bookmarkworkspace) | **POST** /api/2/workspaces/{id}/bookmark | 
*StorageApi* | [**CalculateDirectorySize**](docs/StorageApi#calculatedirectorysize) | **POST** /api/2/filesystem/calculate-directory-size | 
*StorageApi* | [**CheckInIntoWorkspace**](docs/StorageApi#checkinintoworkspace) | **POST** /api/2/workspaces/{id}/check-in | 
*StorageApi* | [**CheckOutOfWorkspace**](docs/StorageApi#checkoutofworkspace) | **POST** /api/2/workspaces/{id}/check-out | 
*StorageApi* | [**CopyFiles**](docs/StorageApi#copyfiles) | **POST** /api/2/filesystem/copy | 
*StorageApi* | [**CreateFile**](docs/StorageApi#createfile) | **POST** /api/2/files | 
*StorageApi* | [**CreatePathQuota**](docs/StorageApi#createpathquota) | **POST** /api/2/volumes/{id}/quotas/path/{relative_path} | 
*StorageApi* | [**CreateProduction**](docs/StorageApi#createproduction) | **POST** /api/2/productions | 
*StorageApi* | [**CreateShare**](docs/StorageApi#createshare) | **POST** /api/2/shares | 
*StorageApi* | [**CreateSnapshot**](docs/StorageApi#createsnapshot) | **POST** /api/2/snapshots | 
*StorageApi* | [**CreateTemplateFolder**](docs/StorageApi#createtemplatefolder) | **POST** /api/2/private/create-template-folder | 
*StorageApi* | [**CreateWorkspace**](docs/StorageApi#createworkspace) | **POST** /api/2/workspaces | 
*StorageApi* | [**CreateWorkspacePermission**](docs/StorageApi#createworkspacepermission) | **POST** /api/2/workspace-permissions | 
*StorageApi* | [**DeleteFile**](docs/StorageApi#deletefile) | **DELETE** /api/2/files/{path} | 
*StorageApi* | [**DeleteFiles**](docs/StorageApi#deletefiles) | **POST** /api/2/filesystem/delete | 
*StorageApi* | [**DeletePathQuota**](docs/StorageApi#deletepathquota) | **DELETE** /api/2/volumes/{id}/quotas/path/{relative_path} | 
*StorageApi* | [**DeleteProduction**](docs/StorageApi#deleteproduction) | **DELETE** /api/2/productions/{id} | 
*StorageApi* | [**DeleteShare**](docs/StorageApi#deleteshare) | **DELETE** /api/2/shares/{id} | 
*StorageApi* | [**DeleteSnapshot**](docs/StorageApi#deletesnapshot) | **DELETE** /api/2/snapshots/{id} | 
*StorageApi* | [**DeleteWorkspace**](docs/StorageApi#deleteworkspace) | **DELETE** /api/2/workspaces/{id} | 
*StorageApi* | [**DeleteWorkspacePermission**](docs/StorageApi#deleteworkspacepermission) | **DELETE** /api/2/workspace-permissions/{id} | 
*StorageApi* | [**GetAllDeletedWorkspaces**](docs/StorageApi#getalldeletedworkspaces) | **GET** /api/2/workspaces/deleted | 
*StorageApi* | [**GetAllProductions**](docs/StorageApi#getallproductions) | **GET** /api/2/productions | 
*StorageApi* | [**GetAllShares**](docs/StorageApi#getallshares) | **GET** /api/2/shares | 
*StorageApi* | [**GetAllSnapshots**](docs/StorageApi#getallsnapshots) | **GET** /api/2/snapshots | 
*StorageApi* | [**GetAllVolumes**](docs/StorageApi#getallvolumes) | **GET** /api/2/volumes | 
*StorageApi* | [**GetAllWorkspacePermissions**](docs/StorageApi#getallworkspacepermissions) | **GET** /api/2/workspace-permissions | 
*StorageApi* | [**GetAllWorkspaces**](docs/StorageApi#getallworkspaces) | **GET** /api/2/workspaces | 
*StorageApi* | [**GetFile**](docs/StorageApi#getfile) | **GET** /api/2/files/{path} | 
*StorageApi* | [**GetGroupQuota**](docs/StorageApi#getgroupquota) | **GET** /api/2/volumes/{id}/quotas/group/{group_id} | 
*StorageApi* | [**GetMyWorkspaces**](docs/StorageApi#getmyworkspaces) | **GET** /api/2/workspaces/mine | 
*StorageApi* | [**GetPathQuota**](docs/StorageApi#getpathquota) | **GET** /api/2/volumes/{id}/quotas/path/{relative_path} | 
*StorageApi* | [**GetProduction**](docs/StorageApi#getproduction) | **GET** /api/2/productions/{id} | 
*StorageApi* | [**GetRootDirectory**](docs/StorageApi#getrootdirectory) | **GET** /api/2/files | 
*StorageApi* | [**GetSambaDfreeString**](docs/StorageApi#getsambadfreestring) | **POST** /api/2/private/dfree | 
*StorageApi* | [**GetShare**](docs/StorageApi#getshare) | **GET** /api/2/shares/{id} | 
*StorageApi* | [**GetSnapshot**](docs/StorageApi#getsnapshot) | **GET** /api/2/snapshots/{id} | 
*StorageApi* | [**GetUserQuota**](docs/StorageApi#getuserquota) | **GET** /api/2/volumes/{id}/quotas/user/{user_id} | 
*StorageApi* | [**GetVolume**](docs/StorageApi#getvolume) | **GET** /api/2/volumes/{id} | 
*StorageApi* | [**GetVolumeActiveConnections**](docs/StorageApi#getvolumeactiveconnections) | **GET** /api/2/volumes/{id}/connections | 
*StorageApi* | [**GetVolumeFileSizeDistribution**](docs/StorageApi#getvolumefilesizedistribution) | **GET** /api/2/volumes/{id}/file-size-distribution | 
*StorageApi* | [**GetVolumeStats**](docs/StorageApi#getvolumestats) | **GET** /api/2/volumes/{id}/stats | 
*StorageApi* | [**GetWorkspace**](docs/StorageApi#getworkspace) | **GET** /api/2/workspaces/{id} | 
*StorageApi* | [**GetWorkspacePermission**](docs/StorageApi#getworkspacepermission) | **GET** /api/2/workspace-permissions/{id} | 
*StorageApi* | [**MoveFiles**](docs/StorageApi#movefiles) | **POST** /api/2/filesystem/move | 
*StorageApi* | [**MoveWorkspace**](docs/StorageApi#moveworkspace) | **POST** /api/2/workspaces/{id}/move | 
*StorageApi* | [**MoveWorkspaceToProduction**](docs/StorageApi#moveworkspacetoproduction) | **POST** /api/2/workspaces/{id}/move-to | 
*StorageApi* | [**PatchFile**](docs/StorageApi#patchfile) | **PATCH** /api/2/files/{path} | 
*StorageApi* | [**PatchProduction**](docs/StorageApi#patchproduction) | **PATCH** /api/2/productions/{id} | 
*StorageApi* | [**PatchShare**](docs/StorageApi#patchshare) | **PATCH** /api/2/shares/{id} | 
*StorageApi* | [**PatchSnapshot**](docs/StorageApi#patchsnapshot) | **PATCH** /api/2/snapshots/{id} | 
*StorageApi* | [**PatchVolume**](docs/StorageApi#patchvolume) | **PATCH** /api/2/volumes/{id} | 
*StorageApi* | [**PatchWorkspace**](docs/StorageApi#patchworkspace) | **PATCH** /api/2/workspaces/{id} | 
*StorageApi* | [**PatchWorkspacePermission**](docs/StorageApi#patchworkspacepermission) | **PATCH** /api/2/workspace-permissions/{id} | 
*StorageApi* | [**RecordStorageTrace**](docs/StorageApi#recordstoragetrace) | **POST** /api/2/filesystem/trace | 
*StorageApi* | [**RepairWorkspacePermissions**](docs/StorageApi#repairworkspacepermissions) | **POST** /api/2/workspaces/{id}/repair-permissions | 
*StorageApi* | [**ShareToHomeWorkspace**](docs/StorageApi#sharetohomeworkspace) | **POST** /api/2/share-to-home-workspace | 
*StorageApi* | [**UnbookmarkWorkspace**](docs/StorageApi#unbookmarkworkspace) | **DELETE** /api/2/workspaces/{id}/bookmark | 
*StorageApi* | [**UnzipFile**](docs/StorageApi#unzipfile) | **POST** /api/2/filesystem/unzip | 
*StorageApi* | [**UpdateGroupQuota**](docs/StorageApi#updategroupquota) | **PUT** /api/2/volumes/{id}/quotas/group/{group_id} | 
*StorageApi* | [**UpdatePathQuota**](docs/StorageApi#updatepathquota) | **PUT** /api/2/volumes/{id}/quotas/path/{relative_path} | 
*StorageApi* | [**UpdateProduction**](docs/StorageApi#updateproduction) | **PUT** /api/2/productions/{id} | 
*StorageApi* | [**UpdateShare**](docs/StorageApi#updateshare) | **PUT** /api/2/shares/{id} | 
*StorageApi* | [**UpdateSnapshot**](docs/StorageApi#updatesnapshot) | **PUT** /api/2/snapshots/{id} | 
*StorageApi* | [**UpdateUserQuota**](docs/StorageApi#updateuserquota) | **PUT** /api/2/volumes/{id}/quotas/user/{user_id} | 
*StorageApi* | [**UpdateVolume**](docs/StorageApi#updatevolume) | **PUT** /api/2/volumes/{id} | 
*StorageApi* | [**UpdateWorkspace**](docs/StorageApi#updateworkspace) | **PUT** /api/2/workspaces/{id} | 
*StorageApi* | [**UpdateWorkspacePermission**](docs/StorageApi#updateworkspacepermission) | **PUT** /api/2/workspace-permissions/{id} | 
*StorageApi* | [**ZipFiles**](docs/StorageApi#zipfiles) | **POST** /api/2/filesystem/zip | 
*TapeArchiveApi* | [**ArchiveToTape**](docs/TapeArchiveApi#archivetotape) | **POST** /api/2/archive/tape/archive | 
*TapeArchiveApi* | [**CancelAllTapeArchiveJobs**](docs/TapeArchiveApi#cancelalltapearchivejobs) | **POST** /api/2/archive/tape/jobs/cancel-all | 
*TapeArchiveApi* | [**CheckTape**](docs/TapeArchiveApi#checktape) | **POST** /api/2/archive/tape/library/check | 
*TapeArchiveApi* | [**CreateTape**](docs/TapeArchiveApi#createtape) | **POST** /api/2/archive/tape/tapes | 
*TapeArchiveApi* | [**CreateTapeGroup**](docs/TapeArchiveApi#createtapegroup) | **POST** /api/2/archive/tape/groups | 
*TapeArchiveApi* | [**DeleteTape**](docs/TapeArchiveApi#deletetape) | **DELETE** /api/2/archive/tape/tapes/{id} | 
*TapeArchiveApi* | [**DeleteTapeArchiveJob**](docs/TapeArchiveApi#deletetapearchivejob) | **DELETE** /api/2/archive/tape/jobs/{id} | 
*TapeArchiveApi* | [**DeleteTapeGroup**](docs/TapeArchiveApi#deletetapegroup) | **DELETE** /api/2/archive/tape/groups/{id} | 
*TapeArchiveApi* | [**FormatTape**](docs/TapeArchiveApi#formattape) | **POST** /api/2/archive/tape/library/format | 
*TapeArchiveApi* | [**GetAllArchivedFileEntries**](docs/TapeArchiveApi#getallarchivedfileentries) | **GET** /api/2/archive/tape/files | 
*TapeArchiveApi* | [**GetAllTapeArchiveJobs**](docs/TapeArchiveApi#getalltapearchivejobs) | **GET** /api/2/archive/tape/jobs | 
*TapeArchiveApi* | [**GetAllTapeGroups**](docs/TapeArchiveApi#getalltapegroups) | **GET** /api/2/archive/tape/groups | 
*TapeArchiveApi* | [**GetAllTapes**](docs/TapeArchiveApi#getalltapes) | **GET** /api/2/archive/tape/tapes | 
*TapeArchiveApi* | [**GetArchivedFileEntry**](docs/TapeArchiveApi#getarchivedfileentry) | **GET** /api/2/archive/tape/files/{id} | 
*TapeArchiveApi* | [**GetTape**](docs/TapeArchiveApi#gettape) | **GET** /api/2/archive/tape/tapes/{id} | 
*TapeArchiveApi* | [**GetTapeArchiveJob**](docs/TapeArchiveApi#gettapearchivejob) | **GET** /api/2/archive/tape/jobs/{id} | 
*TapeArchiveApi* | [**GetTapeArchiveJobSources**](docs/TapeArchiveApi#gettapearchivejobsources) | **GET** /api/2/archive/tape/jobs/{id}/sources | 
*TapeArchiveApi* | [**GetTapeGroup**](docs/TapeArchiveApi#gettapegroup) | **GET** /api/2/archive/tape/groups/{id} | 
*TapeArchiveApi* | [**GetTapeLibraryState**](docs/TapeArchiveApi#gettapelibrarystate) | **GET** /api/2/archive/tape/library | 
*TapeArchiveApi* | [**LoadTape**](docs/TapeArchiveApi#loadtape) | **POST** /api/2/archive/tape/library/load | 
*TapeArchiveApi* | [**MoveTape**](docs/TapeArchiveApi#movetape) | **POST** /api/2/archive/tape/library/move | 
*TapeArchiveApi* | [**PatchTape**](docs/TapeArchiveApi#patchtape) | **PATCH** /api/2/archive/tape/tapes/{id} | 
*TapeArchiveApi* | [**PatchTapeGroup**](docs/TapeArchiveApi#patchtapegroup) | **PATCH** /api/2/archive/tape/groups/{id} | 
*TapeArchiveApi* | [**PauseTapeArchiveJob**](docs/TapeArchiveApi#pausetapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/pause | 
*TapeArchiveApi* | [**RefreshTapeLibraryState**](docs/TapeArchiveApi#refreshtapelibrarystate) | **POST** /api/2/archive/tape/library/refresh | 
*TapeArchiveApi* | [**ReindexTape**](docs/TapeArchiveApi#reindextape) | **POST** /api/2/archive/tape/library/reindex | 
*TapeArchiveApi* | [**RemoveFinishedTapeArchiveJobs**](docs/TapeArchiveApi#removefinishedtapearchivejobs) | **POST** /api/2/archive/tape/jobs/remove-finished | 
*TapeArchiveApi* | [**RestartTapeArchiveJob**](docs/TapeArchiveApi#restarttapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/restart | 
*TapeArchiveApi* | [**RestoreFromTape**](docs/TapeArchiveApi#restorefromtape) | **POST** /api/2/archive/tape/restore | 
*TapeArchiveApi* | [**ResumeTapeArchiveJob**](docs/TapeArchiveApi#resumetapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/resume | 
*TapeArchiveApi* | [**SearchTapeArchive**](docs/TapeArchiveApi#searchtapearchive) | **POST** /api/2/archive/tape/search | 
*TapeArchiveApi* | [**UnloadTape**](docs/TapeArchiveApi#unloadtape) | **POST** /api/2/archive/tape/library/unload | 
*TapeArchiveApi* | [**UpdateTape**](docs/TapeArchiveApi#updatetape) | **PUT** /api/2/archive/tape/tapes/{id} | 
*TapeArchiveApi* | [**UpdateTapeGroup**](docs/TapeArchiveApi#updatetapegroup) | **PUT** /api/2/archive/tape/groups/{id} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AWSAccount](docs/AWSAccount)
 - [Model.AWSAccountPartialUpdate](docs/AWSAccountPartialUpdate)
 - [Model.AddAssetsToClickGallery](docs/AddAssetsToClickGallery)
 - [Model.Address](docs/Address)
 - [Model.Alert](docs/Alert)
 - [Model.AlertPartialUpdate](docs/AlertPartialUpdate)
 - [Model.AllMediaFilesForBundlesRequest](docs/AllMediaFilesForBundlesRequest)
 - [Model.ArchiveEndpointRequest](docs/ArchiveEndpointRequest)
 - [Model.ArgumentType](docs/ArgumentType)
 - [Model.Asset](docs/Asset)
 - [Model.AssetBackup](docs/AssetBackup)
 - [Model.AssetCloudLink](docs/AssetCloudLink)
 - [Model.AssetMini](docs/AssetMini)
 - [Model.AssetMiniReference](docs/AssetMiniReference)
 - [Model.AssetPartialUpdate](docs/AssetPartialUpdate)
 - [Model.AssetProjectLink](docs/AssetProjectLink)
 - [Model.AssetRating](docs/AssetRating)
 - [Model.AssetRatingPartialUpdate](docs/AssetRatingPartialUpdate)
 - [Model.AuthLoginEndpointRequest](docs/AuthLoginEndpointRequest)
 - [Model.AuthLoginEndpointResponse](docs/AuthLoginEndpointResponse)
 - [Model.Backend](docs/Backend)
 - [Model.BackendProperties](docs/BackendProperties)
 - [Model.BasicFile](docs/BasicFile)
 - [Model.BeeGFSNode](docs/BeeGFSNode)
 - [Model.BeeGFSTarget](docs/BeeGFSTarget)
 - [Model.CPUStat](docs/CPUStat)
 - [Model.Certificate](docs/Certificate)
 - [Model.ChangeOwnPasswordRequest](docs/ChangeOwnPasswordRequest)
 - [Model.ChangePasswordRequest](docs/ChangePasswordRequest)
 - [Model.CheckConnectivityEndpointResponse](docs/CheckConnectivityEndpointResponse)
 - [Model.ClickBackgroundUploadEndpointRequest](docs/ClickBackgroundUploadEndpointRequest)
 - [Model.ClickGallery](docs/ClickGallery)
 - [Model.ClickGalleryLink](docs/ClickGalleryLink)
 - [Model.ClickLinkUser](docs/ClickLinkUser)
 - [Model.ClickStartUploadEndpointRequest](docs/ClickStartUploadEndpointRequest)
 - [Model.ClientSession](docs/ClientSession)
 - [Model.ClientsEndpointResponse](docs/ClientsEndpointResponse)
 - [Model.CloudConnection](docs/CloudConnection)
 - [Model.Comment](docs/Comment)
 - [Model.CommentPartialUpdate](docs/CommentPartialUpdate)
 - [Model.CreateDownloadArchive](docs/CreateDownloadArchive)
 - [Model.CreateHomeWorkspaceRequest](docs/CreateHomeWorkspaceRequest)
 - [Model.CreatePathQuotaRequest](docs/CreatePathQuotaRequest)
 - [Model.CreateTemplateFolderEndpointRequest](docs/CreateTemplateFolderEndpointRequest)
 - [Model.CustomField](docs/CustomField)
 - [Model.CustomFieldPartialUpdate](docs/CustomFieldPartialUpdate)
 - [Model.CustomFieldReference](docs/CustomFieldReference)
 - [Model.DeletedWorkspace](docs/DeletedWorkspace)
 - [Model.Download](docs/Download)
 - [Model.DownloadArchive](docs/DownloadArchive)
 - [Model.DownloadArchivePartialUpdate](docs/DownloadArchivePartialUpdate)
 - [Model.EditorProject](docs/EditorProject)
 - [Model.EditorProjectPartialUpdate](docs/EditorProjectPartialUpdate)
 - [Model.ElementsGroup](docs/ElementsGroup)
 - [Model.ElementsGroupDetail](docs/ElementsGroupDetail)
 - [Model.ElementsGroupDetailPartialUpdate](docs/ElementsGroupDetailPartialUpdate)
 - [Model.ElementsGroupReference](docs/ElementsGroupReference)
 - [Model.ElementsUser](docs/ElementsUser)
 - [Model.ElementsUserDetail](docs/ElementsUserDetail)
 - [Model.ElementsUserDetailPartialUpdate](docs/ElementsUserDetailPartialUpdate)
 - [Model.ElementsUserMini](docs/ElementsUserMini)
 - [Model.ElementsUserMiniReference](docs/ElementsUserMiniReference)
 - [Model.ElementsUserProfile](docs/ElementsUserProfile)
 - [Model.ElementsUserProfilePartialUpdate](docs/ElementsUserProfilePartialUpdate)
 - [Model.ElementsUserReference](docs/ElementsUserReference)
 - [Model.ElementsVersion](docs/ElementsVersion)
 - [Model.EmailPreview](docs/EmailPreview)
 - [Model.EnableTOTPRequest](docs/EnableTOTPRequest)
 - [Model.Event](docs/Event)
 - [Model.ExternalTranscoder](docs/ExternalTranscoder)
 - [Model.ExternalTranscoderPartialUpdate](docs/ExternalTranscoderPartialUpdate)
 - [Model.FSProperties](docs/FSProperties)
 - [Model.FileCopyEndpointRequest](docs/FileCopyEndpointRequest)
 - [Model.FileDeleteEndpointRequest](docs/FileDeleteEndpointRequest)
 - [Model.FileMoveEndpointRequest](docs/FileMoveEndpointRequest)
 - [Model.FilePartialUpdate](docs/FilePartialUpdate)
 - [Model.FileSizeDistribution](docs/FileSizeDistribution)
 - [Model.FileSizeDistributionItem](docs/FileSizeDistributionItem)
 - [Model.FileSizeEndpointResponse](docs/FileSizeEndpointResponse)
 - [Model.FileUnzipEndpointRequest](docs/FileUnzipEndpointRequest)
 - [Model.FileZipEndpointRequest](docs/FileZipEndpointRequest)
 - [Model.FilesystemFile](docs/FilesystemFile)
 - [Model.FilesystemTraceEndpointRequest](docs/FilesystemTraceEndpointRequest)
 - [Model.FilesystemTraceEndpointResponse](docs/FilesystemTraceEndpointResponse)
 - [Model.FinishUploadEndpointRequest](docs/FinishUploadEndpointRequest)
 - [Model.GeneratePasswordEndpointResponse](docs/GeneratePasswordEndpointResponse)
 - [Model.GenerateProxiesRequest](docs/GenerateProxiesRequest)
 - [Model.GetMultipleBundlesRequest](docs/GetMultipleBundlesRequest)
 - [Model.GetMultipleFilesRequest](docs/GetMultipleFilesRequest)
 - [Model.GlobalAlert](docs/GlobalAlert)
 - [Model.IOStat](docs/IOStat)
 - [Model.ImpersonationEndpointRequest](docs/ImpersonationEndpointRequest)
 - [Model.InlineResponse200](docs/InlineResponse200)
 - [Model.InlineResponse2001](docs/InlineResponse2001)
 - [Model.InlineResponse2002](docs/InlineResponse2002)
 - [Model.InlineResponse2003](docs/InlineResponse2003)
 - [Model.InlineResponse2004](docs/InlineResponse2004)
 - [Model.InstantiateFileTemplateRequest](docs/InstantiateFileTemplateRequest)
 - [Model.Interface](docs/Interface)
 - [Model.Ipmi](docs/Ipmi)
 - [Model.Job](docs/Job)
 - [Model.JobPartialUpdate](docs/JobPartialUpdate)
 - [Model.JobReference](docs/JobReference)
 - [Model.KapacitorAlert](docs/KapacitorAlert)
 - [Model.LDAPServer](docs/LDAPServer)
 - [Model.LDAPServerGroup](docs/LDAPServerGroup)
 - [Model.LDAPServerGroups](docs/LDAPServerGroups)
 - [Model.LDAPServerReference](docs/LDAPServerReference)
 - [Model.LDAPServerUser](docs/LDAPServerUser)
 - [Model.LDAPServerUsers](docs/LDAPServerUsers)
 - [Model.License](docs/License)
 - [Model.ListBuckets](docs/ListBuckets)
 - [Model.ListTopics](docs/ListTopics)
 - [Model.LizardFSDisk](docs/LizardFSDisk)
 - [Model.LizardFSNode](docs/LizardFSNode)
 - [Model.LocateResult](docs/LocateResult)
 - [Model.Marker](docs/Marker)
 - [Model.MarkerPartialUpdate](docs/MarkerPartialUpdate)
 - [Model.MediaFile](docs/MediaFile)
 - [Model.MediaFileBundle](docs/MediaFileBundle)
 - [Model.MediaFileBundleMiniReference](docs/MediaFileBundleMiniReference)
 - [Model.MediaFileContents](docs/MediaFileContents)
 - [Model.MediaFileMini](docs/MediaFileMini)
 - [Model.MediaFilePartialUpdate](docs/MediaFilePartialUpdate)
 - [Model.MediaFileReference](docs/MediaFileReference)
 - [Model.MediaFileTemplate](docs/MediaFileTemplate)
 - [Model.MediaFileTemplatePartialUpdate](docs/MediaFileTemplatePartialUpdate)
 - [Model.MediaLibraryDeleteRequest](docs/MediaLibraryDeleteRequest)
 - [Model.MediaLibraryShareRequest](docs/MediaLibraryShareRequest)
 - [Model.MediaRoot](docs/MediaRoot)
 - [Model.MediaRootMini](docs/MediaRootMini)
 - [Model.MediaRootMiniReference](docs/MediaRootMiniReference)
 - [Model.MediaRootPartialUpdate](docs/MediaRootPartialUpdate)
 - [Model.MediaRootPermission](docs/MediaRootPermission)
 - [Model.MediaRootPermissionAccessOptions](docs/MediaRootPermissionAccessOptions)
 - [Model.MediaRootPermissionPartialUpdate](docs/MediaRootPermissionPartialUpdate)
 - [Model.MediaUpdate](docs/MediaUpdate)
 - [Model.MemberPreview](docs/MemberPreview)
 - [Model.MetadataItem](docs/MetadataItem)
 - [Model.MoveWorkspaceRequest](docs/MoveWorkspaceRequest)
 - [Model.MultipleAssetsRequest](docs/MultipleAssetsRequest)
 - [Model.NTPServer](docs/NTPServer)
 - [Model.NTPServerPartialUpdate](docs/NTPServerPartialUpdate)
 - [Model.NetStat](docs/NetStat)
 - [Model.OneTimeAccessToken](docs/OneTimeAccessToken)
 - [Model.OneTimeAccessTokenActivity](docs/OneTimeAccessTokenActivity)
 - [Model.OneTimeAccessTokenSharedObject](docs/OneTimeAccessTokenSharedObject)
 - [Model.Parameters](docs/Parameters)
 - [Model.PasswordResetEndpointRequest](docs/PasswordResetEndpointRequest)
 - [Model.Path](docs/Path)
 - [Model.PathInput](docs/PathInput)
 - [Model.Production](docs/Production)
 - [Model.ProductionPartialUpdate](docs/ProductionPartialUpdate)
 - [Model.ProductionReference](docs/ProductionReference)
 - [Model.Proxy](docs/Proxy)
 - [Model.ProxyCount](docs/ProxyCount)
 - [Model.ProxyGenerator](docs/ProxyGenerator)
 - [Model.ProxyGeneratorProperties](docs/ProxyGeneratorProperties)
 - [Model.ProxyProfile](docs/ProxyProfile)
 - [Model.ProxyProfileMini](docs/ProxyProfileMini)
 - [Model.ProxyProfilePartialUpdate](docs/ProxyProfilePartialUpdate)
 - [Model.PythonEnvironment](docs/PythonEnvironment)
 - [Model.Queue](docs/Queue)
 - [Model.Quota](docs/Quota)
 - [Model.RAMStat](docs/RAMStat)
 - [Model.RDCActivation](docs/RDCActivation)
 - [Model.RDCHost](docs/RDCHost)
 - [Model.RDCSession](docs/RDCSession)
 - [Model.RDCSessionCreate](docs/RDCSessionCreate)
 - [Model.RegisterUploadEndpointRequest](docs/RegisterUploadEndpointRequest)
 - [Model.RegisterUploadMetadataEndpointRequest](docs/RegisterUploadMetadataEndpointRequest)
 - [Model.ReleaseNotesEndpointResponse](docs/ReleaseNotesEndpointResponse)
 - [Model.RenameCustomFieldRequest](docs/RenameCustomFieldRequest)
 - [Model.RenderEndpointRequest](docs/RenderEndpointRequest)
 - [Model.RenderRequest](docs/RenderRequest)
 - [Model.RestoreEndpointRequest](docs/RestoreEndpointRequest)
 - [Model.SAMLProviderMini](docs/SAMLProviderMini)
 - [Model.SMTPConfiguration](docs/SMTPConfiguration)
 - [Model.SNFSStripeGroup](docs/SNFSStripeGroup)
 - [Model.ScannerDiscoverEndpointRequest](docs/ScannerDiscoverEndpointRequest)
 - [Model.ScannerScanEndpointRequest](docs/ScannerScanEndpointRequest)
 - [Model.Schedule](docs/Schedule)
 - [Model.SchedulePartialUpdate](docs/SchedulePartialUpdate)
 - [Model.ScheduleReference](docs/ScheduleReference)
 - [Model.SearchEndpointRequest](docs/SearchEndpointRequest)
 - [Model.SearchEndpointResponse](docs/SearchEndpointResponse)
 - [Model.SendLinkEmailRequest](docs/SendLinkEmailRequest)
 - [Model.Sensor](docs/Sensor)
 - [Model.Sensors](docs/Sensors)
 - [Model.ServiceStatus](docs/ServiceStatus)
 - [Model.Share](docs/Share)
 - [Model.SharePartialUpdate](docs/SharePartialUpdate)
 - [Model.ShareToHomeWorkspaceEndpointRequest](docs/ShareToHomeWorkspaceEndpointRequest)
 - [Model.SlackChannel](docs/SlackChannel)
 - [Model.SlackConnection](docs/SlackConnection)
 - [Model.SlackConnectionPartialUpdate](docs/SlackConnectionPartialUpdate)
 - [Model.SlackConnectionStatus](docs/SlackConnectionStatus)
 - [Model.SlackEmoji](docs/SlackEmoji)
 - [Model.SlackMessage](docs/SlackMessage)
 - [Model.SlackUser](docs/SlackUser)
 - [Model.Snapshot](docs/Snapshot)
 - [Model.SnapshotPartialUpdate](docs/SnapshotPartialUpdate)
 - [Model.SolrReindexEndpointResponse](docs/SolrReindexEndpointResponse)
 - [Model.StartJobRequest](docs/StartJobRequest)
 - [Model.StartTaskRequest](docs/StartTaskRequest)
 - [Model.Stats](docs/Stats)
 - [Model.StorNextConnection](docs/StorNextConnection)
 - [Model.StorNextConnections](docs/StorNextConnections)
 - [Model.StorNextLicenseCheckEndpointResponse](docs/StorNextLicenseCheckEndpointResponse)
 - [Model.StorNextLicenseEndpointResponse](docs/StorNextLicenseEndpointResponse)
 - [Model.StorageNode](docs/StorageNode)
 - [Model.StorageNodeMini](docs/StorageNodeMini)
 - [Model.StorageNodeStatus](docs/StorageNodeStatus)
 - [Model.StornextLicense](docs/StornextLicense)
 - [Model.StornextManagerAttributes](docs/StornextManagerAttributes)
 - [Model.Subclip](docs/Subclip)
 - [Model.SubclipClipboardEntry](docs/SubclipClipboardEntry)
 - [Model.SubclipPartialUpdate](docs/SubclipPartialUpdate)
 - [Model.SubclipReference](docs/SubclipReference)
 - [Model.Subtask](docs/Subtask)
 - [Model.SubtaskPartialUpdate](docs/SubtaskPartialUpdate)
 - [Model.SubtaskReference](docs/SubtaskReference)
 - [Model.SyncTOTP](docs/SyncTOTP)
 - [Model.SyncTOTPRequest](docs/SyncTOTPRequest)
 - [Model.SystemInfoEndpointResponse](docs/SystemInfoEndpointResponse)
 - [Model.Tag](docs/Tag)
 - [Model.TagMediaDirectoryRequest](docs/TagMediaDirectoryRequest)
 - [Model.TagPartialUpdate](docs/TagPartialUpdate)
 - [Model.TagReference](docs/TagReference)
 - [Model.Tape](docs/Tape)
 - [Model.TapeFile](docs/TapeFile)
 - [Model.TapeGroup](docs/TapeGroup)
 - [Model.TapeGroupPartialUpdate](docs/TapeGroupPartialUpdate)
 - [Model.TapeJob](docs/TapeJob)
 - [Model.TapeJobSource](docs/TapeJobSource)
 - [Model.TapeLibraryEndpointResponse](docs/TapeLibraryEndpointResponse)
 - [Model.TapeLibraryFormatEndpointRequest](docs/TapeLibraryFormatEndpointRequest)
 - [Model.TapeLibraryFsckEndpointRequest](docs/TapeLibraryFsckEndpointRequest)
 - [Model.TapeLibraryLoadEndpointRequest](docs/TapeLibraryLoadEndpointRequest)
 - [Model.TapeLibraryMoveEndpointRequest](docs/TapeLibraryMoveEndpointRequest)
 - [Model.TapeLibraryReindexEndpointRequest](docs/TapeLibraryReindexEndpointRequest)
 - [Model.TapeLibrarySlot](docs/TapeLibrarySlot)
 - [Model.TapeLibraryUnloadEndpointRequest](docs/TapeLibraryUnloadEndpointRequest)
 - [Model.TapePartialUpdate](docs/TapePartialUpdate)
 - [Model.TapeReference](docs/TapeReference)
 - [Model.TaskInfo](docs/TaskInfo)
 - [Model.TaskLog](docs/TaskLog)
 - [Model.TaskProgress](docs/TaskProgress)
 - [Model.TaskType](docs/TaskType)
 - [Model.TasksSummary](docs/TasksSummary)
 - [Model.TeamsConnection](docs/TeamsConnection)
 - [Model.TeamsConnectionPartialUpdate](docs/TeamsConnectionPartialUpdate)
 - [Model.TeamsConnectionStatus](docs/TeamsConnectionStatus)
 - [Model.TeamsMessage](docs/TeamsMessage)
 - [Model.TeamsRecipient](docs/TeamsRecipient)
 - [Model.TestAWSCredentialsRequest](docs/TestAWSCredentialsRequest)
 - [Model.TestAWSCredentialsResponse](docs/TestAWSCredentialsResponse)
 - [Model.TestExternalTranscoderConnectionRequest](docs/TestExternalTranscoderConnectionRequest)
 - [Model.TestExternalTranscoderConnectionResponse](docs/TestExternalTranscoderConnectionResponse)
 - [Model.TestSMTP](docs/TestSMTP)
 - [Model.Ticket](docs/Ticket)
 - [Model.TimeEndpointRequest](docs/TimeEndpointRequest)
 - [Model.TimeEndpointResponse](docs/TimeEndpointResponse)
 - [Model.TimeSyncEndpointRequest](docs/TimeSyncEndpointRequest)
 - [Model.TimeSyncEndpointResponse](docs/TimeSyncEndpointResponse)
 - [Model.TimelineExportRequest](docs/TimelineExportRequest)
 - [Model.Timezone](docs/Timezone)
 - [Model.TraceNode](docs/TraceNode)
 - [Model.TranscoderProfile](docs/TranscoderProfile)
 - [Model.TypeDocumentation](docs/TypeDocumentation)
 - [Model.UpdateQuotaRequest](docs/UpdateQuotaRequest)
 - [Model.UploadChunkEndpointRequest](docs/UploadChunkEndpointRequest)
 - [Model.UserPreviewRequest](docs/UserPreviewRequest)
 - [Model.UserPreviewResponse](docs/UserPreviewResponse)
 - [Model.VantageWorkflow](docs/VantageWorkflow)
 - [Model.VantageWorkflows](docs/VantageWorkflows)
 - [Model.Volume](docs/Volume)
 - [Model.VolumeBeeGFSStatus](docs/VolumeBeeGFSStatus)
 - [Model.VolumeLizardFSStatus](docs/VolumeLizardFSStatus)
 - [Model.VolumeMini](docs/VolumeMini)
 - [Model.VolumeMiniReference](docs/VolumeMiniReference)
 - [Model.VolumePartialUpdate](docs/VolumePartialUpdate)
 - [Model.VolumeReference](docs/VolumeReference)
 - [Model.VolumeSNFSStatus](docs/VolumeSNFSStatus)
 - [Model.VolumeStat](docs/VolumeStat)
 - [Model.VolumeStats](docs/VolumeStats)
 - [Model.VolumeStatus](docs/VolumeStatus)
 - [Model.WorkflowTransitionRequest](docs/WorkflowTransitionRequest)
 - [Model.WorkflowTransitionResponse](docs/WorkflowTransitionResponse)
 - [Model.Workspace](docs/Workspace)
 - [Model.WorkspaceCheckIn](docs/WorkspaceCheckIn)
 - [Model.WorkspaceEndpoint](docs/WorkspaceEndpoint)
 - [Model.WorkspaceMoveToRequest](docs/WorkspaceMoveToRequest)
 - [Model.WorkspacePartialUpdate](docs/WorkspacePartialUpdate)
 - [Model.WorkspacePermission](docs/WorkspacePermission)
 - [Model.WorkspacePermissionPartialUpdate](docs/WorkspacePermissionPartialUpdate)
 - [Model.WorkspaceResolvedPermission](docs/WorkspaceResolvedPermission)
 - [Model.Workstation](docs/Workstation)
 - [Model.WorkstationPartialUpdate](docs/WorkstationPartialUpdate)

