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
*AWSApi* | [**CreateAWSAccount**](docs/AWSApi.md#createawsaccount) | **POST** /api/2/aws-accounts | 
*AWSApi* | [**DeleteAWSAccount**](docs/AWSApi.md#deleteawsaccount) | **DELETE** /api/2/aws-accounts/{id} | 
*AWSApi* | [**GetAWSAccount**](docs/AWSApi.md#getawsaccount) | **GET** /api/2/aws-accounts/{id} | 
*AWSApi* | [**GetAWSAccountBuckets**](docs/AWSApi.md#getawsaccountbuckets) | **GET** /api/2/aws-accounts/{id}/buckets | 
*AWSApi* | [**GetAWSAccountSNSTopics**](docs/AWSApi.md#getawsaccountsnstopics) | **GET** /api/2/aws-accounts/{id}/sns/topics | 
*AWSApi* | [**GetAllAWSAccounts**](docs/AWSApi.md#getallawsaccounts) | **GET** /api/2/aws-accounts | 
*AWSApi* | [**PatchAWSAccount**](docs/AWSApi.md#patchawsaccount) | **PATCH** /api/2/aws-accounts/{id} | 
*AWSApi* | [**TestAWSAccountCredentials**](docs/AWSApi.md#testawsaccountcredentials) | **POST** /api/2/aws-accounts/test-credentials | 
*AWSApi* | [**UpdateAWSAccount**](docs/AWSApi.md#updateawsaccount) | **PUT** /api/2/aws-accounts/{id} | 
*AuthApi* | [**CheckAuthTicket**](docs/AuthApi.md#checkauthticket) | **POST** /api/2/auth/ticket/check | 
*AuthApi* | [**CreateAuthTicket**](docs/AuthApi.md#createauthticket) | **POST** /api/2/auth/ticket | 
*AuthApi* | [**DeleteAccessToken**](docs/AuthApi.md#deleteaccesstoken) | **DELETE** /api/2/auth/access-tokens/{id} | 
*AuthApi* | [**GeneratePassword**](docs/AuthApi.md#generatepassword) | **POST** /api/2/auth/generate-password | 
*AuthApi* | [**GetAccessToken**](docs/AuthApi.md#getaccesstoken) | **GET** /api/2/auth/access-tokens/{id} | 
*AuthApi* | [**GetAllAccessTokens**](docs/AuthApi.md#getallaccesstokens) | **GET** /api/2/auth/access-tokens | 
*AuthApi* | [**Login**](docs/AuthApi.md#login) | **POST** /api/2/auth/login | 
*AuthApi* | [**Logout**](docs/AuthApi.md#logout) | **POST** /api/2/auth/logout | 
*AuthApi* | [**ResetPassword**](docs/AuthApi.md#resetpassword) | **POST** /api/2/auth/reset-password | 
*AuthApi* | [**SendAccessTokenEmailNotification**](docs/AuthApi.md#sendaccesstokenemailnotification) | **POST** /api/2/auth/access-tokens/{id}/email | 
*AuthApi* | [**StartImpersonation**](docs/AuthApi.md#startimpersonation) | **POST** /api/2/auth/impersonation | 
*AuthApi* | [**StopImpersonation**](docs/AuthApi.md#stopimpersonation) | **POST** /api/2/auth/impersonation/stop | 
*AutomationApi* | [**AbortTask**](docs/AutomationApi.md#aborttask) | **POST** /api/2/tasks/{id}/abort | 
*AutomationApi* | [**CreateJob**](docs/AutomationApi.md#createjob) | **POST** /api/2/jobs | 
*AutomationApi* | [**CreateSchedule**](docs/AutomationApi.md#createschedule) | **POST** /api/2/schedules | 
*AutomationApi* | [**CreateSubtask**](docs/AutomationApi.md#createsubtask) | **POST** /api/2/subtasks | 
*AutomationApi* | [**DeleteFinishedTasks**](docs/AutomationApi.md#deletefinishedtasks) | **DELETE** /api/2/tasks/finished | 
*AutomationApi* | [**DeleteJob**](docs/AutomationApi.md#deletejob) | **DELETE** /api/2/jobs/{id} | 
*AutomationApi* | [**DeleteSchedule**](docs/AutomationApi.md#deleteschedule) | **DELETE** /api/2/schedules/{id} | 
*AutomationApi* | [**DeleteSubtask**](docs/AutomationApi.md#deletesubtask) | **DELETE** /api/2/subtasks/{id} | 
*AutomationApi* | [**DeleteTask**](docs/AutomationApi.md#deletetask) | **DELETE** /api/2/tasks/{id} | 
*AutomationApi* | [**DownloadAllTaskLogs**](docs/AutomationApi.md#downloadalltasklogs) | **GET** /api/2/tasks/logs/download | 
*AutomationApi* | [**DownloadTaskLog**](docs/AutomationApi.md#downloadtasklog) | **GET** /api/2/tasks/{id}/log/download | 
*AutomationApi* | [**GetAllEvents**](docs/AutomationApi.md#getallevents) | **GET** /api/2/events | 
*AutomationApi* | [**GetAllJobs**](docs/AutomationApi.md#getalljobs) | **GET** /api/2/jobs | 
*AutomationApi* | [**GetAllSchedules**](docs/AutomationApi.md#getallschedules) | **GET** /api/2/schedules | 
*AutomationApi* | [**GetAllSubtasks**](docs/AutomationApi.md#getallsubtasks) | **GET** /api/2/subtasks | 
*AutomationApi* | [**GetAllTaskQueues**](docs/AutomationApi.md#getalltaskqueues) | **GET** /api/2/tasks/queues | 
*AutomationApi* | [**GetAllTaskTypes**](docs/AutomationApi.md#getalltasktypes) | **GET** /api/2/tasks/types | 
*AutomationApi* | [**GetAllTasks**](docs/AutomationApi.md#getalltasks) | **GET** /api/2/tasks | 
*AutomationApi* | [**GetEvent**](docs/AutomationApi.md#getevent) | **GET** /api/2/events/{id} | 
*AutomationApi* | [**GetFinishedTasks**](docs/AutomationApi.md#getfinishedtasks) | **GET** /api/2/tasks/finished | 
*AutomationApi* | [**GetJob**](docs/AutomationApi.md#getjob) | **GET** /api/2/jobs/{id} | 
*AutomationApi* | [**GetPendingTasks**](docs/AutomationApi.md#getpendingtasks) | **GET** /api/2/tasks/pending | 
*AutomationApi* | [**GetPythonEnvironments**](docs/AutomationApi.md#getpythonenvironments) | **GET** /api/2/python/environments | 
*AutomationApi* | [**GetSchedule**](docs/AutomationApi.md#getschedule) | **GET** /api/2/schedules/{id} | 
*AutomationApi* | [**GetSubtask**](docs/AutomationApi.md#getsubtask) | **GET** /api/2/subtasks/{id} | 
*AutomationApi* | [**GetTask**](docs/AutomationApi.md#gettask) | **GET** /api/2/tasks/{id} | 
*AutomationApi* | [**GetTaskLog**](docs/AutomationApi.md#gettasklog) | **GET** /api/2/tasks/{id}/log | 
*AutomationApi* | [**GetTaskType**](docs/AutomationApi.md#gettasktype) | **GET** /api/2/tasks/types/{type} | 
*AutomationApi* | [**GetTasksSummary**](docs/AutomationApi.md#gettaskssummary) | **GET** /api/2/tasks/summary | 
*AutomationApi* | [**KillAllPendingTasks**](docs/AutomationApi.md#killallpendingtasks) | **DELETE** /api/2/tasks/pending | 
*AutomationApi* | [**KillTask**](docs/AutomationApi.md#killtask) | **POST** /api/2/tasks/{id}/kill | 
*AutomationApi* | [**PatchJob**](docs/AutomationApi.md#patchjob) | **PATCH** /api/2/jobs/{id} | 
*AutomationApi* | [**PatchSchedule**](docs/AutomationApi.md#patchschedule) | **PATCH** /api/2/schedules/{id} | 
*AutomationApi* | [**PatchSubtask**](docs/AutomationApi.md#patchsubtask) | **PATCH** /api/2/subtasks/{id} | 
*AutomationApi* | [**RestartTask**](docs/AutomationApi.md#restarttask) | **POST** /api/2/tasks/{id}/restart | 
*AutomationApi* | [**StartJob**](docs/AutomationApi.md#startjob) | **POST** /api/2/jobs/{id}/start | 
*AutomationApi* | [**StartTask**](docs/AutomationApi.md#starttask) | **POST** /api/2/tasks/start | 
*AutomationApi* | [**UpdateJob**](docs/AutomationApi.md#updatejob) | **PUT** /api/2/jobs/{id} | 
*AutomationApi* | [**UpdateSchedule**](docs/AutomationApi.md#updateschedule) | **PUT** /api/2/schedules/{id} | 
*AutomationApi* | [**UpdateSubtask**](docs/AutomationApi.md#updatesubtask) | **PUT** /api/2/subtasks/{id} | 
*ClickApi* | [**AbortClickUpload**](docs/ClickApi.md#abortclickupload) | **DELETE** /api/2/click/uploads/{upload_id} | 
*ClickApi* | [**ContinueClickUploadInBackground**](docs/ClickApi.md#continueclickuploadinbackground) | **POST** /api/2/click/uploads/{upload_id}/background | 
*ClickApi* | [**CreateClickGallery**](docs/ClickApi.md#createclickgallery) | **POST** /api/2/click/connections/{connection_id}/galleries | 
*ClickApi* | [**CreateClickGalleryLink**](docs/ClickApi.md#createclickgallerylink) | **POST** /api/2/click/connections/{connection_id}/gallery-links | 
*ClickApi* | [**DeleteClickGalleryLink**](docs/ClickApi.md#deleteclickgallerylink) | **DELETE** /api/2/click/connections/{connection_id}/gallery-links/{id} | 
*ClickApi* | [**GetAllClickGalleries**](docs/ClickApi.md#getallclickgalleries) | **GET** /api/2/click/connections/{connection_id}/galleries | 
*ClickApi* | [**GetAllClickGalleryLinks**](docs/ClickApi.md#getallclickgallerylinks) | **GET** /api/2/click/connections/{connection_id}/gallery-links | 
*ClickApi* | [**GetClickGallery**](docs/ClickApi.md#getclickgallery) | **GET** /api/2/click/connections/{connection_id}/galleries/{id} | 
*ClickApi* | [**GetClickGalleryLink**](docs/ClickApi.md#getclickgallerylink) | **GET** /api/2/click/connections/{connection_id}/gallery-links/{id} | 
*ClickApi* | [**PatchClickGallery**](docs/ClickApi.md#patchclickgallery) | **PATCH** /api/2/click/connections/{connection_id}/galleries/{id} | 
*ClickApi* | [**SendClickGalleryLinkEmail**](docs/ClickApi.md#sendclickgallerylinkemail) | **POST** /api/2/click/connections/{connection_id}/gallery-links/{link_id}/send | 
*ClickApi* | [**StartClickUpload**](docs/ClickApi.md#startclickupload) | **POST** /api/2/click/uploads | 
*ClickApi* | [**UpdateClickGallery**](docs/ClickApi.md#updateclickgallery) | **PUT** /api/2/click/connections/{connection_id}/galleries/{id} | 
*IntegrationsApi* | [**DeleteSlackConnection**](docs/IntegrationsApi.md#deleteslackconnection) | **DELETE** /api/2/integrations/slack/{id} | 
*IntegrationsApi* | [**DeleteTeamsConnection**](docs/IntegrationsApi.md#deleteteamsconnection) | **DELETE** /api/2/integrations/teams/{id} | 
*IntegrationsApi* | [**GetAllSlackConnections**](docs/IntegrationsApi.md#getallslackconnections) | **GET** /api/2/integrations/slack | 
*IntegrationsApi* | [**GetAllTeamsConnections**](docs/IntegrationsApi.md#getallteamsconnections) | **GET** /api/2/integrations/teams | 
*IntegrationsApi* | [**GetSlackChannels**](docs/IntegrationsApi.md#getslackchannels) | **GET** /api/2/integrations/slack/{id}/channels | 
*IntegrationsApi* | [**GetSlackConnection**](docs/IntegrationsApi.md#getslackconnection) | **GET** /api/2/integrations/slack/{id} | 
*IntegrationsApi* | [**GetSlackEmoji**](docs/IntegrationsApi.md#getslackemoji) | **GET** /api/2/integrations/slack/{id}/emoji | 
*IntegrationsApi* | [**GetSlackUsers**](docs/IntegrationsApi.md#getslackusers) | **GET** /api/2/integrations/slack/{id}/users | 
*IntegrationsApi* | [**GetTeamsChannels**](docs/IntegrationsApi.md#getteamschannels) | **GET** /api/2/integrations/teams/{id}/channels | 
*IntegrationsApi* | [**GetTeamsConnection**](docs/IntegrationsApi.md#getteamsconnection) | **GET** /api/2/integrations/teams/{id} | 
*IntegrationsApi* | [**GetTeamsUsers**](docs/IntegrationsApi.md#getteamsusers) | **GET** /api/2/integrations/teams/{id}/users | 
*IntegrationsApi* | [**PatchSlackConnection**](docs/IntegrationsApi.md#patchslackconnection) | **PATCH** /api/2/integrations/slack/{id} | 
*IntegrationsApi* | [**PatchTeamsConnection**](docs/IntegrationsApi.md#patchteamsconnection) | **PATCH** /api/2/integrations/teams/{id} | 
*IntegrationsApi* | [**SendSlackMessage**](docs/IntegrationsApi.md#sendslackmessage) | **POST** /api/2/integrations/slack/{id}/message | 
*IntegrationsApi* | [**SendTeamsMessage**](docs/IntegrationsApi.md#sendteamsmessage) | **POST** /api/2/integrations/teams/{id}/send-message | 
*IntegrationsApi* | [**StartSlackConnectionFlow**](docs/IntegrationsApi.md#startslackconnectionflow) | **GET** /api/2/integrations/slack/connect | 
*IntegrationsApi* | [**StartSlackConnectionTokenRefreshFlow**](docs/IntegrationsApi.md#startslackconnectiontokenrefreshflow) | **GET** /api/2/integrations/slack/{id}/refresh-token | 
*IntegrationsApi* | [**StartTeamsConnectionFlow**](docs/IntegrationsApi.md#startteamsconnectionflow) | **GET** /api/2/integrations/teams/connect | 
*IntegrationsApi* | [**StartTeamsConnectionTokenRefreshFlow**](docs/IntegrationsApi.md#startteamsconnectiontokenrefreshflow) | **GET** /api/2/integrations/teams/{id}/refresh-token | 
*IntegrationsApi* | [**UpdateSlackConnection**](docs/IntegrationsApi.md#updateslackconnection) | **PUT** /api/2/integrations/slack/{id} | 
*IntegrationsApi* | [**UpdateTeamsConnection**](docs/IntegrationsApi.md#updateteamsconnection) | **PUT** /api/2/integrations/teams/{id} | 
*MainApi* | [**ApplyConfiguration**](docs/MainApi.md#applyconfiguration) | **POST** /api/2/configuration/apply | 
*MainApi* | [**Beep**](docs/MainApi.md#beep) | **POST** /api/2/system/beep | 
*MainApi* | [**CheckCertificate**](docs/MainApi.md#checkcertificate) | **POST** /api/2/system/certificate/check | 
*MainApi* | [**CheckChunkUploaded**](docs/MainApi.md#checkchunkuploaded) | **GET** /api/2/uploads/chunk | 
*MainApi* | [**CheckInternetConnectivity**](docs/MainApi.md#checkinternetconnectivity) | **POST** /api/2/system/check-connectivity | 
*MainApi* | [**CheckStorNextLicense**](docs/MainApi.md#checkstornextlicense) | **POST** /api/2/stornext-license/check | 
*MainApi* | [**CollectDiagnostics**](docs/MainApi.md#collectdiagnostics) | **POST** /api/2/system/collect-diagnostics | 
*MainApi* | [**CreateArchive**](docs/MainApi.md#createarchive) | **POST** /api/2/download-archive/create | 
*MainApi* | [**CreateGroup**](docs/MainApi.md#creategroup) | **POST** /api/2/groups | 
*MainApi* | [**CreateHomeWorkspace**](docs/MainApi.md#createhomeworkspace) | **POST** /api/2/users/{id}/home | 
*MainApi* | [**CreateNTPServer**](docs/MainApi.md#createntpserver) | **POST** /api/2/system/time/servers | 
*MainApi* | [**CreateUser**](docs/MainApi.md#createuser) | **POST** /api/2/users | 
*MainApi* | [**CreateWorkstation**](docs/MainApi.md#createworkstation) | **POST** /api/2/workstations | 
*MainApi* | [**DeleteDownloadArchive**](docs/MainApi.md#deletedownloadarchive) | **DELETE** /api/2/download-archive/{id} | 
*MainApi* | [**DeleteGroup**](docs/MainApi.md#deletegroup) | **DELETE** /api/2/groups/{id} | 
*MainApi* | [**DeleteHomeWorkspace**](docs/MainApi.md#deletehomeworkspace) | **DELETE** /api/2/users/{id}/home | 
*MainApi* | [**DeleteNTPServer**](docs/MainApi.md#deletentpserver) | **DELETE** /api/2/system/time/servers/{id} | 
*MainApi* | [**DeleteUser**](docs/MainApi.md#deleteuser) | **DELETE** /api/2/users/{id} | 
*MainApi* | [**DeleteWorkstation**](docs/MainApi.md#deleteworkstation) | **DELETE** /api/2/workstations/{id} | 
*MainApi* | [**DisableUserTOTP**](docs/MainApi.md#disableusertotp) | **DELETE** /api/2/users/{id}/totp | 
*MainApi* | [**EnableUserTOTP**](docs/MainApi.md#enableusertotp) | **POST** /api/2/users/{id}/totp | 
*MainApi* | [**FinishUpload**](docs/MainApi.md#finishupload) | **POST** /api/2/uploads/finish | 
*MainApi* | [**FixLDAPGroupMemberships**](docs/MainApi.md#fixldapgroupmemberships) | **POST** /api/2/ldap-servers/{id}/fix-memberships | 
*MainApi* | [**GetAllDownloadArchives**](docs/MainApi.md#getalldownloadarchives) | **GET** /api/2/download-archive | 
*MainApi* | [**GetAllDownloads**](docs/MainApi.md#getalldownloads) | **GET** /api/2/downloads | 
*MainApi* | [**GetAllGroups**](docs/MainApi.md#getallgroups) | **GET** /api/2/groups | 
*MainApi* | [**GetAllLDAPServers**](docs/MainApi.md#getallldapservers) | **GET** /api/2/ldap-servers | 
*MainApi* | [**GetAllNTPServers**](docs/MainApi.md#getallntpservers) | **GET** /api/2/system/time/servers | 
*MainApi* | [**GetAllStorageNodes**](docs/MainApi.md#getallstoragenodes) | **GET** /api/2/nodes | 
*MainApi* | [**GetAllUsers**](docs/MainApi.md#getallusers) | **GET** /api/2/users | 
*MainApi* | [**GetAllWorkstations**](docs/MainApi.md#getallworkstations) | **GET** /api/2/workstations | 
*MainApi* | [**GetCertificateConfiguration**](docs/MainApi.md#getcertificateconfiguration) | **GET** /api/2/system/certificate | 
*MainApi* | [**GetClientDownloadFile**](docs/MainApi.md#getclientdownloadfile) | **GET** /api/2/downloads/clients/{file} | 
*MainApi* | [**GetClientDownloads**](docs/MainApi.md#getclientdownloads) | **GET** /api/2/downloads/clients | 
*MainApi* | [**GetCurrentWorkstation**](docs/MainApi.md#getcurrentworkstation) | **GET** /api/2/workstations/current | 
*MainApi* | [**GetDownload**](docs/MainApi.md#getdownload) | **GET** /api/2/downloads/{id} | 
*MainApi* | [**GetDownloadArchive**](docs/MainApi.md#getdownloadarchive) | **GET** /api/2/download-archive/{id} | 
*MainApi* | [**GetDownloadArchiveFile**](docs/MainApi.md#getdownloadarchivefile) | **GET** /api/2/download-archive/{id}/download | 
*MainApi* | [**GetDownloadFile**](docs/MainApi.md#getdownloadfile) | **GET** /api/2/downloads/{id}/download | 
*MainApi* | [**GetDownloadIcon**](docs/MainApi.md#getdownloadicon) | **GET** /api/2/downloads/{id}/icon | 
*MainApi* | [**GetGroup**](docs/MainApi.md#getgroup) | **GET** /api/2/groups/{id} | 
*MainApi* | [**GetHomeWorkspace**](docs/MainApi.md#gethomeworkspace) | **GET** /api/2/users/{id}/home | 
*MainApi* | [**GetIPMIConfiguration**](docs/MainApi.md#getipmiconfiguration) | **GET** /api/2/nodes/{id}/ipmi | 
*MainApi* | [**GetLDAPServer**](docs/MainApi.md#getldapserver) | **GET** /api/2/ldap-servers/{id} | 
*MainApi* | [**GetLDAPServerGroups**](docs/MainApi.md#getldapservergroups) | **GET** /api/2/ldap-servers/{id}/groups | 
*MainApi* | [**GetLDAPServerUsers**](docs/MainApi.md#getldapserverusers) | **GET** /api/2/ldap-servers/{id}/users | 
*MainApi* | [**GetLicense**](docs/MainApi.md#getlicense) | **GET** /api/2/license | 
*MainApi* | [**GetLocalTime**](docs/MainApi.md#getlocaltime) | **GET** /api/2/system/time | 
*MainApi* | [**GetLog**](docs/MainApi.md#getlog) | **GET** /api/2/system/log/{path} | 
*MainApi* | [**GetNTPServer**](docs/MainApi.md#getntpserver) | **GET** /api/2/system/time/servers/{id} | 
*MainApi* | [**GetNodeIPMISensors**](docs/MainApi.md#getnodeipmisensors) | **GET** /api/2/nodes/{id}/sensors | 
*MainApi* | [**GetNodeStats**](docs/MainApi.md#getnodestats) | **GET** /api/2/nodes/{id}/stats | 
*MainApi* | [**GetParameters**](docs/MainApi.md#getparameters) | **GET** /api/2/parameters | 
*MainApi* | [**GetProfile**](docs/MainApi.md#getprofile) | **GET** /api/2/users/me | 
*MainApi* | [**GetReleaseNotes**](docs/MainApi.md#getreleasenotes) | **GET** /api/2/release-notes | 
*MainApi* | [**GetSMTPConfiguration**](docs/MainApi.md#getsmtpconfiguration) | **GET** /api/2/system/smtp | 
*MainApi* | [**GetServiceStatus**](docs/MainApi.md#getservicestatus) | **GET** /api/2/nodes/{id}/services/{service} | 
*MainApi* | [**GetStorNextLicense**](docs/MainApi.md#getstornextlicense) | **GET** /api/2/stornext-license | 
*MainApi* | [**GetStorageNode**](docs/MainApi.md#getstoragenode) | **GET** /api/2/nodes/{id} | 
*MainApi* | [**GetSystemInfo**](docs/MainApi.md#getsysteminfo) | **GET** /api/2/system/info | 
*MainApi* | [**GetUser**](docs/MainApi.md#getuser) | **GET** /api/2/users/{id} | 
*MainApi* | [**GetWorkstation**](docs/MainApi.md#getworkstation) | **GET** /api/2/workstations/{id} | 
*MainApi* | [**InstallStorNextLicense**](docs/MainApi.md#installstornextlicense) | **POST** /api/2/stornext-license | 
*MainApi* | [**PatchCurrentWorkstation**](docs/MainApi.md#patchcurrentworkstation) | **PATCH** /api/2/workstations/current | 
*MainApi* | [**PatchDownloadArchive**](docs/MainApi.md#patchdownloadarchive) | **PATCH** /api/2/download-archive/{id} | 
*MainApi* | [**PatchGroup**](docs/MainApi.md#patchgroup) | **PATCH** /api/2/groups/{id} | 
*MainApi* | [**PatchNTPServer**](docs/MainApi.md#patchntpserver) | **PATCH** /api/2/system/time/servers/{id} | 
*MainApi* | [**PatchProfile**](docs/MainApi.md#patchprofile) | **PATCH** /api/2/users/me | 
*MainApi* | [**PatchUser**](docs/MainApi.md#patchuser) | **PATCH** /api/2/users/{id} | 
*MainApi* | [**PatchWorkstation**](docs/MainApi.md#patchworkstation) | **PATCH** /api/2/workstations/{id} | 
*MainApi* | [**PreviewUser**](docs/MainApi.md#previewuser) | **POST** /api/2/users/preview | 
*MainApi* | [**Reboot**](docs/MainApi.md#reboot) | **POST** /api/2/system/reboot | 
*MainApi* | [**RegisterUpload**](docs/MainApi.md#registerupload) | **POST** /api/2/uploads/register | 
*MainApi* | [**RegisterUploadMetadata**](docs/MainApi.md#registeruploadmetadata) | **POST** /api/2/uploads/metadata | 
*MainApi* | [**RenderEmailTemplatePreview**](docs/MainApi.md#renderemailtemplatepreview) | **POST** /api/2/system/smtp/preview | 
*MainApi* | [**ResetUserPassword**](docs/MainApi.md#resetuserpassword) | **POST** /api/2/users/{id}/password/reset | 
*MainApi* | [**RunServiceOperation**](docs/MainApi.md#runserviceoperation) | **POST** /api/2/nodes/{id}/services/{service}/{operation} | 
*MainApi* | [**SetIPMIConfiguration**](docs/MainApi.md#setipmiconfiguration) | **PUT** /api/2/nodes/{id}/ipmi | 
*MainApi* | [**SetLocalTime**](docs/MainApi.md#setlocaltime) | **POST** /api/2/system/time | 
*MainApi* | [**SetMyPassword**](docs/MainApi.md#setmypassword) | **POST** /api/2/users/me/password | 
*MainApi* | [**SetUserPassword**](docs/MainApi.md#setuserpassword) | **POST** /api/2/users/{id}/password | 
*MainApi* | [**Shutdown**](docs/MainApi.md#shutdown) | **POST** /api/2/system/shutdown | 
*MainApi* | [**StartSolrReindex**](docs/MainApi.md#startsolrreindex) | **POST** /api/2/system/solr/reindex | 
*MainApi* | [**StartSupportSession**](docs/MainApi.md#startsupportsession) | **POST** /api/2/system/support-session/start | 
*MainApi* | [**StartSystemBackup**](docs/MainApi.md#startsystembackup) | **POST** /api/2/system/backup/start | 
*MainApi* | [**SyncLDAPGroup**](docs/MainApi.md#syncldapgroup) | **POST** /api/2/groups/{id}/ldap-sync | 
*MainApi* | [**SyncLDAPUsers**](docs/MainApi.md#syncldapusers) | **POST** /api/2/ldap-servers/{id}/sync-users | 
*MainApi* | [**SyncTime**](docs/MainApi.md#synctime) | **POST** /api/2/system/time/sync | 
*MainApi* | [**SyncUserTOTP**](docs/MainApi.md#syncusertotp) | **PUT** /api/2/users/{id}/totp | 
*MainApi* | [**TestSMTPConfiguration**](docs/MainApi.md#testsmtpconfiguration) | **POST** /api/2/system/smtp/test | 
*MainApi* | [**UpdateCertificateConfiguration**](docs/MainApi.md#updatecertificateconfiguration) | **PUT** /api/2/system/certificate | 
*MainApi* | [**UpdateCurrentWorkstation**](docs/MainApi.md#updatecurrentworkstation) | **PUT** /api/2/workstations/current | 
*MainApi* | [**UpdateDownloadArchive**](docs/MainApi.md#updatedownloadarchive) | **PUT** /api/2/download-archive/{id} | 
*MainApi* | [**UpdateGroup**](docs/MainApi.md#updategroup) | **PUT** /api/2/groups/{id} | 
*MainApi* | [**UpdateNTPServer**](docs/MainApi.md#updatentpserver) | **PUT** /api/2/system/time/servers/{id} | 
*MainApi* | [**UpdateParameters**](docs/MainApi.md#updateparameters) | **PUT** /api/2/parameters | 
*MainApi* | [**UpdateProfile**](docs/MainApi.md#updateprofile) | **PUT** /api/2/users/me | 
*MainApi* | [**UpdateSMTPConfiguration**](docs/MainApi.md#updatesmtpconfiguration) | **PUT** /api/2/system/smtp | 
*MainApi* | [**UpdateUser**](docs/MainApi.md#updateuser) | **PUT** /api/2/users/{id} | 
*MainApi* | [**UpdateWorkstation**](docs/MainApi.md#updateworkstation) | **PUT** /api/2/workstations/{id} | 
*MainApi* | [**UploadChunk**](docs/MainApi.md#uploadchunk) | **POST** /api/2/uploads/chunk | 
*MediaLibraryApi* | [**BookmarkMediaDirectory**](docs/MediaLibraryApi.md#bookmarkmediadirectory) | **POST** /api/2/media/files/{id}/bookmark | 
*MediaLibraryApi* | [**ClearSubclipClipboard**](docs/MediaLibraryApi.md#clearsubclipclipboard) | **DELETE** /api/2/media/subclips/clipboard/clear | 
*MediaLibraryApi* | [**CombineAssetsIntoSet**](docs/MediaLibraryApi.md#combineassetsintoset) | **POST** /api/2/media/assets/combine | 
*MediaLibraryApi* | [**CreateAsset**](docs/MediaLibraryApi.md#createasset) | **POST** /api/2/media/assets | 
*MediaLibraryApi* | [**CreateAssetRating**](docs/MediaLibraryApi.md#createassetrating) | **POST** /api/2/media/ratings | 
*MediaLibraryApi* | [**CreateComment**](docs/MediaLibraryApi.md#createcomment) | **POST** /api/2/media/comments | 
*MediaLibraryApi* | [**CreateCustomField**](docs/MediaLibraryApi.md#createcustomfield) | **POST** /api/2/media/custom-fields | 
*MediaLibraryApi* | [**CreateEditorProject**](docs/MediaLibraryApi.md#createeditorproject) | **POST** /api/2/media/editor | 
*MediaLibraryApi* | [**CreateExternalTranscoder**](docs/MediaLibraryApi.md#createexternaltranscoder) | **POST** /api/2/media/external-transcoders | 
*MediaLibraryApi* | [**CreateMarker**](docs/MediaLibraryApi.md#createmarker) | **POST** /api/2/media/markers | 
*MediaLibraryApi* | [**CreateMediaFileTemplate**](docs/MediaLibraryApi.md#createmediafiletemplate) | **POST** /api/2/media/files/templates | 
*MediaLibraryApi* | [**CreateMediaRoot**](docs/MediaLibraryApi.md#createmediaroot) | **POST** /api/2/media/roots | 
*MediaLibraryApi* | [**CreateMediaRootPermission**](docs/MediaLibraryApi.md#createmediarootpermission) | **POST** /api/2/media/root-permissions | 
*MediaLibraryApi* | [**CreateMediaTag**](docs/MediaLibraryApi.md#createmediatag) | **POST** /api/2/media/tags | 
*MediaLibraryApi* | [**CreateProxyProfile**](docs/MediaLibraryApi.md#createproxyprofile) | **POST** /api/2/media/proxy-profiles | 
*MediaLibraryApi* | [**CreateSubclip**](docs/MediaLibraryApi.md#createsubclip) | **POST** /api/2/media/subclips | 
*MediaLibraryApi* | [**CreateSubclipClipboardEntry**](docs/MediaLibraryApi.md#createsubclipclipboardentry) | **POST** /api/2/media/subclips/clipboard | 
*MediaLibraryApi* | [**DeleteAsset**](docs/MediaLibraryApi.md#deleteasset) | **DELETE** /api/2/media/assets/{id} | 
*MediaLibraryApi* | [**DeleteAssetRating**](docs/MediaLibraryApi.md#deleteassetrating) | **DELETE** /api/2/media/ratings/{id} | 
*MediaLibraryApi* | [**DeleteComment**](docs/MediaLibraryApi.md#deletecomment) | **DELETE** /api/2/media/comments/{id} | 
*MediaLibraryApi* | [**DeleteCustomField**](docs/MediaLibraryApi.md#deletecustomfield) | **DELETE** /api/2/media/custom-fields/{id} | 
*MediaLibraryApi* | [**DeleteEasySharingTokenForBundle**](docs/MediaLibraryApi.md#deleteeasysharingtokenforbundle) | **DELETE** /api/2/media/bundles/{id}/easy-sharing-token | 
*MediaLibraryApi* | [**DeleteEasySharingTokenForDirectory**](docs/MediaLibraryApi.md#deleteeasysharingtokenfordirectory) | **DELETE** /api/2/media/files/{id}/easy-sharing-token | 
*MediaLibraryApi* | [**DeleteExternalTranscoder**](docs/MediaLibraryApi.md#deleteexternaltranscoder) | **DELETE** /api/2/media/external-transcoders/{id} | 
*MediaLibraryApi* | [**DeleteMarker**](docs/MediaLibraryApi.md#deletemarker) | **DELETE** /api/2/media/markers/{id} | 
*MediaLibraryApi* | [**DeleteMediaFileTemplate**](docs/MediaLibraryApi.md#deletemediafiletemplate) | **DELETE** /api/2/media/files/templates/{id} | 
*MediaLibraryApi* | [**DeleteMediaLibraryObjects**](docs/MediaLibraryApi.md#deletemedialibraryobjects) | **POST** /api/2/media/delete | 
*MediaLibraryApi* | [**DeleteMediaRoot**](docs/MediaLibraryApi.md#deletemediaroot) | **DELETE** /api/2/media/roots/{id} | 
*MediaLibraryApi* | [**DeleteMediaRootPermission**](docs/MediaLibraryApi.md#deletemediarootpermission) | **DELETE** /api/2/media/root-permissions/{id} | 
*MediaLibraryApi* | [**DeleteMediaTag**](docs/MediaLibraryApi.md#deletemediatag) | **DELETE** /api/2/media/tags/{id} | 
*MediaLibraryApi* | [**DeleteMediaUpdate**](docs/MediaLibraryApi.md#deletemediaupdate) | **DELETE** /api/2/media/updates/{id} | 
*MediaLibraryApi* | [**DeleteProxy**](docs/MediaLibraryApi.md#deleteproxy) | **DELETE** /api/2/media/proxies/{id} | 
*MediaLibraryApi* | [**DeleteProxyProfile**](docs/MediaLibraryApi.md#deleteproxyprofile) | **DELETE** /api/2/media/proxy-profiles/{id} | 
*MediaLibraryApi* | [**DeleteSubclip**](docs/MediaLibraryApi.md#deletesubclip) | **DELETE** /api/2/media/subclips/{id} | 
*MediaLibraryApi* | [**DeleteSubclipClipboardEntry**](docs/MediaLibraryApi.md#deletesubclipclipboardentry) | **DELETE** /api/2/media/subclips/clipboard/{id} | 
*MediaLibraryApi* | [**DiscoverMedia**](docs/MediaLibraryApi.md#discovermedia) | **POST** /api/2/scanner/discover | 
*MediaLibraryApi* | [**DownloadAssetProxyFile**](docs/MediaLibraryApi.md#downloadassetproxyfile) | **GET** /api/2/media/assets/{id}/proxy-files/{filename} | 
*MediaLibraryApi* | [**DownloadMediaFile**](docs/MediaLibraryApi.md#downloadmediafile) | **GET** /api/2/media/files/{id}/download | 
*MediaLibraryApi* | [**DownloadProxy**](docs/MediaLibraryApi.md#downloadproxy) | **GET** /api/2/media/proxies/{id}/download | 
*MediaLibraryApi* | [**EditorExportXMLForAssset**](docs/MediaLibraryApi.md#editorexportxmlforassset) | **GET** /api/2/media/editor/asset/{asset_ids}/xml-export | 
*MediaLibraryApi* | [**EditorExportXMLForBundle**](docs/MediaLibraryApi.md#editorexportxmlforbundle) | **GET** /api/2/media/editor/bundle/{bundle_ids}/xml-export | 
*MediaLibraryApi* | [**EditorExportXMLForProject**](docs/MediaLibraryApi.md#editorexportxmlforproject) | **GET** /api/2/media/editor/{id}/xml-export | 
*MediaLibraryApi* | [**ExportCommentsForAvid**](docs/MediaLibraryApi.md#exportcommentsforavid) | **GET** /api/2/media/editor/asset/{asset_id}/{export_format}-export/avid-comments | 
*MediaLibraryApi* | [**ExportEditorTimeline**](docs/MediaLibraryApi.md#exporteditortimeline) | **POST** /api/2/media/editor/timeline-export | 
*MediaLibraryApi* | [**ForgetDeletedMediaFiles**](docs/MediaLibraryApi.md#forgetdeletedmediafiles) | **POST** /api/2/media/files/{id}/forget-deleted | 
*MediaLibraryApi* | [**GenerateProxies**](docs/MediaLibraryApi.md#generateproxies) | **POST** /api/2/media/proxies | 
*MediaLibraryApi* | [**GetAllAssetProjectLinks**](docs/MediaLibraryApi.md#getallassetprojectlinks) | **GET** /api/2/media/assets/project-links | 
*MediaLibraryApi* | [**GetAllAssetRatings**](docs/MediaLibraryApi.md#getallassetratings) | **GET** /api/2/media/ratings | 
*MediaLibraryApi* | [**GetAllAssetTapeBackups**](docs/MediaLibraryApi.md#getallassettapebackups) | **GET** /api/2/media/backups | 
*MediaLibraryApi* | [**GetAllAssets**](docs/MediaLibraryApi.md#getallassets) | **GET** /api/2/media/assets | 
*MediaLibraryApi* | [**GetAllBundlesForMediaRoot**](docs/MediaLibraryApi.md#getallbundlesformediaroot) | **GET** /api/2/media/bundles/flat/{root} | 
*MediaLibraryApi* | [**GetAllClickLinks**](docs/MediaLibraryApi.md#getallclicklinks) | **GET** /api/2/media/assets/click-links | 
*MediaLibraryApi* | [**GetAllComments**](docs/MediaLibraryApi.md#getallcomments) | **GET** /api/2/media/comments | 
*MediaLibraryApi* | [**GetAllCustomFields**](docs/MediaLibraryApi.md#getallcustomfields) | **GET** /api/2/media/custom-fields | 
*MediaLibraryApi* | [**GetAllExternalTranscoders**](docs/MediaLibraryApi.md#getallexternaltranscoders) | **GET** /api/2/media/external-transcoders | 
*MediaLibraryApi* | [**GetAllMarkers**](docs/MediaLibraryApi.md#getallmarkers) | **GET** /api/2/media/markers | 
*MediaLibraryApi* | [**GetAllMediaFileBundles**](docs/MediaLibraryApi.md#getallmediafilebundles) | **GET** /api/2/media/bundles | 
*MediaLibraryApi* | [**GetAllMediaFileTemplates**](docs/MediaLibraryApi.md#getallmediafiletemplates) | **GET** /api/2/media/files/templates | 
*MediaLibraryApi* | [**GetAllMediaFiles**](docs/MediaLibraryApi.md#getallmediafiles) | **GET** /api/2/media/files | 
*MediaLibraryApi* | [**GetAllMediaFilesForBundles**](docs/MediaLibraryApi.md#getallmediafilesforbundles) | **POST** /api/2/media/files/for-bundles | 
*MediaLibraryApi* | [**GetAllMediaFilesForMediaRoot**](docs/MediaLibraryApi.md#getallmediafilesformediaroot) | **GET** /api/2/media/files/flat/{root} | 
*MediaLibraryApi* | [**GetAllMediaRootPermissions**](docs/MediaLibraryApi.md#getallmediarootpermissions) | **GET** /api/2/media/root-permissions | 
*MediaLibraryApi* | [**GetAllMediaRoots**](docs/MediaLibraryApi.md#getallmediaroots) | **GET** /api/2/media/roots | 
*MediaLibraryApi* | [**GetAllMediaTags**](docs/MediaLibraryApi.md#getallmediatags) | **GET** /api/2/media/tags | 
*MediaLibraryApi* | [**GetAllMediaUpdates**](docs/MediaLibraryApi.md#getallmediaupdates) | **GET** /api/2/media/updates | 
*MediaLibraryApi* | [**GetAllProxyGenerators**](docs/MediaLibraryApi.md#getallproxygenerators) | **GET** /api/2/media/proxy-generators | 
*MediaLibraryApi* | [**GetAllProxyProfiles**](docs/MediaLibraryApi.md#getallproxyprofiles) | **GET** /api/2/media/proxy-profiles | 
*MediaLibraryApi* | [**GetAllSubclipClipboardEntries**](docs/MediaLibraryApi.md#getallsubclipclipboardentries) | **GET** /api/2/media/subclips/clipboard | 
*MediaLibraryApi* | [**GetAllSubclips**](docs/MediaLibraryApi.md#getallsubclips) | **GET** /api/2/media/subclips | 
*MediaLibraryApi* | [**GetAllTranscoderProfiles**](docs/MediaLibraryApi.md#getalltranscoderprofiles) | **GET** /api/2/transcoder-profiles | 
*MediaLibraryApi* | [**GetAsset**](docs/MediaLibraryApi.md#getasset) | **GET** /api/2/media/assets/{id} | 
*MediaLibraryApi* | [**GetAssetRating**](docs/MediaLibraryApi.md#getassetrating) | **GET** /api/2/media/ratings/{id} | 
*MediaLibraryApi* | [**GetBookmarkedMediaFilesDirectories**](docs/MediaLibraryApi.md#getbookmarkedmediafilesdirectories) | **GET** /api/2/media/files/bookmarks | 
*MediaLibraryApi* | [**GetComment**](docs/MediaLibraryApi.md#getcomment) | **GET** /api/2/media/comments/{id} | 
*MediaLibraryApi* | [**GetCustomField**](docs/MediaLibraryApi.md#getcustomfield) | **GET** /api/2/media/custom-fields/{id} | 
*MediaLibraryApi* | [**GetEasySharingTokenForBundle**](docs/MediaLibraryApi.md#geteasysharingtokenforbundle) | **GET** /api/2/media/bundles/{id}/easy-sharing-token | 
*MediaLibraryApi* | [**GetEasySharingTokenForDirectory**](docs/MediaLibraryApi.md#geteasysharingtokenfordirectory) | **GET** /api/2/media/files/{id}/easy-sharing-token | 
*MediaLibraryApi* | [**GetEditorProject**](docs/MediaLibraryApi.md#geteditorproject) | **GET** /api/2/media/editor/{id} | 
*MediaLibraryApi* | [**GetExternalTranscoder**](docs/MediaLibraryApi.md#getexternaltranscoder) | **GET** /api/2/media/external-transcoders/{id} | 
*MediaLibraryApi* | [**GetFrame**](docs/MediaLibraryApi.md#getframe) | **GET** /api/2/media/assets/{id}/frames/{frame} | 
*MediaLibraryApi* | [**GetLatestMediaUpdate**](docs/MediaLibraryApi.md#getlatestmediaupdate) | **GET** /api/2/media/updates/latest | 
*MediaLibraryApi* | [**GetMarker**](docs/MediaLibraryApi.md#getmarker) | **GET** /api/2/media/markers/{id} | 
*MediaLibraryApi* | [**GetMediaFile**](docs/MediaLibraryApi.md#getmediafile) | **GET** /api/2/media/files/{id} | 
*MediaLibraryApi* | [**GetMediaFileBundle**](docs/MediaLibraryApi.md#getmediafilebundle) | **GET** /api/2/media/bundles/{id} | 
*MediaLibraryApi* | [**GetMediaFileContents**](docs/MediaLibraryApi.md#getmediafilecontents) | **GET** /api/2/media/files/{id}/contents | 
*MediaLibraryApi* | [**GetMediaFileTemplate**](docs/MediaLibraryApi.md#getmediafiletemplate) | **GET** /api/2/media/files/templates/{id} | 
*MediaLibraryApi* | [**GetMediaRoot**](docs/MediaLibraryApi.md#getmediaroot) | **GET** /api/2/media/roots/{id} | 
*MediaLibraryApi* | [**GetMediaRootPermission**](docs/MediaLibraryApi.md#getmediarootpermission) | **GET** /api/2/media/root-permissions/{id} | 
*MediaLibraryApi* | [**GetMediaTag**](docs/MediaLibraryApi.md#getmediatag) | **GET** /api/2/media/tags/{id} | 
*MediaLibraryApi* | [**GetMultipleAssets**](docs/MediaLibraryApi.md#getmultipleassets) | **POST** /api/2/media/assets/multiple | 
*MediaLibraryApi* | [**GetMultipleBundles**](docs/MediaLibraryApi.md#getmultiplebundles) | **POST** /api/2/media/bundles/multiple | 
*MediaLibraryApi* | [**GetMultipleFiles**](docs/MediaLibraryApi.md#getmultiplefiles) | **POST** /api/2/media/files/multiple | 
*MediaLibraryApi* | [**GetMyMediaRootPermissions**](docs/MediaLibraryApi.md#getmymediarootpermissions) | **GET** /api/2/media/root-permissions/mine | 
*MediaLibraryApi* | [**GetMyResolvedMediaRootPermissions**](docs/MediaLibraryApi.md#getmyresolvedmediarootpermissions) | **GET** /api/2/media/root-permissions/mine/resolved | 
*MediaLibraryApi* | [**GetProxy**](docs/MediaLibraryApi.md#getproxy) | **GET** /api/2/media/proxies/{id} | 
*MediaLibraryApi* | [**GetProxyGenerator**](docs/MediaLibraryApi.md#getproxygenerator) | **GET** /api/2/media/proxy-generators/{id} | 
*MediaLibraryApi* | [**GetProxyProfile**](docs/MediaLibraryApi.md#getproxyprofile) | **GET** /api/2/media/proxy-profiles/{id} | 
*MediaLibraryApi* | [**GetProxyProfileProxyCount**](docs/MediaLibraryApi.md#getproxyprofileproxycount) | **GET** /api/2/media/proxy-profiles/{id}/proxy-count | 
*MediaLibraryApi* | [**GetSubclip**](docs/MediaLibraryApi.md#getsubclip) | **GET** /api/2/media/subclips/{id} | 
*MediaLibraryApi* | [**GetTranscoderProfile**](docs/MediaLibraryApi.md#gettranscoderprofile) | **GET** /api/2/transcoder-profiles/{id} | 
*MediaLibraryApi* | [**GetVantageWorkflows**](docs/MediaLibraryApi.md#getvantageworkflows) | **GET** /api/2/media/external-transcoders/{id}/workflows | 
*MediaLibraryApi* | [**InstantiateMediaFileTemplate**](docs/MediaLibraryApi.md#instantiatemediafiletemplate) | **POST** /api/2/media/files/templates/{id}/instantiate | 
*MediaLibraryApi* | [**LocateEditorProjectPaths**](docs/MediaLibraryApi.md#locateeditorprojectpaths) | **GET** /api/2/media/editor/{id}/locate-paths | 
*MediaLibraryApi* | [**MarkMediaDirectoryAsShowroom**](docs/MediaLibraryApi.md#markmediadirectoryasshowroom) | **POST** /api/2/media/files/{id}/showroom | 
*MediaLibraryApi* | [**PatchAsset**](docs/MediaLibraryApi.md#patchasset) | **PATCH** /api/2/media/assets/{id} | 
*MediaLibraryApi* | [**PatchAssetRating**](docs/MediaLibraryApi.md#patchassetrating) | **PATCH** /api/2/media/ratings/{id} | 
*MediaLibraryApi* | [**PatchComment**](docs/MediaLibraryApi.md#patchcomment) | **PATCH** /api/2/media/comments/{id} | 
*MediaLibraryApi* | [**PatchCustomField**](docs/MediaLibraryApi.md#patchcustomfield) | **PATCH** /api/2/media/custom-fields/{id} | 
*MediaLibraryApi* | [**PatchEditorProject**](docs/MediaLibraryApi.md#patcheditorproject) | **PATCH** /api/2/media/editor/{id} | 
*MediaLibraryApi* | [**PatchExternalTranscoder**](docs/MediaLibraryApi.md#patchexternaltranscoder) | **PATCH** /api/2/media/external-transcoders/{id} | 
*MediaLibraryApi* | [**PatchMarker**](docs/MediaLibraryApi.md#patchmarker) | **PATCH** /api/2/media/markers/{id} | 
*MediaLibraryApi* | [**PatchMediaFile**](docs/MediaLibraryApi.md#patchmediafile) | **PATCH** /api/2/media/files/{id} | 
*MediaLibraryApi* | [**PatchMediaFileTemplate**](docs/MediaLibraryApi.md#patchmediafiletemplate) | **PATCH** /api/2/media/files/templates/{id} | 
*MediaLibraryApi* | [**PatchMediaRoot**](docs/MediaLibraryApi.md#patchmediaroot) | **PATCH** /api/2/media/roots/{id} | 
*MediaLibraryApi* | [**PatchMediaRootPermission**](docs/MediaLibraryApi.md#patchmediarootpermission) | **PATCH** /api/2/media/root-permissions/{id} | 
*MediaLibraryApi* | [**PatchMediaTag**](docs/MediaLibraryApi.md#patchmediatag) | **PATCH** /api/2/media/tags/{id} | 
*MediaLibraryApi* | [**PatchProxyProfile**](docs/MediaLibraryApi.md#patchproxyprofile) | **PATCH** /api/2/media/proxy-profiles/{id} | 
*MediaLibraryApi* | [**PatchSubclip**](docs/MediaLibraryApi.md#patchsubclip) | **PATCH** /api/2/media/subclips/{id} | 
*MediaLibraryApi* | [**RecursivelyTagMediaDirectory**](docs/MediaLibraryApi.md#recursivelytagmediadirectory) | **POST** /api/2/media/files/{id}/tag | 
*MediaLibraryApi* | [**ReindexMediaDirectory**](docs/MediaLibraryApi.md#reindexmediadirectory) | **POST** /api/2/media/files/{id}/search-reindex | 
*MediaLibraryApi* | [**RenameCustomField**](docs/MediaLibraryApi.md#renamecustomfield) | **POST** /api/2/media/custom-fields/{id}/rename | 
*MediaLibraryApi* | [**RenderSequence**](docs/MediaLibraryApi.md#rendersequence) | **POST** /api/2/media/editor/render | 
*MediaLibraryApi* | [**RenderSubclip**](docs/MediaLibraryApi.md#rendersubclip) | **POST** /api/2/media/subclips/{id}/render | 
*MediaLibraryApi* | [**RequestMediaScan**](docs/MediaLibraryApi.md#requestmediascan) | **POST** /api/2/scanner/scan | 
*MediaLibraryApi* | [**ResolveComment**](docs/MediaLibraryApi.md#resolvecomment) | **POST** /api/2/media/comments/{id}/resolve | 
*MediaLibraryApi* | [**ShareMediaLibraryObjects**](docs/MediaLibraryApi.md#sharemedialibraryobjects) | **POST** /api/2/media/share | 
*MediaLibraryApi* | [**TestExternalTranscoderConnection**](docs/MediaLibraryApi.md#testexternaltranscoderconnection) | **POST** /api/2/media/external-transcoders/test-connection | 
*MediaLibraryApi* | [**TransitionWorkflow**](docs/MediaLibraryApi.md#transitionworkflow) | **POST** /api/2/media/workflow/transition | 
*MediaLibraryApi* | [**UnbookmarkMediaDirectory**](docs/MediaLibraryApi.md#unbookmarkmediadirectory) | **DELETE** /api/2/media/files/{id}/bookmark | 
*MediaLibraryApi* | [**UnmarkMediaDirectoryAsShowroom**](docs/MediaLibraryApi.md#unmarkmediadirectoryasshowroom) | **DELETE** /api/2/media/files/{id}/showroom | 
*MediaLibraryApi* | [**UnresolveComment**](docs/MediaLibraryApi.md#unresolvecomment) | **POST** /api/2/media/comments/{id}/unresolve | 
*MediaLibraryApi* | [**UpdateAsset**](docs/MediaLibraryApi.md#updateasset) | **PUT** /api/2/media/assets/{id} | 
*MediaLibraryApi* | [**UpdateAssetRating**](docs/MediaLibraryApi.md#updateassetrating) | **PUT** /api/2/media/ratings/{id} | 
*MediaLibraryApi* | [**UpdateComment**](docs/MediaLibraryApi.md#updatecomment) | **PUT** /api/2/media/comments/{id} | 
*MediaLibraryApi* | [**UpdateCustomField**](docs/MediaLibraryApi.md#updatecustomfield) | **PUT** /api/2/media/custom-fields/{id} | 
*MediaLibraryApi* | [**UpdateEditorProject**](docs/MediaLibraryApi.md#updateeditorproject) | **PUT** /api/2/media/editor/{id} | 
*MediaLibraryApi* | [**UpdateExternalTranscoder**](docs/MediaLibraryApi.md#updateexternaltranscoder) | **PUT** /api/2/media/external-transcoders/{id} | 
*MediaLibraryApi* | [**UpdateMarker**](docs/MediaLibraryApi.md#updatemarker) | **PUT** /api/2/media/markers/{id} | 
*MediaLibraryApi* | [**UpdateMediaFile**](docs/MediaLibraryApi.md#updatemediafile) | **PUT** /api/2/media/files/{id} | 
*MediaLibraryApi* | [**UpdateMediaFileTemplate**](docs/MediaLibraryApi.md#updatemediafiletemplate) | **PUT** /api/2/media/files/templates/{id} | 
*MediaLibraryApi* | [**UpdateMediaRoot**](docs/MediaLibraryApi.md#updatemediaroot) | **PUT** /api/2/media/roots/{id} | 
*MediaLibraryApi* | [**UpdateMediaRootPermission**](docs/MediaLibraryApi.md#updatemediarootpermission) | **PUT** /api/2/media/root-permissions/{id} | 
*MediaLibraryApi* | [**UpdateMediaTag**](docs/MediaLibraryApi.md#updatemediatag) | **PUT** /api/2/media/tags/{id} | 
*MediaLibraryApi* | [**UpdateProxyProfile**](docs/MediaLibraryApi.md#updateproxyprofile) | **PUT** /api/2/media/proxy-profiles/{id} | 
*MediaLibraryApi* | [**UpdateSubclip**](docs/MediaLibraryApi.md#updatesubclip) | **PUT** /api/2/media/subclips/{id} | 
*SatelliteApi* | [**ActivateSatelliteHost**](docs/SatelliteApi.md#activatesatellitehost) | **POST** /api/2/rdc/hosts/{id}/activate | 
*SatelliteApi* | [**AnnounceSatelliteHost**](docs/SatelliteApi.md#announcesatellitehost) | **POST** /api/2/rdc/hosts/announce | 
*SatelliteApi* | [**CreateSatelliteSession**](docs/SatelliteApi.md#createsatellitesession) | **POST** /api/2/rdc/sessions | 
*SatelliteApi* | [**DeleteSatelliteSession**](docs/SatelliteApi.md#deletesatellitesession) | **DELETE** /api/2/rdc/sessions/{id} | 
*SatelliteApi* | [**GetAllSatelliteHosts**](docs/SatelliteApi.md#getallsatellitehosts) | **GET** /api/2/rdc/hosts | 
*SatelliteApi* | [**GetAllSatelliteSessions**](docs/SatelliteApi.md#getallsatellitesessions) | **GET** /api/2/rdc/sessions | 
*SatelliteApi* | [**GetSatelliteHost**](docs/SatelliteApi.md#getsatellitehost) | **GET** /api/2/rdc/hosts/{id} | 
*SatelliteApi* | [**GetSatelliteSession**](docs/SatelliteApi.md#getsatellitesession) | **GET** /api/2/rdc/sessions/{id} | 
*StatusApi* | [**GetAlert**](docs/StatusApi.md#getalert) | **GET** /api/2/alerts/{id} | 
*StatusApi* | [**GetAllAlerts**](docs/StatusApi.md#getallalerts) | **GET** /api/2/alerts | 
*StatusApi* | [**GetTelegrafStats**](docs/StatusApi.md#gettelegrafstats) | **GET** /api/2/telegraf-stats | 
*StatusApi* | [**PatchAlert**](docs/StatusApi.md#patchalert) | **PATCH** /api/2/alerts/{id} | 
*StatusApi* | [**SubmitKapacitorAlert**](docs/StatusApi.md#submitkapacitoralert) | **POST** /api/2/alerts/submit | 
*StatusApi* | [**UpdateAlert**](docs/StatusApi.md#updatealert) | **PUT** /api/2/alerts/{id} | 
*StorageApi* | [**ApplyWorkspaceAffinity**](docs/StorageApi.md#applyworkspaceaffinity) | **POST** /api/2/workspaces/{id}/apply-affinity | 
*StorageApi* | [**BookmarkWorkspace**](docs/StorageApi.md#bookmarkworkspace) | **POST** /api/2/workspaces/{id}/bookmark | 
*StorageApi* | [**CalculateDirectorySize**](docs/StorageApi.md#calculatedirectorysize) | **POST** /api/2/filesystem/calculate-directory-size | 
*StorageApi* | [**CheckInIntoWorkspace**](docs/StorageApi.md#checkinintoworkspace) | **POST** /api/2/workspaces/{id}/check-in | 
*StorageApi* | [**CheckOutOfWorkspace**](docs/StorageApi.md#checkoutofworkspace) | **POST** /api/2/workspaces/{id}/check-out | 
*StorageApi* | [**CopyFiles**](docs/StorageApi.md#copyfiles) | **POST** /api/2/filesystem/copy | 
*StorageApi* | [**CreateFile**](docs/StorageApi.md#createfile) | **POST** /api/2/files | 
*StorageApi* | [**CreatePathQuota**](docs/StorageApi.md#createpathquota) | **POST** /api/2/volumes/{id}/quotas/path/{relative_path} | 
*StorageApi* | [**CreateProduction**](docs/StorageApi.md#createproduction) | **POST** /api/2/productions | 
*StorageApi* | [**CreateShare**](docs/StorageApi.md#createshare) | **POST** /api/2/shares | 
*StorageApi* | [**CreateSnapshot**](docs/StorageApi.md#createsnapshot) | **POST** /api/2/snapshots | 
*StorageApi* | [**CreateTemplateFolder**](docs/StorageApi.md#createtemplatefolder) | **POST** /api/2/private/create-template-folder | 
*StorageApi* | [**CreateWorkspace**](docs/StorageApi.md#createworkspace) | **POST** /api/2/workspaces | 
*StorageApi* | [**CreateWorkspacePermission**](docs/StorageApi.md#createworkspacepermission) | **POST** /api/2/workspace-permissions | 
*StorageApi* | [**DeleteFile**](docs/StorageApi.md#deletefile) | **DELETE** /api/2/files/{path} | 
*StorageApi* | [**DeleteFiles**](docs/StorageApi.md#deletefiles) | **POST** /api/2/filesystem/delete | 
*StorageApi* | [**DeletePathQuota**](docs/StorageApi.md#deletepathquota) | **DELETE** /api/2/volumes/{id}/quotas/path/{relative_path} | 
*StorageApi* | [**DeleteProduction**](docs/StorageApi.md#deleteproduction) | **DELETE** /api/2/productions/{id} | 
*StorageApi* | [**DeleteShare**](docs/StorageApi.md#deleteshare) | **DELETE** /api/2/shares/{id} | 
*StorageApi* | [**DeleteSnapshot**](docs/StorageApi.md#deletesnapshot) | **DELETE** /api/2/snapshots/{id} | 
*StorageApi* | [**DeleteWorkspace**](docs/StorageApi.md#deleteworkspace) | **DELETE** /api/2/workspaces/{id} | 
*StorageApi* | [**DeleteWorkspacePermission**](docs/StorageApi.md#deleteworkspacepermission) | **DELETE** /api/2/workspace-permissions/{id} | 
*StorageApi* | [**GetAllDeletedWorkspaces**](docs/StorageApi.md#getalldeletedworkspaces) | **GET** /api/2/workspaces/deleted | 
*StorageApi* | [**GetAllProductions**](docs/StorageApi.md#getallproductions) | **GET** /api/2/productions | 
*StorageApi* | [**GetAllShares**](docs/StorageApi.md#getallshares) | **GET** /api/2/shares | 
*StorageApi* | [**GetAllSnapshots**](docs/StorageApi.md#getallsnapshots) | **GET** /api/2/snapshots | 
*StorageApi* | [**GetAllVolumes**](docs/StorageApi.md#getallvolumes) | **GET** /api/2/volumes | 
*StorageApi* | [**GetAllWorkspacePermissions**](docs/StorageApi.md#getallworkspacepermissions) | **GET** /api/2/workspace-permissions | 
*StorageApi* | [**GetAllWorkspaces**](docs/StorageApi.md#getallworkspaces) | **GET** /api/2/workspaces | 
*StorageApi* | [**GetFile**](docs/StorageApi.md#getfile) | **GET** /api/2/files/{path} | 
*StorageApi* | [**GetGroupQuota**](docs/StorageApi.md#getgroupquota) | **GET** /api/2/volumes/{id}/quotas/group/{group_id} | 
*StorageApi* | [**GetMyWorkspaces**](docs/StorageApi.md#getmyworkspaces) | **GET** /api/2/workspaces/mine | 
*StorageApi* | [**GetPathQuota**](docs/StorageApi.md#getpathquota) | **GET** /api/2/volumes/{id}/quotas/path/{relative_path} | 
*StorageApi* | [**GetProduction**](docs/StorageApi.md#getproduction) | **GET** /api/2/productions/{id} | 
*StorageApi* | [**GetRootDirectory**](docs/StorageApi.md#getrootdirectory) | **GET** /api/2/files | 
*StorageApi* | [**GetSambaDfreeString**](docs/StorageApi.md#getsambadfreestring) | **POST** /api/2/private/dfree | 
*StorageApi* | [**GetShare**](docs/StorageApi.md#getshare) | **GET** /api/2/shares/{id} | 
*StorageApi* | [**GetSnapshot**](docs/StorageApi.md#getsnapshot) | **GET** /api/2/snapshots/{id} | 
*StorageApi* | [**GetUserQuota**](docs/StorageApi.md#getuserquota) | **GET** /api/2/volumes/{id}/quotas/user/{user_id} | 
*StorageApi* | [**GetVolume**](docs/StorageApi.md#getvolume) | **GET** /api/2/volumes/{id} | 
*StorageApi* | [**GetVolumeActiveConnections**](docs/StorageApi.md#getvolumeactiveconnections) | **GET** /api/2/volumes/{id}/connections | 
*StorageApi* | [**GetVolumeFileSizeDistribution**](docs/StorageApi.md#getvolumefilesizedistribution) | **GET** /api/2/volumes/{id}/file-size-distribution | 
*StorageApi* | [**GetVolumeStats**](docs/StorageApi.md#getvolumestats) | **GET** /api/2/volumes/{id}/stats | 
*StorageApi* | [**GetWorkspace**](docs/StorageApi.md#getworkspace) | **GET** /api/2/workspaces/{id} | 
*StorageApi* | [**GetWorkspacePermission**](docs/StorageApi.md#getworkspacepermission) | **GET** /api/2/workspace-permissions/{id} | 
*StorageApi* | [**MoveFiles**](docs/StorageApi.md#movefiles) | **POST** /api/2/filesystem/move | 
*StorageApi* | [**MoveWorkspace**](docs/StorageApi.md#moveworkspace) | **POST** /api/2/workspaces/{id}/move | 
*StorageApi* | [**MoveWorkspaceToProduction**](docs/StorageApi.md#moveworkspacetoproduction) | **POST** /api/2/workspaces/{id}/move-to | 
*StorageApi* | [**PatchFile**](docs/StorageApi.md#patchfile) | **PATCH** /api/2/files/{path} | 
*StorageApi* | [**PatchProduction**](docs/StorageApi.md#patchproduction) | **PATCH** /api/2/productions/{id} | 
*StorageApi* | [**PatchShare**](docs/StorageApi.md#patchshare) | **PATCH** /api/2/shares/{id} | 
*StorageApi* | [**PatchSnapshot**](docs/StorageApi.md#patchsnapshot) | **PATCH** /api/2/snapshots/{id} | 
*StorageApi* | [**PatchVolume**](docs/StorageApi.md#patchvolume) | **PATCH** /api/2/volumes/{id} | 
*StorageApi* | [**PatchWorkspace**](docs/StorageApi.md#patchworkspace) | **PATCH** /api/2/workspaces/{id} | 
*StorageApi* | [**PatchWorkspacePermission**](docs/StorageApi.md#patchworkspacepermission) | **PATCH** /api/2/workspace-permissions/{id} | 
*StorageApi* | [**RecordStorageTrace**](docs/StorageApi.md#recordstoragetrace) | **POST** /api/2/filesystem/trace | 
*StorageApi* | [**RepairWorkspacePermissions**](docs/StorageApi.md#repairworkspacepermissions) | **POST** /api/2/workspaces/{id}/repair-permissions | 
*StorageApi* | [**ShareToHomeWorkspace**](docs/StorageApi.md#sharetohomeworkspace) | **POST** /api/2/share-to-home-workspace | 
*StorageApi* | [**UnbookmarkWorkspace**](docs/StorageApi.md#unbookmarkworkspace) | **DELETE** /api/2/workspaces/{id}/bookmark | 
*StorageApi* | [**UnzipFile**](docs/StorageApi.md#unzipfile) | **POST** /api/2/filesystem/unzip | 
*StorageApi* | [**UpdateGroupQuota**](docs/StorageApi.md#updategroupquota) | **PUT** /api/2/volumes/{id}/quotas/group/{group_id} | 
*StorageApi* | [**UpdatePathQuota**](docs/StorageApi.md#updatepathquota) | **PUT** /api/2/volumes/{id}/quotas/path/{relative_path} | 
*StorageApi* | [**UpdateProduction**](docs/StorageApi.md#updateproduction) | **PUT** /api/2/productions/{id} | 
*StorageApi* | [**UpdateShare**](docs/StorageApi.md#updateshare) | **PUT** /api/2/shares/{id} | 
*StorageApi* | [**UpdateSnapshot**](docs/StorageApi.md#updatesnapshot) | **PUT** /api/2/snapshots/{id} | 
*StorageApi* | [**UpdateUserQuota**](docs/StorageApi.md#updateuserquota) | **PUT** /api/2/volumes/{id}/quotas/user/{user_id} | 
*StorageApi* | [**UpdateVolume**](docs/StorageApi.md#updatevolume) | **PUT** /api/2/volumes/{id} | 
*StorageApi* | [**UpdateWorkspace**](docs/StorageApi.md#updateworkspace) | **PUT** /api/2/workspaces/{id} | 
*StorageApi* | [**UpdateWorkspacePermission**](docs/StorageApi.md#updateworkspacepermission) | **PUT** /api/2/workspace-permissions/{id} | 
*StorageApi* | [**ZipFiles**](docs/StorageApi.md#zipfiles) | **POST** /api/2/filesystem/zip | 
*TapeArchiveApi* | [**ArchiveToTape**](docs/TapeArchiveApi.md#archivetotape) | **POST** /api/2/archive/tape/archive | 
*TapeArchiveApi* | [**CancelAllTapeArchiveJobs**](docs/TapeArchiveApi.md#cancelalltapearchivejobs) | **POST** /api/2/archive/tape/jobs/cancel-all | 
*TapeArchiveApi* | [**CheckTape**](docs/TapeArchiveApi.md#checktape) | **POST** /api/2/archive/tape/library/check | 
*TapeArchiveApi* | [**CreateTape**](docs/TapeArchiveApi.md#createtape) | **POST** /api/2/archive/tape/tapes | 
*TapeArchiveApi* | [**CreateTapeGroup**](docs/TapeArchiveApi.md#createtapegroup) | **POST** /api/2/archive/tape/groups | 
*TapeArchiveApi* | [**DeleteTape**](docs/TapeArchiveApi.md#deletetape) | **DELETE** /api/2/archive/tape/tapes/{id} | 
*TapeArchiveApi* | [**DeleteTapeArchiveJob**](docs/TapeArchiveApi.md#deletetapearchivejob) | **DELETE** /api/2/archive/tape/jobs/{id} | 
*TapeArchiveApi* | [**DeleteTapeGroup**](docs/TapeArchiveApi.md#deletetapegroup) | **DELETE** /api/2/archive/tape/groups/{id} | 
*TapeArchiveApi* | [**FormatTape**](docs/TapeArchiveApi.md#formattape) | **POST** /api/2/archive/tape/library/format | 
*TapeArchiveApi* | [**GetAllArchivedFileEntries**](docs/TapeArchiveApi.md#getallarchivedfileentries) | **GET** /api/2/archive/tape/files | 
*TapeArchiveApi* | [**GetAllTapeArchiveJobs**](docs/TapeArchiveApi.md#getalltapearchivejobs) | **GET** /api/2/archive/tape/jobs | 
*TapeArchiveApi* | [**GetAllTapeGroups**](docs/TapeArchiveApi.md#getalltapegroups) | **GET** /api/2/archive/tape/groups | 
*TapeArchiveApi* | [**GetAllTapes**](docs/TapeArchiveApi.md#getalltapes) | **GET** /api/2/archive/tape/tapes | 
*TapeArchiveApi* | [**GetArchivedFileEntry**](docs/TapeArchiveApi.md#getarchivedfileentry) | **GET** /api/2/archive/tape/files/{id} | 
*TapeArchiveApi* | [**GetTape**](docs/TapeArchiveApi.md#gettape) | **GET** /api/2/archive/tape/tapes/{id} | 
*TapeArchiveApi* | [**GetTapeArchiveJob**](docs/TapeArchiveApi.md#gettapearchivejob) | **GET** /api/2/archive/tape/jobs/{id} | 
*TapeArchiveApi* | [**GetTapeArchiveJobSources**](docs/TapeArchiveApi.md#gettapearchivejobsources) | **GET** /api/2/archive/tape/jobs/{id}/sources | 
*TapeArchiveApi* | [**GetTapeGroup**](docs/TapeArchiveApi.md#gettapegroup) | **GET** /api/2/archive/tape/groups/{id} | 
*TapeArchiveApi* | [**GetTapeLibraryState**](docs/TapeArchiveApi.md#gettapelibrarystate) | **GET** /api/2/archive/tape/library | 
*TapeArchiveApi* | [**LoadTape**](docs/TapeArchiveApi.md#loadtape) | **POST** /api/2/archive/tape/library/load | 
*TapeArchiveApi* | [**MoveTape**](docs/TapeArchiveApi.md#movetape) | **POST** /api/2/archive/tape/library/move | 
*TapeArchiveApi* | [**PatchTape**](docs/TapeArchiveApi.md#patchtape) | **PATCH** /api/2/archive/tape/tapes/{id} | 
*TapeArchiveApi* | [**PatchTapeGroup**](docs/TapeArchiveApi.md#patchtapegroup) | **PATCH** /api/2/archive/tape/groups/{id} | 
*TapeArchiveApi* | [**PauseTapeArchiveJob**](docs/TapeArchiveApi.md#pausetapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/pause | 
*TapeArchiveApi* | [**RefreshTapeLibraryState**](docs/TapeArchiveApi.md#refreshtapelibrarystate) | **POST** /api/2/archive/tape/library/refresh | 
*TapeArchiveApi* | [**ReindexTape**](docs/TapeArchiveApi.md#reindextape) | **POST** /api/2/archive/tape/library/reindex | 
*TapeArchiveApi* | [**RemoveFinishedTapeArchiveJobs**](docs/TapeArchiveApi.md#removefinishedtapearchivejobs) | **POST** /api/2/archive/tape/jobs/remove-finished | 
*TapeArchiveApi* | [**RestartTapeArchiveJob**](docs/TapeArchiveApi.md#restarttapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/restart | 
*TapeArchiveApi* | [**RestoreFromTape**](docs/TapeArchiveApi.md#restorefromtape) | **POST** /api/2/archive/tape/restore | 
*TapeArchiveApi* | [**ResumeTapeArchiveJob**](docs/TapeArchiveApi.md#resumetapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/resume | 
*TapeArchiveApi* | [**SearchTapeArchive**](docs/TapeArchiveApi.md#searchtapearchive) | **POST** /api/2/archive/tape/search | 
*TapeArchiveApi* | [**UnloadTape**](docs/TapeArchiveApi.md#unloadtape) | **POST** /api/2/archive/tape/library/unload | 
*TapeArchiveApi* | [**UpdateTape**](docs/TapeArchiveApi.md#updatetape) | **PUT** /api/2/archive/tape/tapes/{id} | 
*TapeArchiveApi* | [**UpdateTapeGroup**](docs/TapeArchiveApi.md#updatetapegroup) | **PUT** /api/2/archive/tape/groups/{id} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AWSAccount](docs/AWSAccount.md)
 - [Model.AWSAccountPartialUpdate](docs/AWSAccountPartialUpdate.md)
 - [Model.AddAssetsToClickGallery](docs/AddAssetsToClickGallery.md)
 - [Model.Address](docs/Address.md)
 - [Model.Alert](docs/Alert.md)
 - [Model.AlertPartialUpdate](docs/AlertPartialUpdate.md)
 - [Model.AllMediaFilesForBundlesRequest](docs/AllMediaFilesForBundlesRequest.md)
 - [Model.ArchiveEndpointRequest](docs/ArchiveEndpointRequest.md)
 - [Model.ArgumentType](docs/ArgumentType.md)
 - [Model.Asset](docs/Asset.md)
 - [Model.AssetBackup](docs/AssetBackup.md)
 - [Model.AssetCloudLink](docs/AssetCloudLink.md)
 - [Model.AssetMini](docs/AssetMini.md)
 - [Model.AssetMiniReference](docs/AssetMiniReference.md)
 - [Model.AssetPartialUpdate](docs/AssetPartialUpdate.md)
 - [Model.AssetProjectLink](docs/AssetProjectLink.md)
 - [Model.AssetRating](docs/AssetRating.md)
 - [Model.AssetRatingPartialUpdate](docs/AssetRatingPartialUpdate.md)
 - [Model.AuthLoginEndpointRequest](docs/AuthLoginEndpointRequest.md)
 - [Model.AuthLoginEndpointResponse](docs/AuthLoginEndpointResponse.md)
 - [Model.Backend](docs/Backend.md)
 - [Model.BackendProperties](docs/BackendProperties.md)
 - [Model.BasicFile](docs/BasicFile.md)
 - [Model.BeeGFSNode](docs/BeeGFSNode.md)
 - [Model.BeeGFSTarget](docs/BeeGFSTarget.md)
 - [Model.CPUStat](docs/CPUStat.md)
 - [Model.Certificate](docs/Certificate.md)
 - [Model.ChangeOwnPasswordRequest](docs/ChangeOwnPasswordRequest.md)
 - [Model.ChangePasswordRequest](docs/ChangePasswordRequest.md)
 - [Model.CheckConnectivityEndpointResponse](docs/CheckConnectivityEndpointResponse.md)
 - [Model.ClickBackgroundUploadEndpointRequest](docs/ClickBackgroundUploadEndpointRequest.md)
 - [Model.ClickGallery](docs/ClickGallery.md)
 - [Model.ClickGalleryLink](docs/ClickGalleryLink.md)
 - [Model.ClickLinkUser](docs/ClickLinkUser.md)
 - [Model.ClickStartUploadEndpointRequest](docs/ClickStartUploadEndpointRequest.md)
 - [Model.ClientSession](docs/ClientSession.md)
 - [Model.ClientsEndpointResponse](docs/ClientsEndpointResponse.md)
 - [Model.CloudConnection](docs/CloudConnection.md)
 - [Model.Comment](docs/Comment.md)
 - [Model.CommentPartialUpdate](docs/CommentPartialUpdate.md)
 - [Model.CreateDownloadArchive](docs/CreateDownloadArchive.md)
 - [Model.CreateHomeWorkspaceRequest](docs/CreateHomeWorkspaceRequest.md)
 - [Model.CreatePathQuotaRequest](docs/CreatePathQuotaRequest.md)
 - [Model.CreateTemplateFolderEndpointRequest](docs/CreateTemplateFolderEndpointRequest.md)
 - [Model.CustomField](docs/CustomField.md)
 - [Model.CustomFieldPartialUpdate](docs/CustomFieldPartialUpdate.md)
 - [Model.CustomFieldReference](docs/CustomFieldReference.md)
 - [Model.DeletedWorkspace](docs/DeletedWorkspace.md)
 - [Model.Download](docs/Download.md)
 - [Model.DownloadArchive](docs/DownloadArchive.md)
 - [Model.DownloadArchivePartialUpdate](docs/DownloadArchivePartialUpdate.md)
 - [Model.EditorProject](docs/EditorProject.md)
 - [Model.EditorProjectPartialUpdate](docs/EditorProjectPartialUpdate.md)
 - [Model.ElementsGroup](docs/ElementsGroup.md)
 - [Model.ElementsGroupDetail](docs/ElementsGroupDetail.md)
 - [Model.ElementsGroupDetailPartialUpdate](docs/ElementsGroupDetailPartialUpdate.md)
 - [Model.ElementsGroupReference](docs/ElementsGroupReference.md)
 - [Model.ElementsUser](docs/ElementsUser.md)
 - [Model.ElementsUserDetail](docs/ElementsUserDetail.md)
 - [Model.ElementsUserDetailPartialUpdate](docs/ElementsUserDetailPartialUpdate.md)
 - [Model.ElementsUserMini](docs/ElementsUserMini.md)
 - [Model.ElementsUserMiniReference](docs/ElementsUserMiniReference.md)
 - [Model.ElementsUserProfile](docs/ElementsUserProfile.md)
 - [Model.ElementsUserProfilePartialUpdate](docs/ElementsUserProfilePartialUpdate.md)
 - [Model.ElementsUserReference](docs/ElementsUserReference.md)
 - [Model.ElementsVersion](docs/ElementsVersion.md)
 - [Model.EmailPreview](docs/EmailPreview.md)
 - [Model.EnableTOTPRequest](docs/EnableTOTPRequest.md)
 - [Model.Event](docs/Event.md)
 - [Model.ExternalTranscoder](docs/ExternalTranscoder.md)
 - [Model.ExternalTranscoderPartialUpdate](docs/ExternalTranscoderPartialUpdate.md)
 - [Model.FSProperties](docs/FSProperties.md)
 - [Model.FileCopyEndpointRequest](docs/FileCopyEndpointRequest.md)
 - [Model.FileDeleteEndpointRequest](docs/FileDeleteEndpointRequest.md)
 - [Model.FileMoveEndpointRequest](docs/FileMoveEndpointRequest.md)
 - [Model.FilePartialUpdate](docs/FilePartialUpdate.md)
 - [Model.FileSizeDistribution](docs/FileSizeDistribution.md)
 - [Model.FileSizeDistributionItem](docs/FileSizeDistributionItem.md)
 - [Model.FileSizeEndpointResponse](docs/FileSizeEndpointResponse.md)
 - [Model.FileUnzipEndpointRequest](docs/FileUnzipEndpointRequest.md)
 - [Model.FileZipEndpointRequest](docs/FileZipEndpointRequest.md)
 - [Model.FilesystemFile](docs/FilesystemFile.md)
 - [Model.FilesystemTraceEndpointRequest](docs/FilesystemTraceEndpointRequest.md)
 - [Model.FilesystemTraceEndpointResponse](docs/FilesystemTraceEndpointResponse.md)
 - [Model.FinishUploadEndpointRequest](docs/FinishUploadEndpointRequest.md)
 - [Model.GeneratePasswordEndpointResponse](docs/GeneratePasswordEndpointResponse.md)
 - [Model.GenerateProxiesRequest](docs/GenerateProxiesRequest.md)
 - [Model.GetMultipleBundlesRequest](docs/GetMultipleBundlesRequest.md)
 - [Model.GetMultipleFilesRequest](docs/GetMultipleFilesRequest.md)
 - [Model.GlobalAlert](docs/GlobalAlert.md)
 - [Model.IOStat](docs/IOStat.md)
 - [Model.ImpersonationEndpointRequest](docs/ImpersonationEndpointRequest.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InstantiateFileTemplateRequest](docs/InstantiateFileTemplateRequest.md)
 - [Model.Interface](docs/Interface.md)
 - [Model.Ipmi](docs/Ipmi.md)
 - [Model.Job](docs/Job.md)
 - [Model.JobPartialUpdate](docs/JobPartialUpdate.md)
 - [Model.JobReference](docs/JobReference.md)
 - [Model.KapacitorAlert](docs/KapacitorAlert.md)
 - [Model.LDAPServer](docs/LDAPServer.md)
 - [Model.LDAPServerGroup](docs/LDAPServerGroup.md)
 - [Model.LDAPServerGroups](docs/LDAPServerGroups.md)
 - [Model.LDAPServerReference](docs/LDAPServerReference.md)
 - [Model.LDAPServerUser](docs/LDAPServerUser.md)
 - [Model.LDAPServerUsers](docs/LDAPServerUsers.md)
 - [Model.License](docs/License.md)
 - [Model.ListBuckets](docs/ListBuckets.md)
 - [Model.ListTopics](docs/ListTopics.md)
 - [Model.LizardFSDisk](docs/LizardFSDisk.md)
 - [Model.LizardFSNode](docs/LizardFSNode.md)
 - [Model.LocateResult](docs/LocateResult.md)
 - [Model.Marker](docs/Marker.md)
 - [Model.MarkerPartialUpdate](docs/MarkerPartialUpdate.md)
 - [Model.MediaFile](docs/MediaFile.md)
 - [Model.MediaFileBundle](docs/MediaFileBundle.md)
 - [Model.MediaFileBundleMiniReference](docs/MediaFileBundleMiniReference.md)
 - [Model.MediaFileContents](docs/MediaFileContents.md)
 - [Model.MediaFileMini](docs/MediaFileMini.md)
 - [Model.MediaFilePartialUpdate](docs/MediaFilePartialUpdate.md)
 - [Model.MediaFileReference](docs/MediaFileReference.md)
 - [Model.MediaFileTemplate](docs/MediaFileTemplate.md)
 - [Model.MediaFileTemplatePartialUpdate](docs/MediaFileTemplatePartialUpdate.md)
 - [Model.MediaLibraryDeleteRequest](docs/MediaLibraryDeleteRequest.md)
 - [Model.MediaLibraryShareRequest](docs/MediaLibraryShareRequest.md)
 - [Model.MediaRoot](docs/MediaRoot.md)
 - [Model.MediaRootMini](docs/MediaRootMini.md)
 - [Model.MediaRootMiniReference](docs/MediaRootMiniReference.md)
 - [Model.MediaRootPartialUpdate](docs/MediaRootPartialUpdate.md)
 - [Model.MediaRootPermission](docs/MediaRootPermission.md)
 - [Model.MediaRootPermissionAccessOptions](docs/MediaRootPermissionAccessOptions.md)
 - [Model.MediaRootPermissionPartialUpdate](docs/MediaRootPermissionPartialUpdate.md)
 - [Model.MediaUpdate](docs/MediaUpdate.md)
 - [Model.MemberPreview](docs/MemberPreview.md)
 - [Model.MetadataItem](docs/MetadataItem.md)
 - [Model.MoveWorkspaceRequest](docs/MoveWorkspaceRequest.md)
 - [Model.MultipleAssetsRequest](docs/MultipleAssetsRequest.md)
 - [Model.NTPServer](docs/NTPServer.md)
 - [Model.NTPServerPartialUpdate](docs/NTPServerPartialUpdate.md)
 - [Model.NetStat](docs/NetStat.md)
 - [Model.OneTimeAccessToken](docs/OneTimeAccessToken.md)
 - [Model.OneTimeAccessTokenActivity](docs/OneTimeAccessTokenActivity.md)
 - [Model.OneTimeAccessTokenSharedObject](docs/OneTimeAccessTokenSharedObject.md)
 - [Model.Parameters](docs/Parameters.md)
 - [Model.PasswordResetEndpointRequest](docs/PasswordResetEndpointRequest.md)
 - [Model.Path](docs/Path.md)
 - [Model.PathInput](docs/PathInput.md)
 - [Model.Production](docs/Production.md)
 - [Model.ProductionPartialUpdate](docs/ProductionPartialUpdate.md)
 - [Model.ProductionReference](docs/ProductionReference.md)
 - [Model.Proxy](docs/Proxy.md)
 - [Model.ProxyCount](docs/ProxyCount.md)
 - [Model.ProxyGenerator](docs/ProxyGenerator.md)
 - [Model.ProxyGeneratorProperties](docs/ProxyGeneratorProperties.md)
 - [Model.ProxyProfile](docs/ProxyProfile.md)
 - [Model.ProxyProfileMini](docs/ProxyProfileMini.md)
 - [Model.ProxyProfilePartialUpdate](docs/ProxyProfilePartialUpdate.md)
 - [Model.PythonEnvironment](docs/PythonEnvironment.md)
 - [Model.Queue](docs/Queue.md)
 - [Model.Quota](docs/Quota.md)
 - [Model.RAMStat](docs/RAMStat.md)
 - [Model.RDCActivation](docs/RDCActivation.md)
 - [Model.RDCHost](docs/RDCHost.md)
 - [Model.RDCSession](docs/RDCSession.md)
 - [Model.RDCSessionCreate](docs/RDCSessionCreate.md)
 - [Model.RegisterUploadEndpointRequest](docs/RegisterUploadEndpointRequest.md)
 - [Model.RegisterUploadMetadataEndpointRequest](docs/RegisterUploadMetadataEndpointRequest.md)
 - [Model.ReleaseNotesEndpointResponse](docs/ReleaseNotesEndpointResponse.md)
 - [Model.RenameCustomFieldRequest](docs/RenameCustomFieldRequest.md)
 - [Model.RenderEndpointRequest](docs/RenderEndpointRequest.md)
 - [Model.RenderRequest](docs/RenderRequest.md)
 - [Model.RestoreEndpointRequest](docs/RestoreEndpointRequest.md)
 - [Model.SAMLProviderMini](docs/SAMLProviderMini.md)
 - [Model.SMTPConfiguration](docs/SMTPConfiguration.md)
 - [Model.SNFSStripeGroup](docs/SNFSStripeGroup.md)
 - [Model.ScannerDiscoverEndpointRequest](docs/ScannerDiscoverEndpointRequest.md)
 - [Model.ScannerScanEndpointRequest](docs/ScannerScanEndpointRequest.md)
 - [Model.Schedule](docs/Schedule.md)
 - [Model.SchedulePartialUpdate](docs/SchedulePartialUpdate.md)
 - [Model.ScheduleReference](docs/ScheduleReference.md)
 - [Model.SearchEndpointRequest](docs/SearchEndpointRequest.md)
 - [Model.SearchEndpointResponse](docs/SearchEndpointResponse.md)
 - [Model.SendLinkEmailRequest](docs/SendLinkEmailRequest.md)
 - [Model.Sensor](docs/Sensor.md)
 - [Model.Sensors](docs/Sensors.md)
 - [Model.ServiceStatus](docs/ServiceStatus.md)
 - [Model.Share](docs/Share.md)
 - [Model.SharePartialUpdate](docs/SharePartialUpdate.md)
 - [Model.ShareToHomeWorkspaceEndpointRequest](docs/ShareToHomeWorkspaceEndpointRequest.md)
 - [Model.SlackChannel](docs/SlackChannel.md)
 - [Model.SlackConnection](docs/SlackConnection.md)
 - [Model.SlackConnectionPartialUpdate](docs/SlackConnectionPartialUpdate.md)
 - [Model.SlackConnectionStatus](docs/SlackConnectionStatus.md)
 - [Model.SlackEmoji](docs/SlackEmoji.md)
 - [Model.SlackMessage](docs/SlackMessage.md)
 - [Model.SlackUser](docs/SlackUser.md)
 - [Model.Snapshot](docs/Snapshot.md)
 - [Model.SnapshotPartialUpdate](docs/SnapshotPartialUpdate.md)
 - [Model.SolrReindexEndpointResponse](docs/SolrReindexEndpointResponse.md)
 - [Model.StartJobRequest](docs/StartJobRequest.md)
 - [Model.StartTaskRequest](docs/StartTaskRequest.md)
 - [Model.Stats](docs/Stats.md)
 - [Model.StorNextConnection](docs/StorNextConnection.md)
 - [Model.StorNextConnections](docs/StorNextConnections.md)
 - [Model.StorNextLicenseCheckEndpointResponse](docs/StorNextLicenseCheckEndpointResponse.md)
 - [Model.StorNextLicenseEndpointResponse](docs/StorNextLicenseEndpointResponse.md)
 - [Model.StorageNode](docs/StorageNode.md)
 - [Model.StorageNodeMini](docs/StorageNodeMini.md)
 - [Model.StorageNodeStatus](docs/StorageNodeStatus.md)
 - [Model.StornextLicense](docs/StornextLicense.md)
 - [Model.StornextManagerAttributes](docs/StornextManagerAttributes.md)
 - [Model.Subclip](docs/Subclip.md)
 - [Model.SubclipClipboardEntry](docs/SubclipClipboardEntry.md)
 - [Model.SubclipPartialUpdate](docs/SubclipPartialUpdate.md)
 - [Model.SubclipReference](docs/SubclipReference.md)
 - [Model.Subtask](docs/Subtask.md)
 - [Model.SubtaskPartialUpdate](docs/SubtaskPartialUpdate.md)
 - [Model.SubtaskReference](docs/SubtaskReference.md)
 - [Model.SyncTOTP](docs/SyncTOTP.md)
 - [Model.SyncTOTPRequest](docs/SyncTOTPRequest.md)
 - [Model.SystemInfoEndpointResponse](docs/SystemInfoEndpointResponse.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.TagMediaDirectoryRequest](docs/TagMediaDirectoryRequest.md)
 - [Model.TagPartialUpdate](docs/TagPartialUpdate.md)
 - [Model.TagReference](docs/TagReference.md)
 - [Model.Tape](docs/Tape.md)
 - [Model.TapeFile](docs/TapeFile.md)
 - [Model.TapeGroup](docs/TapeGroup.md)
 - [Model.TapeGroupPartialUpdate](docs/TapeGroupPartialUpdate.md)
 - [Model.TapeJob](docs/TapeJob.md)
 - [Model.TapeJobSource](docs/TapeJobSource.md)
 - [Model.TapeLibraryEndpointResponse](docs/TapeLibraryEndpointResponse.md)
 - [Model.TapeLibraryFormatEndpointRequest](docs/TapeLibraryFormatEndpointRequest.md)
 - [Model.TapeLibraryFsckEndpointRequest](docs/TapeLibraryFsckEndpointRequest.md)
 - [Model.TapeLibraryLoadEndpointRequest](docs/TapeLibraryLoadEndpointRequest.md)
 - [Model.TapeLibraryMoveEndpointRequest](docs/TapeLibraryMoveEndpointRequest.md)
 - [Model.TapeLibraryReindexEndpointRequest](docs/TapeLibraryReindexEndpointRequest.md)
 - [Model.TapeLibrarySlot](docs/TapeLibrarySlot.md)
 - [Model.TapeLibraryUnloadEndpointRequest](docs/TapeLibraryUnloadEndpointRequest.md)
 - [Model.TapePartialUpdate](docs/TapePartialUpdate.md)
 - [Model.TapeReference](docs/TapeReference.md)
 - [Model.TaskInfo](docs/TaskInfo.md)
 - [Model.TaskLog](docs/TaskLog.md)
 - [Model.TaskProgress](docs/TaskProgress.md)
 - [Model.TaskType](docs/TaskType.md)
 - [Model.TasksSummary](docs/TasksSummary.md)
 - [Model.TeamsConnection](docs/TeamsConnection.md)
 - [Model.TeamsConnectionPartialUpdate](docs/TeamsConnectionPartialUpdate.md)
 - [Model.TeamsConnectionStatus](docs/TeamsConnectionStatus.md)
 - [Model.TeamsMessage](docs/TeamsMessage.md)
 - [Model.TeamsRecipient](docs/TeamsRecipient.md)
 - [Model.TestAWSCredentialsRequest](docs/TestAWSCredentialsRequest.md)
 - [Model.TestAWSCredentialsResponse](docs/TestAWSCredentialsResponse.md)
 - [Model.TestExternalTranscoderConnectionRequest](docs/TestExternalTranscoderConnectionRequest.md)
 - [Model.TestExternalTranscoderConnectionResponse](docs/TestExternalTranscoderConnectionResponse.md)
 - [Model.TestSMTP](docs/TestSMTP.md)
 - [Model.Ticket](docs/Ticket.md)
 - [Model.TimeEndpointRequest](docs/TimeEndpointRequest.md)
 - [Model.TimeEndpointResponse](docs/TimeEndpointResponse.md)
 - [Model.TimeSyncEndpointRequest](docs/TimeSyncEndpointRequest.md)
 - [Model.TimeSyncEndpointResponse](docs/TimeSyncEndpointResponse.md)
 - [Model.TimelineExportRequest](docs/TimelineExportRequest.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.TraceNode](docs/TraceNode.md)
 - [Model.TranscoderProfile](docs/TranscoderProfile.md)
 - [Model.TypeDocumentation](docs/TypeDocumentation.md)
 - [Model.UpdateQuotaRequest](docs/UpdateQuotaRequest.md)
 - [Model.UploadChunkEndpointRequest](docs/UploadChunkEndpointRequest.md)
 - [Model.UserPreviewRequest](docs/UserPreviewRequest.md)
 - [Model.UserPreviewResponse](docs/UserPreviewResponse.md)
 - [Model.VantageWorkflow](docs/VantageWorkflow.md)
 - [Model.VantageWorkflows](docs/VantageWorkflows.md)
 - [Model.Volume](docs/Volume.md)
 - [Model.VolumeBeeGFSStatus](docs/VolumeBeeGFSStatus.md)
 - [Model.VolumeLizardFSStatus](docs/VolumeLizardFSStatus.md)
 - [Model.VolumeMini](docs/VolumeMini.md)
 - [Model.VolumeMiniReference](docs/VolumeMiniReference.md)
 - [Model.VolumePartialUpdate](docs/VolumePartialUpdate.md)
 - [Model.VolumeReference](docs/VolumeReference.md)
 - [Model.VolumeSNFSStatus](docs/VolumeSNFSStatus.md)
 - [Model.VolumeStat](docs/VolumeStat.md)
 - [Model.VolumeStats](docs/VolumeStats.md)
 - [Model.VolumeStatus](docs/VolumeStatus.md)
 - [Model.WorkflowTransitionRequest](docs/WorkflowTransitionRequest.md)
 - [Model.WorkflowTransitionResponse](docs/WorkflowTransitionResponse.md)
 - [Model.Workspace](docs/Workspace.md)
 - [Model.WorkspaceCheckIn](docs/WorkspaceCheckIn.md)
 - [Model.WorkspaceEndpoint](docs/WorkspaceEndpoint.md)
 - [Model.WorkspaceMoveToRequest](docs/WorkspaceMoveToRequest.md)
 - [Model.WorkspacePartialUpdate](docs/WorkspacePartialUpdate.md)
 - [Model.WorkspacePermission](docs/WorkspacePermission.md)
 - [Model.WorkspacePermissionPartialUpdate](docs/WorkspacePermissionPartialUpdate.md)
 - [Model.WorkspaceResolvedPermission](docs/WorkspaceResolvedPermission.md)
 - [Model.Workstation](docs/Workstation.md)
 - [Model.WorkstationPartialUpdate](docs/WorkstationPartialUpdate.md)

