CREATE TABLE [dbo].[People] (
    [people_id]       VARCHAR (15)  NOT NULL,
    [people_index]       INT  NOT NULL,
    [people_password] VARCHAR (15)  NOT NULL,
    [people_name]     VARCHAR (20)  NOT NULL,
    [people_ic]       VARCHAR (15)  NOT NULL,
    [people_DOB]      VARCHAR (15)  NOT NULL,
    [people_gender]   VARCHAR (15)  NOT NULL,
    [people_phone]    VARCHAR (15)  NOT NULL,
    [people_email]    VARCHAR (30)  NOT NULL,
    [people_address]  VARCHAR (100) NOT NULL,
    [people_role]     VARCHAR (15)  NOT NULL,
    [department_name] VARCHAR (30)  NOT NULL,
    [leave_num] INT  NOT NULL,
    [extra_leave] INT  NOT NULL,
    [hourly_rates] DECIMAL  NOT NULL,	
    PRIMARY KEY CLUSTERED ([people_id] ASC)
);

CREATE TABLE [dbo].[Leave] (
    [leave_id]            VARCHAR (10)  NOT NULL,
    [leave_date]          DATE          NOT NULL,
    [apply_date]          DATE          NOT NULL,
    [leave_duration]      INT           NOT NULL,
    [reason]              VARCHAR (100) NOT NULL,
    [people_id]           VARCHAR (10)  NOT NULL,
    [status]              VARCHAR (10)  NULL,
    [Reject_approve_date] DATE          NULL,
    PRIMARY KEY CLUSTERED ([leave_id] ASC)
);

CREATE TABLE [dbo].[netpay] (
    [payroll_id]        INT          NOT NULL,
    [people_id]         VARCHAR (15) NULL,
    [total_attendance]  INT          NULL,
    [total_absence]     INT          NULL,
    [final_pay]         DECIMAL (18, 2) NULL,
    [generated_date]    DATE         NULL,
    [ttl_mandatory_ddt] DECIMAL (18, 2) NULL,
    [ttl_deduction]     NUMERIC (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([payroll_id] ASC)
);



CREATE TABLE [dbo].[attend] (
    [attendance_id] VARCHAR (15) NOT NULL,
    [people_id]     VARCHAR (15) NOT NULL,
    [current_date]  DATE         NOT NULL,
    [time_in]       TIME         NULL,
    [time_out]      TIME         NULL,
    [lunch_in]      TIME         NULL,
    [lunch_out]     TIME         NULL,
    PRIMARY KEY CLUSTERED ([attendance_id] ASC)
);

CREATE TABLE [dbo].[overtime] (
    [overtime_id]       INT        NOT NULL,
    [people_id]         VARCHAR(15) NULL,
    [overtime_duration] INT NULL,
    [overtime_date]     DATE NULL,
    PRIMARY KEY CLUSTERED ([overtime_id] ASC)
);

CREATE TABLE [dbo].[mandatory_deduction] (
    [deduction_id]     INT          NOT NULL,
    [deduction_type]   VARCHAR (20) NULL,
    [deduction_value]  FLOAT (53)   NULL,
    [deduction_format] VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([deduction_id] ASC)
);

INSERT INTO [dbo].[People] VALUES ('HR10001',10001,'hr123','Jason','950612105326','1995-06-12','Male','0105422863','jason@gmail.com','Kuala Lumpur','HR','HR Dept.',5,0,15);
INSERT INTO [dbo].[People] VALUES ('MAN10001',10002,'man123','Bryan','900112105856','1990-01-12','Male','0108562495','bryan@gmail.com','Kuala Lumpur','Manager','HR Dept.',5,0,15);
INSERT INTO [dbo].[People] VALUES ('STF10001',10003,'staff123','Jimmy','940806105856','1994-08-06','Male','0108452395','jimmy@gmail.com','Petaling Jaya','Staff','IT Dept.',5,0,15);
INSERT INTO [dbo].[People] VALUES ('STF10002',10004,'staff123','Jun Kit','960619105856','1996-06-19','Male','0121234567','jjzaii@gmail.com','Rawang','Staff','IT Dept.',5,0,15);
INSERT INTO [dbo].[People] VALUES ('STF10003',10005,'staff123','Jackson','970619105856','1997-06-19','Male','0121888867','jackson@gmail.com','Klang','Staff','IT Dept.',5,0,15);

INSERT INTO [dbo].[Leave] VALUES ('L00001','2018-03-14','2018-03-10',2,'SICK','STF10001','APPROVE','2018-03-11');
INSERT INTO [dbo].[Leave] VALUES ('L00002','2018-04-14','2018-04-10',2,'SICK','STF10001','PENDING',null);

INSERT INTO [dbo].[netpay] VALUES (30001,'STF10001',21,1,3600.15);
INSERT INTO [dbo].[netpay] VALUES (30002,'STF10002',22,0,4600.15);
INSERT INTO [dbo].[netpay] VALUES (30003,'STF10003',20,2,2800.15);
	
INSERT INTO [dbo].[deduction] VALUES (20001,'extraholiday',200,'money','STF10001',4,2018);
INSERT INTO [dbo].[deduction] VALUES (20002,'rentcompanyitems',200,'money','STF10001',4,2018);
	
INSERT INTO [dbo].[attend] ([attendance_id], [people_id], [current_date], [time_in], [time_out], [lunch_in], [lunch_out]) VALUES (N'A10001', N'STF10002', N'2018-04-14', N'19:50:34', N'19:55:36', N'19:55:29', N'19:55:33');
INSERT INTO [dbo].[overtime] VALUES (30003,'STF10001',2.1,'2018-04-14');

INSERT INTO [dbo].[mandatory_deduction] VALUES (40001,'SOCSO',200,'money');
INSERT INTO [dbo].[mandatory_deduction] VALUES (40002,'EPF',100,'money');
INSERT INTO [dbo].[mandatory_deduction] VALUES (40003,'COPERASI TAX',2.2,'percentage');

/*
DROP TABLE [dbo].[People];
DROP TABLE [dbo].[Leave];
DROP TABLE [dbo].[netpay]
DROP TABLE [dbo].[deduction];
DROP TABLE [dbo].[attend];
DROP TABLE [dbo].[overtime];
DROP TABLE [dbo].[mandatory_deduction];
*/

