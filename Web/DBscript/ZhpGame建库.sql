use master -- 设置当前数据库为master,以便访问sysdatabases表
go
if exists(select * from sysdatabases where name='ZhpGame')
drop database ZhpGame
go


create database ZhpGame 
on  primary  -- 默认就属于primary文件组,可省略
(
/*--数据文件的具体描述--*/
    name='ZhpGame_data',  -- 主数据文件的逻辑名称
    filename='D:\ZhpGame_data.mdf', -- 主数据文件的物理名称
    size=5mb, --主数据文件的初始大小
    maxsize=100mb, -- 主数据文件增长的最大值
    filegrowth=15%--主数据文件的增长率
)
log on
(
/*--日志文件的具体描述,各参数含义同上--*/
    name='ZhpGame_log',
    filename='D:\ZhpGame_log.ldf',
    size=2mb,
    filegrowth=1mb
)

