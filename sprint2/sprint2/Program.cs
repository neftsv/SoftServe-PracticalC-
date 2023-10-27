﻿using System.Xml.Linq;

class Employee
{
    internal string name;
    private DateTime hiringDate;

    public Employee(string name, DateTime hiringDate)
    {
        this.name = name;
        this.hiringDate = hiringDate;
    }

    public int Experience()
    {
        DateTime nowTime = DateTime.Now;
        int fullYear = nowTime.Year - hiringDate.Year;

        if (nowTime.Month < hiringDate.Month || (nowTime.Month == hiringDate.Month && nowTime.Day < hiringDate.Day))
        {
            fullYear--;
        }
        return fullYear;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{name} has {Experience()} years of experience");
    }
}

class Developer : Employee
{
    private string programmingLanguage;

    public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"{name} is {programmingLanguage} programmer");
    }
}

class Tester : Employee
{
    private bool isAuthomation;

    public Tester(string name, DateTime hiringDate, bool isAuthomation) : base(name, hiringDate)
    {
        this.isAuthomation = isAuthomation;
    }

    public void ShowInfo()
    {
        if (isAuthomation)
            Console.WriteLine($"{name} is authomated tester and has {Experience()} year(s) of experience");
        else Console.WriteLine($"{name} is manual tester and has {Experience()} year(s)of experience");
    }
}