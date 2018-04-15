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
    [joined_year] DATE  NOT NULL,	
    PRIMARY KEY CLUSTERED ([people_id] ASC)
);

INSERT INTO [dbo].[People] VALUES ('HR10001',10001,'hr123','Jason','950612-10-5326','1995-06-12','Male','0105422863','jason@gmail.com','Kuala Lumpur','HR','HR Dept.',5,0,15,'15-APR-2018');
INSERT INTO [dbo].[People] VALUES ('MAN10001',10002,'man123','Bryan','900112-10-5856','1990-01-12','Male','0108562495','bryan@gmail.com','Kuala Lumpur','Manager','HR Dept.',5,0,15,'15-APR-2018');
INSERT INTO [dbo].[People] VALUES ('STF10001',10003,'staff123','Jimmy','940806-10-5856','1994-08-06','Male','0108452395','jimmy@gmail.com','Petaling Jaya','Staff','IT Dept.',5,0,15,'15-APR-2018');
INSERT INTO [dbo].[People] VALUES ('STF10002',10004,'staff123','Jun Kit','960619-10-5856','1996-06-19','Male','0121234567','jjzaii@gmail.com','Rawang','Staff','IT Dept.',5,0,15,'15-APR-2018');
INSERT INTO [dbo].[People] VALUES ('STF10003',10005,'staff123','Jackson','970619-10-5856','1997-06-19','Male','0121888867','jackson@gmail.com','Klang','Staff','IT Dept.',5,0,15,'15-APR-2018');