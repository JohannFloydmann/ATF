CREATE TABLE [dbo].[USER] (
    [u_login]          VARCHAR (30) NOT NULL,
    [u_password]       VARCHAR (20) NOT NULL,
    [u_name]           VARCHAR (30) NULL,
    [u_surname]        VARCHAR (30) NULL,
    [u_email]          VARCHAR (30) NULL,
    [u_phonenNumber]   INT			NULL,
    [u_currentMoney]   BIGINT        NULL DEFAULT 0,
    [u_increasedMoney] BIGINT        NULL DEFAULT 0,
    [u_decreasedMoney] BIGINT        NULL DEFAULT 0
);
