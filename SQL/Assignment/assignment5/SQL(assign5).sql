create or alter proc GenratePaySlip (@empid int)
as 
begin
declare @ename varchar(30),@salary float,@HRA float,@DA float,@PF float,@IT float,@deductions float,@gross_sal float
select @ename=ename,@salary=sal from EMP where empno=@empid
set @HRA=@salary*0.1
set @DA=@salary*0.2
set @PF=@salary*0.08
set @IT=@salary*0.05
set @deductions=@PF+@IT
set @gross_sal=@salary+@HRA+@DA
print'----------------------- Payslip -----------------------'
print'Employee ID: ' + CAST(@empid AS varchar(10))
print'Employee Name: ' + @ename
print'Salary: ' + cast(@salary as varchar(10))
print'--------------------------------------------------------'
print'HRA (10% of Salary): ' + cast(@HRA as varchar(10))
print'DA (20% of Salary): ' + cast(@DA as varchar(10))
print'Gross Salary: ' + cast(@gross_sal as varchar(10))
print'--------------------------------------------------------'
print'PF (8% of Salary): ' + cast(@PF as varchar(10))
print'IT (5% of Salary): ' + cast(@IT as varchar(10))
print'Deductions (PF + IT): ' + cast(@deductions as varchar(10))
print'--------------------------------------------------------'
print'Net Salary: ' + cast(@gross_sal-@deductions as varchar(10))
print'--------------------------------------------------------'
end

exec GenratePaySlip 7839