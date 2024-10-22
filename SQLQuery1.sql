create  database Adoproj
use Adoproj
create table product (pid int,pname varchar(30),pdesc varchar(50))

create procedure insprod (@pid int,@pname varchar (30),@pdesc varchar(30))
as
insert into product values (@pid,@pname,@pdesc)

create procedure updpro (@pid int,@pname varchar (30),@pdesc varchar (30))
as
update  product set pname = @pname,@pdesc=@pdesc where pid = @pid

create procedure dispro 
as 
select * from product

create procedure dispro1(@pid int)
as
select * from product where pid=@pid

create procedure delpro
as
delete from product
drop procedure delpro

create procedure delpro1 (@pid int)

as
delete from product where pid =@pid

select @@servername
 
 alter table product add constraint pk_product primary key(pid)
 alter table product alter column pid int not null

 create table Model(mid int constraint pk_mod primary key,mname varchar(30),pid int constraint fk_mod references product (pid),pname varchar (30),spec varchar (100),uprice int,soh int)

 create procedure InsModel (@mid int,@mname varchar (30),@pid int,@pname varchar (30),@spec varchar(100),@uprice int,@soh int)
 as
 insert into Model values (@mid,@mname,@pid,@pname,@spec,@uprice,@soh)

 create procedure UpdModel(@mid int,@mname varchar(30),@pid int,@pname varchar (30),@spec varchar (100),@uprice int,@soh int)
 as
 update model set mname=@mname,pid=@pid,pname=@pname,spec=@spec,uprice =@uprice,soh=@soh where mid=@mid

 create procedure dispmodel
 as
 select * from model 

 create procedure dispmodel1 (@mid int)
 as
 select * from model where mid=@mid
 
 create procedure Delmodel
 as
 delete  from model

 create procedure Delmodel1(@mid int)
 as
 delete from model where mid=@mid

 create table users (uid varchar(20),pwd varchar(20),utype varchar(20))
 select *from users

 create procedure Insuser(@uid varchar (20),@pwd varchar(20),@utype varchar(20))
 as
 insert into users values (@uid,@pwd,@utype)


 create procedure updusers(@uid varchar(20),@pwd varchar (30),@utype varchar (20))
 as
 update users set pwd=@pwd,utype=@utype where uid=@uid

 create procedure  dispuser
 as
 select * from users

 create procedure dispuser1(@uid varchar(20))
 as
 select * from users where uid=@uid
 
 create procedure deluser
 as
 delete  from users

 create procedure deluser1 (@uid varchar(20))
 as
 delete from users where uid=@uid

 create procedure chklog (@uid varchar (20),@pwd varchar (20),@utype varchar(20))
 as
 select count (*)from users where uid=@uid and pwd=@pwd and utype=@utype

 sp_columns users

 create table sales (billno int identity,billdate date default getdate(),pid int,pname varchar(30),mid int,mname varchar(30),spec varchar (100),uprice int,quantity int,totalamount int) 

 create procedure InsSales (@pid int,@pname varchar (30),@mid int,@mname varchar (30),@spec varchar (100),@uprice int,@quantity int,@totalamount int)
 as
 insert into sales (pid,pname,mid,mname,spec,uprice,quantity,totalamount)values(@pid,@pname,@mid,@mname,@spec,@uprice,@quantity,@totalamount)

 select * from sales

 create procedure dailyrpt
 as
 select * from sales where billdate=cast(getdate()as date)

 create procedure salesrpt(@fdate date,@tdate date)
 as
 select * from  sales where billdate between @fdate and @tdate


 create procedure productwiserpt(@pid int)
 as
 select * from sales where pid=@pid

 select * from sys.procedures

 create procedure modelwiserpt(@mid int)
 as
 select * from sales where mid=@mid

 create procedure loadpidfromsales
 as
 select distinct(pid) from sales
 create procedure loadmidfromsales
 as
 select distinct(mid) from sales

 EXEC loadpidfromsales
























