use ZhpGame

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2017/7/12 15:46:19                           */
/*==============================================================*/


if exists (select 1
            from  ZhpGame.dbo.sysobjects 
           where  id = object_id('SYS_CONFIG')
            and   type = 'U')
   drop table SYS_CONFIG
go

if exists (select 1
            from  ZhpGame.dbo.sysobjects
           where  id = object_id('SYS_MENU')
            and   type = 'U')
   drop table SYS_MENU
go

use [ZhpGame]
/*==============================================================*/
/* Table: SYS_CONFIG                                            */
/*==============================================================*/
create table SYS_CONFIG (
   ID                   int          identity(1,1)        not null,
   SystemName           nvarchar(124)        null,
   SystemVersion        nvarchar(124)        null,
   SystemIcon 			nvarchar(124) 		 NULL,
   UpdateTime           nvarchar(30)		 NULL,
   constraint PK_SYS_CONFIG primary key (ID)
)
go

/*==============================================================*/
/* Table: SYS_MENU                                              */
/*==============================================================*/
create table SYS_MENU (
   ID                   int          identity(1,1)        not null,
   MenuName             nvarchar(30)         null,
   MenuLevel            int                  null,
   MenuIcon 			nvarchar(50) 		 NULL,
   MenuUrl              nvarchar(124)        null,
   ParentMenu           int                  null,
   Isdelete             int            default(0)      null,
   Sort  				nvarchar(2)			 null,
   BelongSys			int                  null,
   Remark               nvarchar(512)        null,
   UpdateTime           nvarchar(30)		 NULL,
   Alias				nvarchar(16)		 NULL,
   constraint PK_SYS_MENU primary key (ID)
)
go

/*==============================================================*/
/* Table: SYS_DEPARTMENT                                            */
/*==============================================================*/
create table SYS_DEPARTMENT (
   ID                   int          identity(1,1)        not null,
   DepartName           nvarchar(30)         null,
   DepartCode           nvarchar(20)         null,
   ChargeMan 			nvarchar(50) 		 NULL,
   ChargeManPhone       nvarchar(20)         null,
   ParentDepart         nvarchar(20)                  null,
   Isdelete             int       default(0)      null,
   Remark               nvarchar(512)        null,
   Alias				nvarchar(16)		 null,
   UpdateTime           nvarchar(30)		 NULL,
   constraint PK_SYS_DEPARTMENT primary key (ID)
)
go


/*==============================================================*/
/* Table: SYS_USERINFO                                            */
/*==============================================================*/
create table SYS_USERINFO (
   UserID                   int          identity(1,1)        not null,
   UserName           	nvarchar(30)         null,
   Password           	nvarchar(16)         null,
   RealName 			nvarchar(30) 		 NULL,
   Phone       			nvarchar(20)         null,
   Email         		nvarchar(30)         null,
   CreateTime			datetime				null,
   LastLoginTime		datetime				null, 
   Department			nvarchar(30)		 null,
   Count				int 	  default(0)	null,
   Isdelete             int       default(0)    null,
   State				int       default(1)	null,
   constraint PK_SYS_USERINFO primary key (UserID)
)
go

/*==============================================================*/
/* Table: SYS_ROLE                                            */
/*==============================================================*/
create table SYS_ROLE (
   RoleID                   int          identity(1,1)        not null,
   RoleName           	nvarchar(30)            null,
   CreateTime			datetime				null,
   Description			nvarchar(300)			null,
   constraint PK_SYS_ROLE primary key (RoleID)
)
go


/*==============================================================*/
/* Table: SYS_PERMISSION                                            */
/*==============================================================*/
create table SYS_PERMISSION (
   PermissionID         int          identity(1,1)        not null,
   PermissionName       nvarchar(30)            null,
   CreateTime			datetime				null,
   Description			nvarchar(300)			null,
   constraint PK_SYS_PERMISSION primary key (PermissionID)
)
go


/*==============================================================*/
/* Table: SYS_USER_ROLE_RELATION                                            */
/*==============================================================*/
create table SYS_USER_ROLE_RELATION (
	ID 					int			identity(1,1)        not null,
   UserID       int          	null,
   RoleID       int            null,
   constraint PK_SYS_USER_ROLE_RELATION primary key (ID)
)
go

/*==============================================================*/
/* Table: SYS_ROLE_PERMISSION_RELATION                                            */
/*==============================================================*/
create table SYS_ROLE_PERMISSION_RELATION (
	ID 					int			identity(1,1)        not null,
   RoleId           	int                     null,
   PermissionID			int 		    		null,
    constraint PK_SYS_ROLE_PERMISSION_RELATION primary key (ID)
)
go


