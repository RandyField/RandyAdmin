use master -- ���õ�ǰ���ݿ�Ϊmaster,�Ա����sysdatabases��
go
if exists(select * from sysdatabases where name='ZhpGame')
drop database ZhpGame
go


create database ZhpGame 
on  primary  -- Ĭ�Ͼ�����primary�ļ���,��ʡ��
(
/*--�����ļ��ľ�������--*/
    name='ZhpGame_data',  -- �������ļ����߼�����
    filename='D:\ZhpGame_data.mdf', -- �������ļ�����������
    size=5mb, --�������ļ��ĳ�ʼ��С
    maxsize=100mb, -- �������ļ����������ֵ
    filegrowth=15%--�������ļ���������
)
log on
(
/*--��־�ļ��ľ�������,����������ͬ��--*/
    name='ZhpGame_log',
    filename='D:\ZhpGame_log.ldf',
    size=2mb,
    filegrowth=1mb
)

