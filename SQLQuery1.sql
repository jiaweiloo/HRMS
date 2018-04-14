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

CREATE TABLE [dbo].[netpay]
(
	[payroll_id] INT NOT NULL PRIMARY KEY, 
    [people_id] VARBINARY(15) NULL, 
    [total_attendance] INT NULL, 
    [total_absence] INT NULL, 
    [final_pay] DECIMAL NULL,

);

CREATE TABLE [dbo].[deduction]
(
	[deduction_id] INT NOT NULL PRIMARY KEY, 
    [deduction_type] VARCHAR(15) NOT NULL, 
    [deduction_value] NUMERIC NOT NULL, 
    [deduction_format] VARCHAR(20) NOT NULL, 
    [people_id] VARCHAR(15) NOT NULL, 
    [deduction_month] INT NOT NULL, 
    [deduction_year] INT NOT NULL
);


CREATE TABLE [dbo].[attend]
(
	[attendance_id] VARCHAR(15) NOT NULL PRIMARY KEY, 
    [people_id] VARCHAR(15) NOT NULL, 
    [current_date] DATE NOT NULL, 
    [time_in] DATE NULL, 
    [time_out] DATE NULL, 
    [lunch_in] DATE NULL, 
    [lunch_out] DATE NULL
)

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
    [deduction_value]  NUMERIC (18) NULL,
    [deduction_format] VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([deduction_id] ASC)
);

INSERT INTO [dbo].[People] VALUES ('HR10001',10001,'hr123','Jason','950612105326','1995-06-12','Male','0105422863','jason@gmail.com','Kuala Lumpur','HR','HR Dept.',5,0,15);
INSERT INTO [dbo].[People] VALUES ('MAN10001',10002,'man123','Bryan','900112105856','1990-01-12','Male','0108562495','bryan@gmail.com','Kuala Lumpur','Manager','HR Dept.',5,0,15);
INSERT INTO [dbo].[People] VALUES ('STF10001',10003,'staff123','Jimmy','940806105856','1994-08-06','Male','0108452395','jimmy@gmail.com','Petaling Jaya','Staff','IT Dept.',5,0,15);