/*==============================================================*/
/* Table: SYS_PERMISSION_MENU_RELATION                                            */
/*==============================================================*/
create table SYS_PERMISSION_MENU_RELATION (
   ID 					int			identity(1,1)        not null,
   PermissionID         int         null,
   MenuID           	int         null,
   Access			nvarchar(16)			null,   --1000浏览 1100 浏览、添加 1110 浏览、添加、编辑 1111 浏览、添加、编辑、删除
   constraint PK_SYS_PERMISSION_MENU_RELATION primary key (ID)
)
go

/*==============================================================*/
/* Table: Zhp_AwardsLimited                                     */
/*==============================================================*/
create table Zhp_AwardsLimited (
   Id                   int         identity(1,1)          not null,
   AwardId              int                  null,
   Gameid               int                  null,
   GameSoreEdge         nvarchar(32)         null,
   AwardImage           text                 null,
   constraint PK_ZHP_AWARDSLIMITED primary key (Id)
)
go

/*==============================================================*/
/* Table: Zhp_GameApi                                           */
/*==============================================================*/
create table Zhp_GameApi (
   ApiId                int       identity(1,1)            not null,
   ApiName              nvarchar(16)         null,
   Protocol             nvarchar(32)         null,
   ApiUrl               text                 null,
   ApiMethod            nvarchar(8)          null,
   RequestData          text                 null,
   ResponseData         text                 null,
   RequestContentType   nvarchar(32)         null,
   ResponseContentType  text                 null,
   Remark               text                 null,
   constraint PK_ZHP_GAMEAPI primary key (ApiId)
)
go

/*==============================================================*/
/* Table: Zhp_GameAwards                                        */
/*==============================================================*/
create table Zhp_GameAwards (
   AwardId              int        identity(1,1)           not null,
   AwardName            nvarchar(32)         null,
   Description          text                 null,
   constraint PK_ZHP_GAMEAWARDS primary key (AwardId)
)
go

/*==============================================================*/
/* Table: Zhp_GameConfig                                        */
/*==============================================================*/
create table Zhp_GameConfig (
   ID                   int       identity(1,1)            not null,
   GameName             nvarchar(32)         null,
   GameCode             nvarchar(32)         null,
   Description          text                 null,
   Remark               text                 null,
   [State] [nvarchar](2) NULL default('1'),
   [CreateTime] [datetime] NULL,
   constraint PK_ZHP_GAMECONFIG primary key (ID)
)
go

/*==============================================================*/
/* Table: Zhp_GameRecord                                        */
/*==============================================================*/
create table Zhp_GameRecord (
   ID                   int       identity(1,1)            not null,
   Gameid               int                  null,
   PlayerScore          nvarchar(32)         null,
   PlayerNickname       nvarchar(124)        null,
   PlayerOpenId         nvarchar(124)        null,
   ComputerName         nvarchar(32)         null,
   UploadTime           datetime             null,
   SaveTime             datetime             null,
   constraint PK_ZHP_GAMERECORD primary key (ID)
)
go

/*==============================================================*/
/* Table: Zhp_OnlineGame                                        */
/*==============================================================*/
create table Zhp_OnlineGame (
   Gameid               int       identity(1,1)            not null,
   GameCode             nvarchar(32)         null,
   GameStartTime        datetime             null,
   GameEndTime          datetime             null,
   Remark               text                 null,
   constraint PK_ZHP_ONLINEGAME primary key (Gameid)
)
go

/*==============================================================*/
/* Table: Zhp_WxUserInfo                                        */
/*==============================================================*/
create table Zhp_WxUserInfo (
   ID                   int        identity(1,1)           not null,
   openid               nvarchar(100)        null,
   nickname             nvarchar(50)         null,
   sex                  nvarchar(2)          null,
   language             nvarchar(10)         null,
   city                 nvarchar(32)         null,
   province             nvarchar(32)         null,
   country              nvarchar(32)         null,
   headimgurl           text                 null,
   privilege            text                 null,
   constraint PK_ZHP_WXUSERINFO primary key (ID)
)
go

--新增权限，列出所有菜单，一个菜单4个复选框，用户管理，系统管理，平台管理， 各自绑定增删改查 就出来一个权限

--新增角色，复选框多个权限，所有权限

--用户指定权限，下拉菜单，所有的角色

--用户->角色集合->权限集合->获取所有权限集合->存入缓存，根据缓存的一级菜单，二级菜单，三级菜单生成菜单

--点击菜单，把相应的菜单ID,ACCESS+按钮类型传入，界面是否显示按钮



--简单描述，用户登录，获取角色，角色关联权限组，权限组关联菜单、页面操作等具体权限

--用户-对应一个角色，一个角色可以对应多个权限组，一个权限组对应多个权限，一个权限对应一个相应的操作










































