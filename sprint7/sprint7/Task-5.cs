using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


class Department
{
    public string Name { get; set; }
    public int Id {  get; set; }

    public Worker Manager { get; set; }
    
    public Department(string name, int id, Worker manager)
    {
        Name = name;
        Id = id;
        Manager = manager;
    }
}


class Worker
{
    [JsonIgnore]
    public int Id { get; set; }

    [JsonPropertyName("Full name")]
    public string Name { get; set; }

    public decimal Salary { get; set; }
    
    public Department Department { get; set; }
    public Worker(string name, decimal salary, Department department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string Serialize()
    {
        var workerJson = this;

        var options = new JsonSerializerOptions { WriteIndented = true,  DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        return JsonSerializer.Serialize(workerJson, options);
    }
    public static Worker Deserialize(string json)
    {
        var workerJson = JsonSerializer.Deserialize<Worker>(json);
        var manager = workerJson.Department?.Manager != null
     ? new Worker(workerJson.Department.Manager.Name, workerJson.Department.Manager.Salary, null)
     : null;

        return new Worker(workerJson.Name, workerJson.Salary, new Department(workerJson.Department.Name, workerJson.Department.Id, manager)); ;
    }
}